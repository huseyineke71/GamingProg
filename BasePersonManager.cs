using GamingProgram.Entities;
using GamingProgram.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingProgram.Abstract
{
    public abstract  class BasePersonManager : IPersonService
    {
        public void Delete(Person person)
        {
            
        }

        public virtual void Save(Person person)
        {
            Console.WriteLine("Saved to db :" + person.FirstName);
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
