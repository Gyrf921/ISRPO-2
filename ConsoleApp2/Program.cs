using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите напиток: чай или кофе? (по умолч. кофе) ");
            string cupOf = Console.ReadLine();

            int _forParse;
            if (cupOf == "кофе" || cupOf == "" || cupOf == null) {
                CupOfCoffee cupOfObj = new CupOfCoffee();


                Console.WriteLine("Выберите тип зёрен: арабика или робуста? (по умолч. арабика) - ");
                string _type = Console.ReadLine();
                if (_type == "арабика" || _type == "робуста")
                    (cupOfObj as ICup).Type = _type;
                else
                    (cupOfObj as ICup).Type = null;

                Console.WriteLine("Выберите количество сахара: от 0 до 5 (по умолч. 3) - ");
                int.TryParse(Console.ReadLine(), out _forParse);
                if (_forParse >= 0 && _forParse <= 5)
                {
                    cupOfObj.Sugar = _forParse.ToString();
                }
                else cupOfObj.Sugar = null;

                Console.WriteLine("Выберите количество молока: от 0 до 10 (по умолч. 5) - ");
                int.TryParse(Console.ReadLine(), out _forParse);
                if (_forParse >= 0 && _forParse <= 10)
                {
                    cupOfObj.Milk = _forParse.ToString();
                }
                else cupOfObj.Milk = null;

                Console.WriteLine("Объём: 0,2 или 0,3 (по умолч. 0,2) - ");
                string _value = Console.ReadLine();
                if (_value == "0,2" || _value == "0,3")
                    (cupOfObj as ICup).Capacity = _value;
                else
                    (cupOfObj as ICup).Capacity = null;


                ProcessCup(cupOfObj);
            }
            else
            {
                CupOfTea cupOfObj = new CupOfTea();


                Console.WriteLine("Выберите тип чая: зелёный или чёрный? (по умолч. зелёный) - ");
                string _type = Console.ReadLine();
                if (_type == "зелёный" || _type == "чёрный")
                    (cupOfObj as ICup).Type = _type;
                else
                    (cupOfObj as ICup).Type = null;


                Console.WriteLine("Выберите количество сахара: от 0 до 5 (по умолч. 3) - ");
                int.TryParse(Console.ReadLine(), out _forParse);
                if (_forParse >= 0 && _forParse <= 5)
                {
                    cupOfObj.Sugar = _forParse.ToString();
                }
                else cupOfObj.Sugar = null;

                Console.WriteLine("Выберите количество молока: от 0 до 10 (по умолч. 5) - ");
                int.TryParse(Console.ReadLine(), out _forParse);
                if (_forParse >= 0 && _forParse <= 10)
                {
                    cupOfObj.Milk = _forParse.ToString();
                }
                else cupOfObj.Milk = null;

                Console.WriteLine("Объём: 0,2 или 0,3 (по умолч. 0,2) - ");
                string _value = Console.ReadLine();
                if (_value == "0,2" || _value == "0,3")
                    (cupOfObj as ICup).Capacity = _value;
                else
                    (cupOfObj as ICup).Capacity = null;



                ProcessCup(cupOfObj);
            }


        }

        public static void ProcessCup(HotDrink _cupfc)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // устанавливаем цвет
            Console.WriteLine(_cupfc.AddSugar());
            Console.WriteLine(_cupfc.AddMilk());
            Console.WriteLine(_cupfc.Drink());
            Console.WriteLine("Объём стаканчика: " + (_cupfc as ICup).Capacity);
            Console.ResetColor(); // сбрасываем в стандартный

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine((_cupfc as ICup).Wash());
            Console.WriteLine((_cupfc as ICup).Refill());
            Console.ResetColor();

            Console.ReadKey();

        }

    }
}
