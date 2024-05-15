namespace Mediator;

class Program
{
    static void Main(string[] args)
    {
        FacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();

        User reytler = new ConcreteUser(facebookMediator, "Reytler");
        User iarla = new ConcreteUser(facebookMediator, "Iarla");
        User renato = new ConcreteUser(facebookMediator, "Renato");
        User kessia = new ConcreteUser(facebookMediator, "Késsia");
        User victorHugo = new ConcreteUser(facebookMediator, "Victor Hugo");
        User kelita = new ConcreteUser(facebookMediator, "Kélita");

        facebookMediator.RegisterUser(reytler);
        facebookMediator.RegisterUser(iarla);
        facebookMediator.RegisterUser(renato);
        facebookMediator.RegisterUser(kessia);
        facebookMediator.RegisterUser(kelita);
        facebookMediator.RegisterUser(victorHugo);

        reytler.Send("Hellow cambada!!!");
        iarla.Send("E ai meu povo");
        renato.Send("Roinc!!!!");
        kessia.Send("Ridículo");
        victorHugo.Send("Duuuu, du hast!");
        kelita.Send("Que isso menino!!!!????");

        Console.Read();
    }
}