using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{


    // Violating LSP :


    public class BadBird
    {
        public virtual void Fly()
        {
            Console.WriteLine("I can fly.");
        }
    }

    public class BadPenguin : BadBird
    {
        public override void Fly()
        {
            throw new NotImplementedException("Penguins cannot fly.");
        }
    }



    // Not Vaulated : 

    public interface IFlyable
    {
        void Fly();
    }

    public class Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("I can eat.");
        }
    }


    public class FlyingBird : Bird, IFlyable
    {
        public virtual void Fly()
        {
            Console.WriteLine("I can fly.");
        }
    }

    public class Penguin : Bird
    {
        // Penguins don't implement IFlyable, hence no Fly method.
    }

    public class Sparrow : FlyingBird
    {
        public override void Fly()
        {
            Console.WriteLine("I can fly high.");
        }
    }






}
