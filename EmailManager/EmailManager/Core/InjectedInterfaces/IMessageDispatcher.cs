namespace EmailManager
{
    //CR: Not so much to do for a Dispatcher. From my point of view, a dispatcher should also have subscribers.
    public interface IMessageDispatcher
    {
        void Send(Message message);
    }
}
