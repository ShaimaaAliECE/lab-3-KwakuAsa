using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int Value {  get; set; }

        public Coin(string description, int score, int value)
        {
            Description = description;
            this.Value = value;
            this.Score = score;
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> list)
        {

            base.AddMe(list);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }
        
    }
}
