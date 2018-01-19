using strange.extensions.command.impl;
using System.Collections;
using UnityEngine;

public class ShowLoadingCommand : Command
{
    public override void Execute()
    {
        Debug.Log("Show Loading");
    }
}
