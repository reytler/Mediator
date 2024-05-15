
namespace Mediator
{
    public interface FacebookGroupMediator
    {
        void SendMessage(string message, User user);

        void RegisterUser(User user);
    }
}
