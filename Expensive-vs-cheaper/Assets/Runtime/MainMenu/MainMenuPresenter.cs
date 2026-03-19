using UnityEngine.UIElements;

namespace DoubleB.Runtime
{
    public class MainMenuPresenter : IPresenter
    {
        private readonly MainMenuView _view;

        private readonly GameModel _model;
        
        public MainMenuPresenter(MainMenuView view, GameModel model)
        {
            _view = view;
            _model = model;
        }

        public void Enable()
        {
            _view.Root.Q<Button>(UIConstants.StartButton).clicked += StartSession;
        }

        public void Disable()
        {
            _view.Root.Q<Button>(UIConstants.StartButton).clicked -= StartSession;
        }

        private void StartSession()
        {
            _model.UIRouterModel.ChangeState(UIConstants.Gameplay);
        }
    }
}