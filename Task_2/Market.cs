using Abstraction_Interfaces.Task_1;

namespace Abstraction_Interfaces.Task_2
{
    internal class Market : IQueueBehavior, IMarketBehavior
    {
        private Queue<Actor> peoples = new Queue <Actor> ();

        #region IQueueBehavior

        public void AcceptToMarket(Actor actor)
        {
            Console.WriteLine($"{actor.GetName()} зашел в магазин");

            TakeInQueue (actor);
        }

        public void ReleaseFromMarket(Queue<Actor> actors)
        {
            while (actors.Count > 0)
            { 
                actors.Dequeue ();
            }
        } 

        public void Update()
        {
            TakeOrders();
            GiveOrders();
            LeavesTheStore();
        }

        #endregion

        #region IMarketBehavior    

        public void LeavesTheStore()
        {
            Queue<Actor> leavesQueue = new Queue<Actor>();
            foreach (Actor actor in peoples) 
            {
                if (actor.IsPickUpOrder())
                {         
                    leavesQueue.Enqueue (actor);
                    Console.WriteLine($"{actor.GetName()} идет к выходу");
                }
            }
            ReleaseFromMarket(leavesQueue);
        }
        public void TakeInQueue(Actor actor)
        {

            peoples.Enqueue (actor);
            Console.WriteLine($"{actor.GetName()} встал в очередь");
        }

        public void TakeOrders()
        {
            foreach (Actor actor in peoples) 
            {
                if (!actor.IsMakeOrder()) 
                {
                    actor.IsOrderMade = true;
                    Console.WriteLine($"{actor.GetName()} сделал заказ");
                }
            }      
        }

        public void GiveOrders()
        {
            foreach (Actor actor in peoples)
            {
                if (actor.IsMakeOrder())
                {
                    actor.IsOrderPickedUp = true;
                    actor.IsOrderMade = false;
                    Console.WriteLine($"{actor.GetName()} получил заказ");
                }
            }
        }

        #endregion
    }
}
