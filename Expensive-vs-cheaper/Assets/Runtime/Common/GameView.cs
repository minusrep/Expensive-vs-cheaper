using UnityEngine.UIElements;

namespace DoubleB.Runtime
{
    public class GameView
    {
        public VisualElement Root => _uiDocument.rootVisualElement;

        private readonly UIDocument _uiDocument;

        public GameView(UIDocument uiDocument)
        {
            _uiDocument = uiDocument;
        }
    }
}