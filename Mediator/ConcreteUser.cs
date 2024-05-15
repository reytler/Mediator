namespace Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name) : base(mediator, name) { }

        public override void Receive(string message)
        {
            Console.WriteLine($"{name} : recebida <= {message}");
        }

        public override void Send(string message)
        {
            Console.Write($"{name} : enviada => {message}\n");
            mediator.SendMessage(message, this);
        }
    }
}
