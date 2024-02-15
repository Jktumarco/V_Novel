using DTT.MinigameMemory;
using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Naninovel
{  
    [EditInProjectSettings]
    public class MiniGameConfiguration : Configuration
    {
        [SerializeField] MemoryGameManager _memoryGameManager;
        [SerializeField] Canvas _canvas;
        //[SerializeField] PlayScript _playScript;
        [SerializeField] MemoryGameSettings _memoryGameSettings;
        [SerializeField] GameObject prefMemory;
        public const string DefaultPathPrefix = "MiniGame";


        [Tooltip("Configuration of the resource loader used with inventory resources.")]
        public ResourceLoaderConfiguration Loader = new ResourceLoaderConfiguration { PathPrefix = DefaultPathPrefix };
        public GameObject GetPref()
        {
            return prefMemory;
        }
        public MemoryGameManager GetManager()
        {
            return _memoryGameManager;
        }
        public Canvas GetCanvas()
        {
            return _canvas;
        }
        public MemoryGameSettings GetSetting()
        {
            return _memoryGameSettings;
        }
    }
}
