using System;

class Movie : BaseController, IMovieActorOperation
{
    string MovieName { get; set; }
    string MovieDescription { get; set; }
    DateTime ReleaseDate { get; set; }
    public Movie()
    {
        getConnection();
        Console.WriteLine("1. Add Movie\n2. Add Actor on Movie\n3. Get Movie\n4. View Actor on Movie\n5. Delete Movie\nEnter Your Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Add();
                break;
            case 2:
                MovieActor allocateActor = new MovieActor();
                allocateActor.Add();
                break;
            case 3:
                Get();
                break;
            case 4:
                MovieActor ma = new MovieActor();
                ma.Get();
                break;
            case 5:
                Delete();
                break;
            default:
                Console.WriteLine("You Enter Invalid Choice \n Thank You for Visisting...");
                Console.ReadLine();
                break;
        }
    }
    public void Add()
    {
        Console.WriteLine("\n Enter Movie Name : ");
        this.MovieName = Console.ReadLine();
        Console.WriteLine("\n Enter Movie Description : ");
        this.MovieDescription = Console.ReadLine();
        Console.WriteLine("\n Enter Movie Release Date : ");
        this.ReleaseDate = Convert.ToDateTime(Console.ReadLine());
        String query = "insert into Movies values('" + MovieName + "','" + MovieDescription + "','" + ReleaseDate + "')";
        bool result = Add(query);
        if (result)
            Console.WriteLine("Record Inserted ...");
        else
            Console.WriteLine("Sorry record not inserted ...");

        Console.WriteLine("You want continue with operation press y for yes\nEnter Key :");
        char choice = Convert.ToChar(Console.ReadLine());
        if (choice.Equals('y') || choice.Equals('Y'))
        {
            new Movie();
        }
    }
    public void Get()
    {
        string query = "select * from Movies";
        var reader = Get(query);
        Console.WriteLine(reader.Read());
        while (reader.Read())
        {
            Console.WriteLine("Movie Name : " + reader.GetString(1));
            Console.WriteLine("Movie Description : " + reader.GetString(2));
            Console.WriteLine("Movie ReleaseDate : " + reader.GetString(3));
        }
        Console.WriteLine("You want continue with operation press y for yes\nEnter Key :");
        char choice = Convert.ToChar(Console.ReadLine());
        if (choice.Equals('y') || choice.Equals('Y'))
        {
            new Movie();
        }
    }
    public void Delete()
    {
        Console.WriteLine("Enter Actor Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        string query = "delete from Movies where MovieId = " + id + "";
        bool result = Delete(query);
        if (result)
            Console.WriteLine("Record Deleted ...");
        else
            Console.WriteLine("Sorry record are able to Delete ...");
        Console.WriteLine("You want continue with operation press y for yes\nEnter Key :");
        char choice = Convert.ToChar(Console.ReadLine());
        if (choice.Equals('y') || choice.Equals('Y'))
        {
            new Movie();
        }
    }
}
