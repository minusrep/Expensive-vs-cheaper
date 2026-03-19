using System.Collections.Generic;
using UnityEngine;

namespace DoubleB.Runtime.Runtime.ViewDescriptions
{
    public class ViewDescriptionCollection<TDescription, TElement> : ScriptableObject where TDescription : ViewDescription<TElement> 
    {
        [field: SerializeField] public List<TDescription> ViewDescriptions { get; private set; }

        public TDescription Get(string id)
        {
            foreach (var viewDescription in ViewDescriptions)
            {
                if (viewDescription.Id == id)
                {
                    return  viewDescription;
                }
            }

            throw new KeyNotFoundException($"ViewDescription with id {id} not found");
        }
    }
}