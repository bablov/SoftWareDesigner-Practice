using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    /// <summary>
    /// 每需要增加一个状态，就需要增加一个switch分支
    /// </summary>
    public class Component_Bad
    {
        public enum Status
        {
            None,
            Installed,
            Uninstalled
        }

        Status m_status = Status.None;

        void Do()
        {
            switch(m_status)
            {
                case Status.None:
                    Console.WriteLine("Error...");
                    break;
                case Status.Installed:
                    Console.WriteLine("Hello!");
                    break;
                case Status.Uninstalled:
                    Console.WriteLine("Error...");
                    break;
                default:
                    break;
            }
        }
    }

    /// <summary>
    /// 需要添加新状态时，只需要添加一个新的子类即可
    /// </summary>
    public class ComponentStatus
    {
        public virtual void Do() { }
    }
    public class ComponentNone:ComponentStatus
    {
        public override void Do()
        {
            Console.WriteLine("Error...");
        }
    }
    public class ComponentInitialized:ComponentStatus
    {
        public override void Do()
        {
            Console.WriteLine("Hello!");
        }
    }

    public class Component
    {
        ComponentStatus m_status = new ComponentStatus();

        public void ChangeStatus(ComponentStatus newStatus)
        {
            m_status = newStatus;
        }

        public void Do()
        {
            m_status.Do();
        }
    }
}
