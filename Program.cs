using Abstraction_Interfaces.Task_1;
using Abstraction_Interfaces.Task_2;

namespace Abstraction_Interfaces
{
    internal class Program
    {
        static void Main()
        {
            Market market = new Market();
            Person human1 = new Person ("Ivan");
            Person human2 = new Person("Vladimir");
            market.AcceptToMarket(human1);
            market.AcceptToMarket(human2);
            market.Update();
        }
    }
}
