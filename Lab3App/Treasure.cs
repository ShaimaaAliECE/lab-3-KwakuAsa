using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Treasure : Collectable
    {
        public int Score {  get; set; }

      
        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
        }

        public override void AddMe(List<Collectable> list)
        {
            UpdateTotalScore();
            base.AddMe(list);
            
        }


     
    }
}
