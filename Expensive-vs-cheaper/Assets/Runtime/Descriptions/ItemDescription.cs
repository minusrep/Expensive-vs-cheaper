using UnityEngine;

namespace DoubleB.Runtime.Runtime.Descriptions
{
    [CreateAssetMenu(fileName = "Item", menuName = "Description/Item")]
    public class ItemDescription : ScriptableObject
    {
        public string Id;
        public ulong Worth;
        public Color Color;
    }
}