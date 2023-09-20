using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.IRepository;
using System.Reflection;


namespace Business
{
    public class Repository : IToolSet
    {       
        
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString();
        }

        public string GetRandomLetter()
        {
            //string random = "Z";
            //return random;
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num].ToString();
        }

        public string GetTestData()
        {
            return "testing";
        }

        public string OrchestrateReturn(string str)
        {
           
            //use reflection to get the methods at runtime.
            var instance = new Repository();

            //get all the methods
            var methods = typeof(Repository).GetMethods();
            foreach (var item in methods)
            {
                //to do improve the name check for method call with a valid 
                if (item.Name.Contains(str,StringComparison.CurrentCultureIgnoreCase))
                {
                    var result= item.Invoke(instance, parameters: null);
                    return result.ToString();
                }
            }        


             return "Not implemented";

        }
    }
}
