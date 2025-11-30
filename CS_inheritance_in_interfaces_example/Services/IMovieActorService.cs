namespace CS_inheritance_in_interfaces_example.Services;

public interface IMovieActorService: IArtistService
{
    void ActInJamesBondMovie();
    void ActInWatchCommercial();
}