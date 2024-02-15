using DTT.MinigameMemory;
using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour
{
    [SerializeField] MemoryGameManager  _memoryGameManager;
    [SerializeField] Transform          _back;
    [SerializeField] PlayScript         _playScript;
    [SerializeField] MemoryGameSettings _memoryGameSettings;

    public MemoryGameManager GetManager()
    {
        return _memoryGameManager;
    }
    public Transform GetBack()
    {
        return _back;
    }
    public MemoryGameSettings GetSetting()
    {
        return _memoryGameSettings;
    }
    public PlayScript GetPlayScript()
    {
        return _playScript;
    }
}
