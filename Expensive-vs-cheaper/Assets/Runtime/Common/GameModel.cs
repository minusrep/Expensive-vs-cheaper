using DoubleB.Runtime.Gameplay;

namespace DoubleB.Runtime
{
    public class GameModel
    {
        public GameplayModel GameplayModel { get; set; }
        public UIRouterModel UIRouterModel { get; private set; }

        public GameModel(UIRouterModel uiRouterModel)
        {
            UIRouterModel = uiRouterModel;
        }
    }
}