using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameHub.Games.Skipbo.GameLogic
{
    internal class CardManager
    {
        List<SkipboCard> stockPile { get; set; }
        List<SkipboCard> drawPile { get; set; }
        List<SkipboCard> hand { get; set; }
        List<SkipboCard> firstDiscardPile { get; set; }
        List<SkipboCard> secondDiscardPile { get; set; }
        List<SkipboCard> thirdDiscardPile { get; set; }
        List<SkipboCard> fourthDiscardPile { get; set; }
        List<SkipboCard> firstBuildingPile { get; set; }
        List<SkipboCard> secondBuildingPile { get; set; }
        List<SkipboCard> thirdBuildingPile { get; set; }
        List<SkipboCard> fourthBuildingPile { get; set; }
    }
}
