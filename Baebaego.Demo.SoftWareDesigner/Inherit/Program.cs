using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            User admin = new Admin(new EmployerPrintor());
            admin.PrintType();
            User contractor = new Contractor(new TempPrintor());
            contractor.PrintType();

            Console.ReadKey();
        }
    }

    class User
    {
        Printor m_printor;
        public User(Printor printor)
        {
            m_printor = printor;
        }

        public virtual void PrintType() { m_printor.PrintType(); }
    }

    class Admin : User
    {
        public Admin (Printor printor)
            : base(printor)
        {

        }
    }

    class Contractor : User
    {
        public Contractor(Printor printor)
            : base(printor)
        {

        }
    }

    class Printor
    {
        public virtual void PrintType() { }
    }

    class EmployerPrintor : Printor
    {
        public override void PrintType()
        {
            Console.WriteLine("Employer");
        }
    }

    class TempPrintor : Printor
    {
        public override void PrintType()
        {
            Console.WriteLine("Temp");
        }
    }
}
