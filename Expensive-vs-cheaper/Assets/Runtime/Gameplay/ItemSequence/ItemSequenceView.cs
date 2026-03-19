using UnityEngine.UIElements;

namespace DoubleB.Runtime.Gameplay
{
    public class ItemSequenceView
    {
        public VisualElement Root { get; private set; }

        public ItemSequenceView(VisualElement root)
        {
            Root = root;
        }
    }
}