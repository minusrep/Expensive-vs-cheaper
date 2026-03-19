using UnityEngine;

namespace DoubleB.Runtime.Gameplay
{
    public class GameplayModel
    {
        public ItemSequenceModel ItemSequence { get; set; }
        public GameplayModel(ItemSequenceModel itemSequence)
        {
            ItemSequence = itemSequence;
        }
    }
}