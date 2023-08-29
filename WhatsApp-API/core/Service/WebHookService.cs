using core.Domain.Entities;
using core.Infra.Repository;
using System;

namespace core.Service
{
    public class WebHookService : IWebHookService
    {
        private readonly WebHookRepository _repository;

        public WebHookService(WebHookRepository repository)
        {
            _repository = repository;
        }

        public void SaveMessage(WebHook objeto)
        {
            _repository.InsertMessage(objeto);
        }

    }
}
