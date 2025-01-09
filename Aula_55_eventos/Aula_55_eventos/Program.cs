using System;

namespace Aula_55_eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eventos - Maneira de trocar informações entre obj de classes
            //Possibilitam um obj avisar outros objetos quando algo acontece
            //Ver classes criadas

            Kitchen kitchenBurger = new Kitchen();
            Kitchen kitchenJapaneseFood = new Kitchen();

            WaitersTablet johnsTablet = new WaitersTablet("John", kitchenBurger);
            WaitersTablet alinesTablet = new WaitersTablet("Aline", kitchenBurger);

            WaitersTablet chensTablet = new WaitersTablet("Chen", kitchenJapaneseFood);
            WaitersTablet samsTablet = new WaitersTablet("Sam", kitchenJapaneseFood);

            //Vai enviar msg para todos os garçons
            kitchenBurger.SendMessageOrderReady(12);
            kitchenJapaneseFood.SendMessageOrderReady(29);
        }
    }
}