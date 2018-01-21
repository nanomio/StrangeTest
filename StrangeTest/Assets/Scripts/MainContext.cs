﻿using System;
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

        injectionBinder.Bind<IExecuter>().To<CoroutineExecuter>().ToSingleton();

        commandBinder.Bind<AppStartSignal>().InSequence().To<ShowLoadingCommand>().To<AppStartCommand>().To<HideLoadingCommand>().Once();
    }
}