using strange.extensions.command.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCoinsBalanceCommand : Command
{
    [Inject]
    public MainModel Model { get; private set; }

    [Inject]
    public CoinsBalanceChangedSignal CoinsBalanceChangedSignal { get; private set; }

    [Inject]
    public int Amount { get; private set; }

    public override void Execute()
    {
        if (Model.Coins + Amount <= 0)
        {
            Model.Coins = 0;
        }
        else
        {
            Model.Coins += Amount;
        }

        CoinsBalanceChangedSignal.Dispatch(Model.Coins);
    }
}
