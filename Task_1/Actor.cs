using System;


namespace Abstraction_Interfaces.Task_1
{
    internal abstract class Actor : IActorBehavior
    {
        protected string? Name { get; set; }

        public bool IsOrderMade { get; set; }

        public bool IsOrderPickedUp { get; set; }

        public abstract void MakeOrder(bool makeOrder);

        public abstract void PickUpOrder(bool pickUpOrder);

        public abstract bool IsMakeOrder();

        public abstract bool IsPickUpOrder();
        public string GetName()
        {
            return Name;
        }

    }
}
