using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

public class SignalContext : MVCSContext
{
    public SignalContext(MonoBehaviour contextView) : base(contextView, ContextStartupFlags.MANUAL_MAPPING)
    {
    }

    protected override void addCoreComponents()
    {
        base.addCoreComponents();

        injectionBinder.Unbind<ICommandBinder>();
        injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
    }

    public override void Launch()
    {
        base.Launch();

        var startSignal = injectionBinder.GetInstance<AppStartSignal>();

//      startSignal.AddListener(() => Debug.Log("Added listener!"));//  This will appear every time the signal is up
//      startSignal.AddOnce(() => Debug.Log("Added once!"));        //  This will appear only once

        startSignal.Dispatch();
    }

    protected override void mapBindings()
    {
        base.mapBindings();

//      implicitBinder.ScanForAnnotatedClasses(new string[] { "EFT" });
    }
}
