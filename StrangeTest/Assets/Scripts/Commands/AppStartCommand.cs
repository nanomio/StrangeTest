using strange.extensions.command.impl;
using System.Collections;
using UnityEngine;

public class AppStartCommand : Command
{
    [Inject]
    public IExecuter Executer { get; private set; }

    [Inject]
    public ChanheCoinsBalanceSignal changeCoinsBalanceSignal { get; private set; }

    [Inject]
    public CoinsBalanceChangedSignal coinsBalanceChangedSignal { get; private set; }

    [Inject]
    public SocialLoginSignal socialLoginSignal { get; private set; }

    public override void Execute()
    {
        Retain();                   // This method shows that execution will take some time, important for commandBinder.Bind<>().InSequence()...

        Debug.Log("Fuck Yeee!");

        coinsBalanceChangedSignal.AddListener(OnBalanceChange);

        Executer.Execute(WaitAndGo());
    }

    public IEnumerator WaitAndGo()
    {
        yield return new WaitForSeconds(2f);

        Debug.Log("Ok, go next!");

        changeCoinsBalanceSignal.Dispatch(+10);
        changeCoinsBalanceSignal.Dispatch(-50);

        socialLoginSignal.Dispatch(SNType.TW);
        socialLoginSignal.Dispatch(SNType.VK);

        Release();                  // Used it after "Retain" method

//      Fail();                     //<-- After this method no commands will execute!
    }

    public void OnBalanceChange(int balance)
    {
        Debug.Log("Current balance: " + balance);
    }
}
