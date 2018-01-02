namespace SciBoard.Services
{
    public class HardcodedMessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hradcoded message from a service";
        }
    }
}
