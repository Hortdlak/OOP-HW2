using Abstraction_Interfaces.Task_1;
using System;


namespace Abstraction_Interfaces.Task_2
{
    internal interface IQueueBehavior
    {
        void AcceptToMarket(Actor actor);

        void ReleaseFromMarket(Queue <Actor> actors);

        void Update();
    }
}
