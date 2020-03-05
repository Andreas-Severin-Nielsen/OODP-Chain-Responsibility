using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Chain_Responsibility
{
    abstract class Handler
    {
        private Handler successor;

        public Handler() { }

        public Handler(Handler successor)
        {
            this.successor = successor;
        }

        public virtual void HandleRequest()
        {
            // checking if this taskhandler can handle the request...
            if(CanHandleRequest())
            {
                // This taskhandler can handle the request.
                PerformRequest();
            }
            else
            {
                // This taskhandler is not able to handle the request...
                // Check if request can be forwarded to to successor
                if (successor != null)
                {
                    Console.WriteLine("Passing task along to successor...");
                    successor.HandleRequest();
                }
                // no successor - this taskhandler needs to handle request anyway
                else PerformRequest();
            }
            
            
        }

        protected virtual void PerformRequest()
        {
            Console.WriteLine("Performing the request");
        }

        public virtual bool CanHandleRequest()
        {
            // checking conditions at runtime for ability to handle request
            return false;
        }

    }
}
