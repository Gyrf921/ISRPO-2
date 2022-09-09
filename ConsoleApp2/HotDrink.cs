using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class HotDrink
    {
        protected string sugar;
        protected string milk;

        public abstract string Sugar
        {
            get;
            set;
        }
        public abstract string Milk
        {
            get;
            set;
        }


        public abstract string Drink();
        public abstract string AddMilk();
        public abstract string AddSugar();
    }
}
