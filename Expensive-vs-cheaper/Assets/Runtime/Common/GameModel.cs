namespace DoubleB.Runtime
{
    public class GameModel
    {
        public UIRouterModel UIRouterModel { get; private set; }

        public GameModel(UIRouterModel uiRouterModel)
        {
            UIRouterModel = uiRouterModel;
        }
    }
}