using System;
using strange.extensions.command.impl;
using UnityEngine;

public class MainContext : SignalContext
{
    public MainContext(MonoBehaviour view) : base(view)
    {

    }

    protected override void mapBindings()
    {
        base.mapBindings();

        injectionBinder.Bind<MainModel>().ToSingleton();
        injectionBinder.Bind<IExecuter>().To<CoroutineExecuter>().ToSingleton();
        injectionBinder.Bind<ISocialNetwork>().To<TwitterSocial>().ToName(SNType.TW);
        injectionBinder.Bind<ISocialNetwork>().To<VkSocial>().ToName(SNType.VK).ToSingleton();

        commandBinder.Bind<AppStartSignal>().InSequence().To<ShowLoadingCommand>().To<AppStartCommand>().To<HideLoadingCommand>().Once();
        commandBinder.Bind<ChanheCoinsBalanceSignal>().To<ChangeCoinsBalanceCommand>();
        commandBinder.Bind<CoinsBalanceChangedSignal>();
        commandBinder.Bind<SocialLoginSignal>().To<SocialLoginCommand>();
    }
}