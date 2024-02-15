using Naninovel;
using Naninovel.Commands;
using Naninovel.UI;
using UnityEngine;

[CommandAlias("showItem")]
public class CommandShowItem : Command
{
    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var item = Engine.GetService<IUIManager>().GetUI<SceneItem>();
        item.gameObject.SetActive(true);
        return UniTask.CompletedTask;
    }

    //private async void PlayScriptAsync()
    //{
    //    var i = Engine.GetService<IScriptPlayer>();
    //    var item = Engine.GetService<ICustomVariableManager>().GetVariableValue("step");
    //    i.SetAutoPlayEnabled(false);
    //    await i.PreloadAndPlayAsync(item);


    //}
}