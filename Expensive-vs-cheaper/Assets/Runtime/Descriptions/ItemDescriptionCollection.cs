using System.Collections.Generic;
using UnityEngine;

namespace DoubleB.Runtime.Runtime.Descriptions
{
    [CreateAssetMenu(fileName = "ItemCollection", menuName = "DescriptionCollection/ItemCollection")]
    public class ItemDescriptionCollection : ScriptableObject
    {
        [field: SerializeField] private List<ItemDescription> _itemDescriptions;

        public ItemDescription GetRandom()
        {
            return _itemDescriptions[Random.Range(0, _itemDescriptions.Count)];
        }
    }
}