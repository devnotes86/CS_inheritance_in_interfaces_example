namespace CS_inheritance_in_interfaces_example.Services;

public class MusicBandService : IMusicBandService
{
    private string BandName;
    public MusicBandService(string bandName)
    {
        BandName = bandName;
    }
    
    // public void SignAuthograph()
    // {
    //     Console.WriteLine($"{BandName} is Signing authograph");
    // }

    public void PlayConcert()
    {
        Console.WriteLine($"{BandName} is Playing concert");
    }

    public void RecordAlbum()
    {
        Console.WriteLine($"{BandName} is Recording album");
    }
 
}