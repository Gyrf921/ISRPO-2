using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CupOfCoffee : HotDrink, ICup
    {
        public string BeanType { get; set; }
        string ICup.Type
        {
            get => BeanType;
            set
            {
                if (value != null && value != "")
                {
                    BeanType = value;
                }
                else
                {
                    BeanType = "арабика";
                }
            }
        }


        public string Capacity { get; set; }

        string ICup.Capacity
        {
            get => Capacity;
            set
            {
                if (value != null && value != "")
                {

                    Capacity = value;
                }
                else
                {
                    Capacity = "0,2";
                }
     
            }
        }

        
        public override string Sugar
        {
            get => sugar;
            set {
                if (value != null && value != "0")
                {
                    sugar = value;
                }
                else
                    sugar = "3";
            }
        }
        public override string Milk
        {
            get => milk;
            set { if (value != null && value != "0") { milk = value; } else milk = "5"; }
            
        }


        public override string Drink()
        {
            return "Получите кофе: " + BeanType;
        }
        public override string AddMilk()
        {
            return "В кофе добавлено молоко: " + Milk;
        }
        public override string AddSugar()
        {
            return "В кофе добавлен сахар: " + Sugar;

        }
        public string Refill()
        {
            return $"Повторите этот {Capacity} кофе, пожалуйста";
        }
        public string Wash()
        {
            return "Помыть чашку из под кофе";
        }

    }
}
