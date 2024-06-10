using System;


namespace Abstraction_Interfaces.Task_1
{

    internal class Person : Actor
    {
        public Person(string name, bool isOrderMade = false, bool isOrderPickedUp = false)
        {
            Name = name;
            IsOrderMade = isOrderMade;
            IsOrderPickedUp = isOrderPickedUp;
        }

        public override void MakeOrder(bool makeOrder)
        {
            IsOrderMade = makeOrder;
        }

        public override void PickUpOrder(bool pickUpOrder)
        {
            IsOrderPickedUp = pickUpOrder;
        }
        public override bool IsMakeOrder()
        {
            return this.IsOrderMade;
        }

        public override bool IsPickUpOrder()
        {
            return IsOrderPickedUp;
        }

        public bool HasMadeOrder()
        {
            return IsOrderMade;
        }

        public bool HasPickedUpOrder()
        {
            return IsOrderPickedUp;
        }

        
    }
}
