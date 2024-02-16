using movie_database_lab;
using System.Text;
List<Movie> movieList = new List<Movie>();
Movie movie1 = new Movie("Coco", "animated",1,2017);
Movie movie2 = new Movie("Moana", "animated", 1,2016);
Movie movie3 = new Movie("Star Wars", "scifi",4, 1977);
Movie movie4 = new Movie("The Fifth Element", "scifi", 4,1997);
Movie movie5 = new Movie("Talk to Me", "horror",3, 2022);
Movie movie6 = new Movie("Aquaman and the Lost Kingdom", "scifi",4, 2023);
Movie movie7 = new Movie("Fairy Play", "drama", 2, 2023);
Movie movie8 = new Movie("The Iron Claw", "drama", 2, 2023);
Movie movie9 = new Movie("Night Swim", "horror", 3, 2024);
Movie movie10 = new Movie("Locked In", "horror", 3, 2023);
movieList.Add(movie1);
movieList.Add(movie2);
movieList.Add(movie3);
movieList.Add(movie4);
movieList.Add(movie5);
movieList.Add(movie6);
movieList.Add(movie7);
movieList.Add(movie8);
movieList.Add(movie9);
movieList.Add(movie10);
while (true)
{
    Console.WriteLine("Welcome to the Movie List Application!");
    Console.WriteLine("There are 10 movies on the list. What category are you interested in?");
    Console.WriteLine("Enter 1 for animated, 2 for drama, 3 for horror, 4 for scifi. ");
    int userInput = 0;
    try
    {
        userInput = int.Parse(Console.ReadLine().ToLower().Trim());
        
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter a valid number");
    }
    if (userInput > 4 || userInput <0 ) { Console.WriteLine("Please enter a valid number"); }
    
    foreach (Movie movie in movieList)
    {
        if (movie.SearchNumber == userInput) { Console.WriteLine(movie.Title + " " + movie.Year); }
    }
    Console.WriteLine("Would you like to continue? (y/n)");
    if (Console.ReadLine().ToLower() != "y") { Console.WriteLine("Goodbye"); break; }
}

Console.Read();