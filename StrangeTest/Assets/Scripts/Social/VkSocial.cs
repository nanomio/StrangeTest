using UnityEngine;

public class VkSocial : ISocialNetwork
{

    public VkSocial() { Debug.Log("=>> Vk authorizer created."); }

    #region ISocialNetwork imp

    public SNType Type
    {
        get { return SNType.VK; }
    }

    public void Login()
    {
        Debug.Log("Log in Vkontakte...");
    }

    #endregion

}
