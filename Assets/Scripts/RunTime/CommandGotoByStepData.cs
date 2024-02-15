using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Naninovel.Command;

[CommandAlias("gotoByStepData")]
public class CommandGotoByRoom2 : Command
{
    [ParameterAlias(NamelessParameterAlias), RequiredParameter]
    public StringParameter Message;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        PlayScriptAsync();
        return UniTask.CompletedTask;
    }
    private async void PlayScriptAsync()
    {
        var i = Engine.GetService<IScriptPlayer>();
        var item = Engine.GetService<ICustomVariableManager>().GetVariableValue(Message);
        i.SetAutoPlayEnabled(false);
        await i.PreloadAndPlayAsync(item);


    }
}
