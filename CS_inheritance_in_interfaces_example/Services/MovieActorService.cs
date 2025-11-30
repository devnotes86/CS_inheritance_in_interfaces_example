namespace CS_inheritance_in_interfaces_example.Services;

public class MovieActorService : IMovieActorService
{
    private string ActorName;
    public MovieActorService(string actorName)
    {
        ActorName = actorName;
    }
    
    public void SignAuthograph()
    {
        Console.WriteLine($"{ActorName} is Signing authograph");
    }

    public void ActInJamesBondMovie()
    {
        Console.WriteLine($"{ActorName} is Acting in James Bond Movie");
    }

    public void ActInWatchCommercial()
    {   
        Console.WriteLine($"{ActorName} is Acting in Rolex Commercial");
    }
}