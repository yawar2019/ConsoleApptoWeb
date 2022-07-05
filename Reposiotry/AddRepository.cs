using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApptoWeb.Reposiotry
{
    public class AddRepository: IAddRepository
    {
        Guid a;
        public AddRepository()
        {
              a =  Guid.NewGuid();
        }

        public Guid getResult()
        {
            return a;
        }
    }
}
//new AddRepository();obj