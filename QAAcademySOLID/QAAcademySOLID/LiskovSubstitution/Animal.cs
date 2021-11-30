using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAcademySOLID.LiskovSubstitution
{
    public class Animal
    {
        public virtual void Run()
        {

        }

        public virtual void Walk()
        {

        }

        public virtual void Hunt()
        {

        }
    }

    public class Tiger : Animal
    {

    }

    public class Turtle : Animal
    {
        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override void Hunt()
        {
            throw new NotImplementedException();
        }
    }
}
