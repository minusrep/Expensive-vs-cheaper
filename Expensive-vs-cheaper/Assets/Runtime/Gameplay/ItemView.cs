using UnityEngine.UIElements;

namespace DoubleB.Runtime.Gameplay
{
    public class ItemView
    {
        public VisualElement Root { get; private set; }
        
        public ItemView(VisualElement root)
        {
            Root = root;
        }
    }
}