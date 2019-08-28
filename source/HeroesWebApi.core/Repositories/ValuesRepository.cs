using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesWebApi.core.Repositories
{
    public interface IValuesRepository
    {
        string[] GetValues();
    }

    public class ValuesRepository : IValuesRepository
    {
        public string[] GetValues() => new string[] { "value1", "value2" };
    }
}
