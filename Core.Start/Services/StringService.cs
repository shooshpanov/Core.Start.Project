using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Start.Services
{
    public interface IStringService
    {
        string GetDate();
    }

    public class StringService : IStringService
    {
        public string GetDate()
        {
            return DateTime.Now.ToString();
        }
    }
}
