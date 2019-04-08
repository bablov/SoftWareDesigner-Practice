using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.onNameChange += user_onNameChange;
            user.Name = "hhh";


            View ui = new View(user);
            user.Name = "hello";

            Console.ReadKey();
        }

        private static void user_onNameChange(string name)
        {
            Console.WriteLine(name);
        }
    }

    delegate void OnNameChange(string name);
    class View
    {
        public View(User user)
        {
            user.onNameChange += user_onNameChange;
        }
        void user_onNameChange(string name)
        {
            Console.WriteLine(name);
        }
    }

    class User
    {
        private string m_name { get; set; }
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
                onNameChange(m_name);
            }
        }
        public event OnNameChange onNameChange;
    }
}
