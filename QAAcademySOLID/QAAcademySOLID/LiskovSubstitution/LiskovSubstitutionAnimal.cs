using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QAAcademySOLID.Interfaces;

namespace QAAcademySOLID.LiskovSubstitution
{
    class LiskovSubstitutionAnimal
    {
    }

    public class LiskovTurtle : IWalk
    {
        public void Walk()
        {

        }
    }

    public class LiskovTiger : IHunt, IWalk, IRun
    {
        public void Hunt()
        {
            Console.WriteLine("Tiger needs to Hunt...");
        }

        public void Run()
        {

        }

        public void Walk()
        {

        }
    }
}
