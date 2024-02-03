using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set;}

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(Description + " Collected, Congrats!!!!");
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }
        public virtual void Display() { Console.WriteLine(Description + " is displayed"); }
    }
}
