using System;
using System.Collections.Generic;
using System.Text;

class MovieActor : BaseController, IMovieActorOperation
{
    int MovieId { get; set; }

    int ActorId { get; set; }
    public MovieActor()
    {
        getConnection();
    }
    public void Add()
    {
        // throw new NotImplementedException();
        Console.WriteLine("\n Enter Movie Id : ");
        this.MovieId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n Enter Actor Id : ");
        this.ActorId = Convert.ToInt32(Console.ReadLine());
        String query = "insert into MovieActors values(" + MovieId + "," + ActorId + ")";
        bool result = Add(query);
    }
    public void Get()
    {
        string query = "select * from vMovieAndActors";
        var reader = Get(query);
        Console.WriteLine(reader.Read());
        while (reader.Read())
        {
            Console.WriteLine("Movie Name : " + reader.GetString(1));
            Console.WriteLine("Actor Name : " + reader.GetString(2));
        }
    }
    public void Delete()
    {
        Console.WriteLine("Enter Movie Id : ");
        int MovieId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Actor Id : ");
        int ActorId = Convert.ToInt32(Console.ReadLine());
        string query = "delete from MovieActors where MovieId = " + MovieId + "and ActorId=" + ActorId + "";
        bool result = Delete(query);
        if (result)
            Console.WriteLine("Record Deleted ...");
        else
            Console.WriteLine("Sorry record are able to Delete ...");
    }
}
