namespace Core.RabbitMq
{
    public interface IMessageConsumer
    {
        string GetQueue();
    }

}