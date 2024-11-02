using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Anime name1= new Anime("Naruto");
        // Anime name2= new Anime("One Piece");
        // Anime name3= new Anime("Dragon Ball Z");

        //instead of this^ , this....

        Anime[] anime_names={new Anime("NAruto"),new Anime("One Piece"),new Anime("Dragon Ball Z")};
        
    }
}
class Anime
{
    public Anime(string name) // constructor
    {
        Console.WriteLine($"name : {name}");
    }
}    