namespace RabbitMqApp.Business
{
    public interface IRabbitMqOperation
    {
        bool SendMessageToQueue(string message);
        string GetMessage();
    }
}
