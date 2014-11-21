namespace EmailManager
{
    public interface IMessageDispatcher
    {
        void Send(Message message);
    }
}
