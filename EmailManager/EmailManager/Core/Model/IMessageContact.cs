namespace EmailManager
{
    //CR: This is used only to access the Email. You can replaced with the email address in BaseMessageGenerator
    public interface IMessageContact
    {
        string InboxAddress { get; }
    }
}
