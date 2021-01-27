using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingProgram.Entities;
using GamingProgram.Concrete;

namespace GamingProgram.Abstract
{
    public interface IPersonService
    {
        void Save(Person person);
        void Update(Person person);
        void Delete(Person person);
    }
}
