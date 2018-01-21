public enum SNType
{
    VK,
    TW
}

public interface ISocialNetwork
{
    SNType Type { get; }

    void Login();
}
