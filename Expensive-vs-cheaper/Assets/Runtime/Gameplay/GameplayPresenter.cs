using DoubleB.Runtime.Runtime.Descriptions;
using DoubleB.Runtime.Runtime.ViewDescriptions;
using UnityEngine.UIElements;

namespace DoubleB.Runtime.Gameplay
{
    public class GameplayPresenter : IPresenter
    {
        private readonly ItemDescriptionCollection _itemDescriptions;
        private readonly UIAssetCollection _uiAssetCollection;
        private readonly GameplayView _view;
        private GameplayModel _model;

        private ItemSequencePresenter _itemSequencePresenter;

        public GameplayPresenter(GameplayModel model, GameplayView view, ItemDescriptionCollection itemDescriptions, UIAssetCollection uiAssetCollection)
        {
            _model = model;
            _view = view;
            _itemDescriptions = itemDescriptions;
            _uiAssetCollection = uiAssetCollection;
        }

        public void Enable()
        {
            var itemSequence = new ItemSequenceModel(_itemDescriptions.GetRandom(), _itemDescriptions.GetRandom());
            _model = new GameplayModel(itemSequence);

            var itemSequenceView = new ItemSequenceView(_view.Root.Q<VisualElement>(UIConstants.Content));
            _itemSequencePresenter = new ItemSequencePresenter(_model.ItemSequence, itemSequenceView, _uiAssetCollection);
            _itemSequencePresenter.Enable();
            
            _view.MoreExpensiveButton.clicked += SelectMoreExpensive;
            _view.CheaperButton.clicked += SelectCheaper;
        }

        public void Disable()
        {
            _view.MoreExpensiveButton.clicked -= SelectMoreExpensive;
            _view.CheaperButton.clicked -= SelectCheaper;
        }

        private void SelectMoreExpensive()
        {
            var success = _model.ItemSequence.CurrentItem.Worth <= _model.ItemSequence.NextItem.Worth;

            if (success)
            {
                _model.ItemSequence.Next(_itemDescriptions.GetRandom());
            }
        }

        private void SelectCheaper()
        {
            var success = _model.ItemSequence.CurrentItem.Worth >= _model.ItemSequence.NextItem.Worth;

            if (success)
            {
                _model.ItemSequence.Next(_itemDescriptions.GetRandom());
            }
        }
    }
}