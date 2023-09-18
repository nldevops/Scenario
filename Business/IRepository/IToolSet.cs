using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IRepository
{
    public interface IToolSet
    {
        public string OrchestrateReturn(string str);
        public string GetCurrentTime();

        public string GetRandomLetter();
        public string GetTestData();


    }
}
