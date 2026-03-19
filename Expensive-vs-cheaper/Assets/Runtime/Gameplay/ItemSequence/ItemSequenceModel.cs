using System;
using DoubleB.Runtime.Runtime.Descriptions;

namespace DoubleB.Runtime.Gameplay
{
    public class ItemSequenceModel
    {
        public event Action OnChange;

        public ItemDescription CompleteItem { get; private set; }

        public ItemDescription CurrentItem { get; private set; }

        public ItemDescription NextItem { get; private set; }

        public ItemSequenceModel(ItemDescription currentItem, ItemDescription nextItem)
        {
            CurrentItem = currentItem;
            NextItem = nextItem;
        }


        public void Next(ItemDescription nextItem)
        {
            CompleteItem = CurrentItem;
            CurrentItem = NextItem;
            NextItem = nextItem;
            OnChange?.Invoke();
        }
    }
}