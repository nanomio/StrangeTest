using strange.extensions.command.impl;
using System.Collections;
using UnityEngine;

public class HideLoadingCommand : Command
{
    public override void Execute()
    {
        Debug.Log("Hide Loading");
    }
}