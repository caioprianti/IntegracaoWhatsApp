using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using System.Web.Http;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.AspNetCore.Hosting;

namespace core.Controllers
{
    using ClosedXML.Excel;
    using core.Domain.Entities;
    using core.Domain.Interfaces;
    using core.Service;
    using DocumentFormat.OpenXml.Drawing;
    using DocumentFormat.OpenXml.Spreadsheet;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;

    [Route("api/[controller]")]
    [ApiController]
    public class AlertaController : Controller
    {
        protected readonly IAlertaService _AlertaService;
        protected readonly ICredencialService _CredencialService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private IConfiguration _config;
        int take = 100;
        public AlertaController(IAlertaService alertaService, IWebHostEnvironment webHostEnvironment, IConfiguration Configuration, ICredencialService CredencialService)
        {
            _webHostEnvironment = webHostEnvironment;
            _AlertaService = alertaService;
            _config = Configuration;
            _CredencialService = CredencialService;
        }

        [Authorize]
        [HttpGet]
        [Produces(typeof(List<alerta>))]
        [Route("GetFila")]
        public IActionResult GetFila()
        {
            try
            {
                List<alerta> lista = _AlertaService.GetFila();

                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Authorize]
        [HttpPut]
        [Produces(typeof(string))]
        [Route("MarcaMensagemEnviada")]
        public IActionResult MarcaMensagemEnviada(string id)
        {
            try
            {
                _AlertaService.UpdateMensagem(id);

                return Ok("Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPut]
        [Produces(typeof(string))]
        [Route("MarcaMensagemEnviadaBulk")]
        public IActionResult MarcaMensagemEnviadaBulk(List<string> ids)
        {
            try
            {
                foreach (var item in ids)
                {
                    _AlertaService.UpdateMensagem(item);
                }


                return Ok("Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPut]
        [Produces(typeof(string))]
        [Route("MarcaMensagemRecebida")]
        public IActionResult MarcaMensagemRecebida(string telefone, DateTime data)
        {
            try
            {
                _AlertaService.UpdateMensagemRecebida(telefone, data);

                return Ok("Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPost]
        [Produces(typeof(string))]
        [Route("InsereMensagem")]
        public IActionResult InsereMensagem([FromBody] alertaInsert mensagem, string grupo)
        {
            try
            {
                string ret = _AlertaService.InserirMensagem(mensagem, grupo);

                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Produces(typeof(string))]
        [Route("Login")]
        public IActionResult Login([FromBody] Usuario loginDetalhes)
        {
            var cred = _CredencialService.GetCredencial(loginDetalhes.User);
            bool resultado = false;
            if (cred != null)
            {
               resultado = ValidarUsuario(loginDetalhes, cred);
            }
             
            if (resultado)
            {
                var tokenString = GenerateJSONWebToken(loginDetalhes, cred);
                return Ok(new { token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }

        private string GenerateJSONWebToken(Usuario loginDetalhes, credencial credencial)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
        new Claim(JwtRegisteredClaimNames.Sub, "Usuário api whatsapp"),
                   // new Claim(JwtRegisteredClaimNames.Email, "email@email.com"),
                    new Claim("DateOfJoing", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

            var token = new JwtSecurityToken("Whatsapp-Api",
                "Whatsapp-Api",
                claims,
                expires: DateTime.Now.AddMinutes(credencial.Expiration),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
       
        private bool ValidarUsuario(Usuario loginDetalhes, credencial credencial)
        {
            if (_CredencialService.MD5(loginDetalhes.Secret) == credencial.Secret && loginDetalhes.User == credencial.User && credencial.Origem == "Whatsapp-Api")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
