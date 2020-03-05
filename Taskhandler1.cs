using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Chain_Responsibility
{
    class Taskhandler1 : Handler
    {
        public Taskhandler1(Handler successor) : base(successor)
        {
        }
        
        public override void HandleRequest()
        {
            Console.Write("Taskhandler1: ");
            base.HandleRequest();
            
        }
    }
}
