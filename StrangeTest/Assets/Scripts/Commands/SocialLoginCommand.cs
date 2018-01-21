using strange.extensions.command.impl;
using UnityEngine;

public class SocialLoginCommand : Command
{
    [Inject]
    public SNType Type { get; private set; }


    public override void Execute()
    {
        var social = injectionBinder.GetInstance<ISocialNetwork>(Type);

        social.Login();
    }
}
