using System;

namespace Abstraction_Interfaces.Task_1
{
    internal interface IActorBehavior
    {
        void MakeOrder(bool makeOrder);
        void PickUpOrder(bool pickUpOrder);

        bool IsMakeOrder();
        bool IsPickUpOrder();
    }
}
