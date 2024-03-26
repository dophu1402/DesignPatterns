using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StatePattern
{
    class SubmittedState : State
    {
        public override void HandleChangeStatusToApproved()
        {
            this._context.TransitionTo(new ApprovedState());
            Console.WriteLine("> Status changed to Approved\n");
        }
    }   
}
