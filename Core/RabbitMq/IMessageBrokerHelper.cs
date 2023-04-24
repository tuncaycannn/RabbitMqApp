namespace Core.RabbitMq
{
    public interface IMessageBrokerHelper
    {
        void QueueMessage(string messageText);
    }
}