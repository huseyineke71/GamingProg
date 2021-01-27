using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingProgram.Entities;
using GamingProgram.Abstract;

namespace GamingProgram.Concrete
{
    public class PersonManager : BasePersonManager
    {
        public override void Save(Person person)
        {
            base.Save(person);
        }
    }
}
