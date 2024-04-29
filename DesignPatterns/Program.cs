using DesignPatterns.Creational;
using DesignPatterns.Fixtures;
using DesignPatterns.Models;

const int WaitInSeconds = 1 * 1000;

Dictionary<DesignPattern, Action> PatternExamples = new()
{
    { DesignPattern.Singleton, SingletonExample },

    { DesignPattern.AbstractFactory, AbstractFactoryExample },

    { DesignPattern.FactoryMethod, FactoryMethodExample },

    { DesignPattern.Builder, BuilderExample },

    { DesignPattern.Prototype, PrototypeExample },
};

string command = Environment.GetCommandLineArgs()[1];
if (Enum.TryParse(command, out DesignPattern designPattern) && Enum.IsDefined(designPattern))
    PatternExamples[designPattern]();
else
    Console.WriteLine($"{command} not found!");

Console.ReadKey();


static void SingletonExample()
{
    var footballPlayer1 = PlayerFixture.FootballPlayer1;

    Console.WriteLine($"Creating first instance of {footballPlayer1.GetType().Name}");
    Thread.Sleep(WaitInSeconds);
    Singleton.Create(footballPlayer1);

    var footballPlayer2 = PlayerFixture.FootballPlayer2;

    Console.WriteLine($"Creating second instance of {footballPlayer2.GetType().Name}");
    Thread.Sleep(WaitInSeconds);
    Singleton.Create(footballPlayer2);

    Console.WriteLine($"First instance of {footballPlayer1.GetType().Name} is {(footballPlayer1.Equals(Singleton.Player) ? "equal" : "not equal")} to {Singleton.Player.GetType().Name} instance of {nameof(Singleton)}");
    Console.WriteLine($"First instance of {footballPlayer2.GetType().Name} is {(footballPlayer2.Equals(Singleton.Player) ? "equal" : "not equal")} to {Singleton.Player.GetType().Name} instance of {nameof(Singleton)}");
}


static void AbstractFactoryExample()
{
    var footballClub = ClubFixtures.FootballClub;

    Console.WriteLine($"Creating a team instance of {footballClub.GetType().Name}");
    Thread.Sleep(WaitInSeconds);
    var teamFootballClub = footballClub.CreateTeam();
    Console.WriteLine($"{teamFootballClub.DisplayInfo()}");

    Console.WriteLine($"Creating a stadium instance of {footballClub.GetType().Name}");
    Thread.Sleep(WaitInSeconds);
    var stadiumFootballClub = footballClub.CreateStadium();
    Console.WriteLine($"{stadiumFootballClub.DisplayInfo()}");

    Console.WriteLine(Environment.NewLine);

    var basketballClub = ClubFixtures.BasketballClub;

    Console.WriteLine($"Creating a team instance of {basketballClub.GetType().Name}");
    Thread.Sleep(WaitInSeconds);
    var teamBasketballClub = basketballClub.CreateTeam();
    Console.WriteLine($"{teamBasketballClub.DisplayInfo()}");

    Console.WriteLine($"Creating a stadium instance of {basketballClub.GetType().Name}");
    Thread.Sleep(WaitInSeconds);
    var stadiumBasketballClub = basketballClub.CreateStadium();
    Console.WriteLine($"{stadiumBasketballClub.DisplayInfo()}");
}


static void FactoryMethodExample()
{
    var footballPlayer = PlayerFixture.ConcreteFootballPlayer;

    Console.WriteLine($"Creating an instance of {footballPlayer.GetType().Name}");
    Thread.Sleep(WaitInSeconds);
    var playerFootball = footballPlayer.Create();

    Console.WriteLine($"{playerFootball.DisplayInfo()}");

    Console.WriteLine(Environment.NewLine);

    var basketPlayer = PlayerFixture.ConcreteBasketPlayer;

    Console.WriteLine($"Creating an instance of {basketPlayer.GetType().Name}");
    Thread.Sleep(WaitInSeconds);
    var playerBasketball = basketPlayer.Create();

    Console.WriteLine($"{playerBasketball.DisplayInfo()}");
}


static void BuilderExample()
{
    Console.WriteLine($"Building an instance of {nameof(Club)}");
    Thread.Sleep(WaitInSeconds);

    var build = new Builder();

    var club1 = build
        .WithName("AC Milan")
        .WithFoundedDate(new DateTime(1899, 12, 13))
        .WithOwner("RedBird Capital Partners")
        .Build();    

    Console.WriteLine(club1);

    var club2 = build.Build();

    Console.WriteLine(club2);
}

static void PrototypeExample()
{
    var originalFootballPlayer = PlayerFixture.ClonableFootballPlayer;

    Console.WriteLine($"Cloning an instance of {originalFootballPlayer.GetType().Name}");
    Thread.Sleep(WaitInSeconds);
    var clonedFootballPlayer = originalFootballPlayer.Clone();

    Console.WriteLine($"Original: {originalFootballPlayer}");
    Console.WriteLine($"Cloned: {clonedFootballPlayer}");


    var originalBasketballPlayer = PlayerFixture.ClonableBasketballPlayer;

    Console.WriteLine($"Cloning an instance of {originalBasketballPlayer.GetType().Name}");
    Thread.Sleep(WaitInSeconds);
    var clonedBasketballPlayer = originalBasketballPlayer.Clone();

    Console.WriteLine($"Original: {originalBasketballPlayer}");
    Console.WriteLine($"Cloned: {clonedBasketballPlayer}");

}

enum DesignPattern : byte
{
    Singleton,
    AbstractFactory,
    FactoryMethod,
    Builder,
    Prototype
}