namespace CS_inheritance_in_interfaces_example.Services;

public interface IMusicBandService: IArtistService
{
    void PlayConcert();
    void RecordAlbum();
}