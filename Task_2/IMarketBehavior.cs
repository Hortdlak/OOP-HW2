using Abstraction_Interfaces.Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interfaces.Task_2
{
    internal interface IMarketBehavior
    {
        void TakeInQueue(Actor actor);
        void TakeOrders();
        void GiveOrders();
        void LeavesTheStore();
    }
}
