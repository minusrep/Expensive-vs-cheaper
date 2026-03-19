using System;

namespace DoubleB.Runtime
{
    public class UIRouterModel
    {
        public event Action OnChangeState;
        
        public string CurrentState { get; private set; }
        
        public string PreviousState { get; private set; }

        public UIRouterModel(string currentState)
        {
            CurrentState = currentState;
        }

        public void ChangeState(string newState)
        {
            PreviousState = CurrentState;
            CurrentState = newState;
            OnChangeState?.Invoke();
        }
    }
}