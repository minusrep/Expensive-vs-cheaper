using UnityEngine;

namespace DoubleB.Runtime.Runtime.ViewDescriptions
{
    public abstract class ViewDescription<T> : ScriptableObject
    {
        public string Id;
        public T Value;
    }
}