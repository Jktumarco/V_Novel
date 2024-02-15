using DTT.MinigameMemory;
using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Naninovel
{
    [InitializeAtRuntime]
    public class MiniGamesManager : IEngineService<MiniGameConfiguration>
    {
        MemoryGameManager                   _memoryGameManager;
        IResourceProviderManager            _providersManager;
        [SerializeField] GameObject             _canvas;
        [SerializeField] PlayScript         _playScript;
        [SerializeField] MemoryGameSettings _memoryGameSettings;

        public MiniGameConfiguration Configuration { get; }

        public MiniGamesManager(IResourceProviderManager providersManager, MiniGameConfiguration miniGameConfiguration ) {           
            Configuration = miniGameConfiguration;          
        }

        
        public void DestroyService()
        {
            _memoryGameManager.Finish -= OnFinish;
        }

    

        public virtual void ResetService()
        {
            
        }     
        public UniTask StartGame()
        {
            _memoryGameManager.Finish += OnFinish;
            _memoryGameManager.StartGame(_memoryGameSettings);
            return UniTask.CompletedTask;
        }
        private async void OnFinish(MemoryGameResults results)
        {
            _memoryGameManager.Finish -= OnFinish;
            await UniTask.Run(() => { _memoryGameManager.ForceFinish(); });            
            await UniTask.Delay(1000);
            _memoryGameManager.gameObject.SetActive(false);
            _playScript.Play();         
            Debug.Log("onFinishGame");
            //var player = Engine.GetService<IScriptPlayer>();
            //player.SetAutoPlayEnabled(true);
            //player.SetWaitingForInputEnabled(false);
            //await player.PreloadAndPlayAsync("Room2");
            
        }

        public UniTask InitializeServiceAsync()
        {

            var obj = Object.Instantiate(Configuration.GetPref());
            var config = obj.GetComponent<Config>();
            _memoryGameManager = config.GetManager();
            _memoryGameSettings = config.GetSetting();
            _playScript = config.GetPlayScript();
            return UniTask.CompletedTask;
        }
    }
}
