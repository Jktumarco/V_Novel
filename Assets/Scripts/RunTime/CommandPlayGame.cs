using Naninovel;
using UnityEngine;


[CommandAlias("playGame")]
public class CommandPlayGame : Command
{
    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {     
        var game = Engine.GetService<MiniGamesManager>();     
        game.StartGame();
        //Debug.Log("play game");
        return UniTask.CompletedTask;
    }
}
