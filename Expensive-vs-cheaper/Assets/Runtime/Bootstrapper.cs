using DoubleB.Runtime.Runtime.ViewDescriptions;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

namespace DoubleB.Runtime
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private UIDocument _uiDocument;
        [FormerlySerializedAs("visualTreeAssetCollection")] [FormerlySerializedAs("_visualTreeAssetViewDescriptionCollection")] [SerializeField] private UIAssetCollection uiAssetCollection;
        
        
        private void Start()
        {
            var uiRouterModel = new UIRouterModel(UIConstants.MainMenu);
            var gameModel = new GameModel(uiRouterModel);
            var gameView = new GameView(_uiDocument);
            var uiRouter = new UIRouterPresenter(gameModel, gameView, uiAssetCollection);
            uiRouter.Enable();
        }
    }
}
