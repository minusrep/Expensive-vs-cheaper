using System.Collections.Generic;
using UnityEngine;

namespace DoubleB.Runtime.Runtime.ViewDescriptions
{
    public class ViewDescriptionCollection<T, U> where T : ViewDescription<U>
    {
        [field: SerializeField] public List<ViewDescription<U>> ViewDescriptions { get; private set; }

        public ViewDescription<U> Get(string id)
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