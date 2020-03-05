using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Chain_Responsibility
{
    class Taskhandler3 : Handler
    {
        // End of chain
        public override void HandleRequest()
        {
            Console.Write("Taskhandler3: ");
            base.HandleRequest();
        }
    }
}
