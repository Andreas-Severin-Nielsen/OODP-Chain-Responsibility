using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Chain_Responsibility
{
    class Taskhandler2 : Handler
    {

        public Taskhandler2(Handler successor) : base(successor)
        {
        }

        public override void HandleRequest()
        {
            Console.Write("Taskhandler2: ");
            base.HandleRequest();

        }
    }
}
