using System;

namespace HW2_4
{
    //Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
    //только за место динамических, по вашему мнению, данных(это может быть дата, название магазина, сумма покупок) подставляйте переменные, 
    //которые были заранее заготовлены до вывода на консоль.
    class Program
    {
        static void Main(string[] args)
        {
            string kassir = "Кассир 1";
            string sellItem = "Курица";
            double sellPrice=194.98;
            double sellWeigth = 0.892;
            double price = sellWeigth * sellPrice;
            string sellCount = $"{sellWeigth} * {sellPrice} = {price}";
            int sellNumber = 50;
            int smena = 10;
            DateTime date = new DateTime();
            date = DateTime.Now;

            Console.WriteLine("|{0,48}|", kassir);
            Console.WriteLine("|Продажа {0,19} Смена {1,14}|",sellNumber, smena);
            Console.WriteLine("|{0,48}|",date);
            Console.WriteLine("|{0}{1,"+(48-sellItem.Length)+"}|",sellItem,' ');
            Console.WriteLine("|{0}{1,"+(48-sellCount.Length)+"}|",sellCount,' ');
            Console.WriteLine("|Итого{0,"+(42-price.ToString().Length)+"}={1}|",' ', price);
        }
    }
}
