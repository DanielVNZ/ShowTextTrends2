using Colossal.IO.AssetDatabase;
using Colossal.Logging;
using Colossal.UI.Binding;
using Game;
using Game.Modding;
using Game.SceneFlow;
using System;




namespace ShowTextTrends2
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger($"{nameof(ShowTextTrends2)}.{nameof(Mod)}").SetShowsErrorsInUI(false);
        public static string Id = nameof(ShowTextTrends2);
        public void OnLoad(UpdateSystem updateSystem)
        {
            log.Info(nameof(OnLoad));


            if (GameManager.instance.modManager.TryGetExecutableAsset(this, out var asset))
                log.Info($"Current mod asset at {asset.path}");

        }

        public void OnDispose()
        {
            log.Info(nameof(OnDispose));

        }


    }

}
