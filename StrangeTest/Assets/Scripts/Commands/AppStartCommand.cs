using strange.extensions.command.impl;
using System.Collections;
using UnityEngine;

public class AppStartCommand : Command
{
    [Inject]
    public IExecuter Executer { get; private set; }

    public override void Execute()
    {
        Retain();                   // This method shows that execution will take some time, important for commandBinder.Bind<>().InSequence()...

        Debug.Log("Fuck Yeee!");

        Executer.Execute(WaitAndGo());
    }

    public IEnumerator WaitAndGo()
    {
        yield return new WaitForSeconds(2f);

        Debug.Log("Ok, go next!");

        Release();                  // Need to use it after "Retain" method

//      Fail();                     //<-- After this method no commands will execute!
    }
}
