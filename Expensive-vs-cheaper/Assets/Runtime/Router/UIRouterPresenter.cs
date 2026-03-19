using DoubleB.Runtime.Runtime.ViewDescriptions;
using UnityEngine.UIElements;

namespace DoubleB.Runtime
{
    public class UIRouterPresenter : IPresenter
    {
        private readonly UIAssetCollection _uiAssetCollection;
        private readonly GameView _view;
        private readonly GameModel _model;

        private IPresenter _currentPresenter;
        
        public UIRouterPresenter(GameModel model, GameView view, 
            UIAssetCollection uiAssetCollection)
        {
            _model = model;
            _view = view;
            _uiAssetCollection = uiAssetCollection;
        }

        public void Enable()
        {
            Build();
            
            _model.UIRouterModel.OnChangeState += Build;
        }

        public void Disable()
        {
            _model.UIRouterModel.OnChangeState -= Build;
        }

        private void Build()
        {
            _currentPresenter?.Disable();
            
            var asset = _uiAssetCollection.Get(_model.UIRouterModel.CurrentState).Value;
            var root = asset.CloneTree().Q<VisualElement>(UIConstants.Root);
            
            _view.Root.Clear();
            _view.Root.Add(root);

            switch (_model.UIRouterModel.CurrentState)
            {
                case UIConstants.MainMenu:
                    var view = new MainMenuView(root);
                    _currentPresenter = new MainMenuPresenter(view, _model);
                    _currentPresenter = new MainMenuPresenter(view, _model);
                    break;
            }
            
            _currentPresenter?.Enable();
        }
    }
}