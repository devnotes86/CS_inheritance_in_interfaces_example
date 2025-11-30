// See https://aka.ms/new-console-template for more information

using CS_inheritance_in_interfaces_example.Services;


var movieActorService = new MovieActorService("Daniel Craig");
movieActorService.SignAuthograph();
movieActorService.ActInJamesBondMovie();
movieActorService.ActInWatchCommercial();

Console.WriteLine(""); 
Console.WriteLine(""); 

var musicBandService = new MusicBandService("Iron Maiden");
musicBandService.SignAuthograph();
musicBandService.PlayConcert();
musicBandService.RecordAlbum();
