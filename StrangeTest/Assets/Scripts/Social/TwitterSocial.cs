using UnityEngine;

public class TwitterSocial : ISocialNetwork
{

    public TwitterSocial() { Debug.Log("=> Twitter authorizer created."); }

    #region ISocialNetwork imp

    public SNType Type
    {
        get { return SNType.TW; }
    }

    public void Login()
    {
        Debug.Log("Log in twitter!");
    }

    #endregion

}