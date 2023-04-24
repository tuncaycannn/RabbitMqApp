using Core.RabbitMq;

namespace RabbitMqApp.Business
{
    public class RabbitMqOperation : IRabbitMqOperation
    {
        private readonly IMessageBrokerHelper _messageBrokerHelper;
        private readonly IMessageConsumer _messageConsumer;
        public RabbitMqOperation(IMessageBrokerHelper messageBrokerHelper, IMessageConsumer messageConsumer)
        {
            _messageBrokerHelper = messageBrokerHelper;
            _messageConsumer = messageConsumer;
        }

        public bool SendMessageToQueue(string message)
        {
            bool retVal = true;
            _messageBrokerHelper.QueueMessage(message);

            return retVal;
        }

        public string GetMessage()
        {
            string retVal = string.Empty;
            retVal = _messageConsumer.GetQueue();

            return retVal;
        }
    }
}
