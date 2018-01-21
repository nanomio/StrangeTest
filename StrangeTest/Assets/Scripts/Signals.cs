using strange.extensions.signal.impl;

public class AppStartSignal : Signal { }
public class ChanheCoinsBalanceSignal : Signal<int> { }             //  Signal with parameter sample, marking that "coin balance" is changing
public class CoinsBalanceChangedSignal : Signal<int> { }            //  This one signals that balance is already changed
public class SocialLoginSignal : Signal<SNType> { }