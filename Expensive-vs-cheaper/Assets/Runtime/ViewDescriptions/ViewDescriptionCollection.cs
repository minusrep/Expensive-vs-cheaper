using System.Collections.Generic;
using UnityEngine;

namespace DoubleB.Runtime.Runtime.ViewDescriptions
{
    public class ViewDescriptionCollection<TDescription, TElement> : ScriptableObject where TDescription : ViewDescription<TElement>
    {
        [field: SerializeField] private List<TDescription> _viewDescriptions;

        public TDescription Get(string id)
        {
            foreach (var viewDescription in _viewDescriptions)
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