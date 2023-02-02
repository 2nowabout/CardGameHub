using CardGameHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameHub.Games.Skipbo.GameLogic
{
    internal class SkipboCard
    {
        public SkipboCard(int id, Position position, int number)
        {
            this.id = id;
            this.position = position;
            this.number = number;
        }

        public int id { get; private set; }
        public Position position { get; private set; }
        public int number { get; private set; }
    }

}
