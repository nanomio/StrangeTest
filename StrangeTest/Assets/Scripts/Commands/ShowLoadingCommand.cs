using strange.extensions.command.impl;
using System.Collections;
using UnityEngine;

public class ShowLoadingCommand : Command
{
    [Inject]
    public IExecuter executer { get; private set; }
    
    public override void Execute()
    {
        Debug.Log("Show Loading");
    }
}
