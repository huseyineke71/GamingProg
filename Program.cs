using System;
using GamingProgram.Entities;
using GamingProgram.Abstract;
using GamingProgram.Concrete;


namespace GamingProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            BasePersonManager personManager = new PersonManager();
            personManager.Save(new Person {DateOfBirth = new DateTime(1980,25,5),FirstName ="Hüseyin",LastName ="Eker",NationalityId = "47895665699" });
            

            

        }
    }
    
    
    
}


