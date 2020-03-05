using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Chain_Responsibility
{
    public class Client
    {
        public void DoTheThing()
        {
            // ...
            Handler handler = new Taskhandler1(new Taskhandler2(new Taskhandler3()));
            Console.WriteLine("Issuing new task for handler...");
            handler.HandleRequest();
            Console.ReadKey();
        }
    }
}
