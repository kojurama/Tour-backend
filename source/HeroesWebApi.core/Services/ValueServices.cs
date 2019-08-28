using HeroesWebApi.core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesWebApi.core.Services
{
    public interface IValuesService
    {
        string[] GetValues();
    }
    public class ValuesService : IValuesService
    {
        private readonly IValuesRepository valuesRepository;

        public ValuesService(IValuesRepository valuesRepository)
        {
            this.valuesRepository = valuesRepository;
        }

        public string[] GetValues() => valuesRepository.GetValues();
    }
}
