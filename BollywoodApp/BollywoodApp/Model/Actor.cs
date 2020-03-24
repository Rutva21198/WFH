using System;

class Actor : BaseController, IMovieActorOperation
{
    string ActorName { get; set; }
    int MovieWork { get; set; }
    DateTime DateOfBirth { get; set; }
    public Actor()
    {
        getConnection();
        Console.WriteLine("1. Add Actor\n2. Get Actor\n3. Delete Actor\nEnter Your Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Add();
                break;
            case 2:
                Get();
                break;
            case 3:
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
        Console.WriteLine("\n Enter Actor Name : ");
        this.ActorName = Console.ReadLine();
        Console.WriteLine("\n Enter Work On Total Movie : ");
        this.MovieWork = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n Enter Date Of Birth : ");
        this.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
        String query = "insert into Actors values('" + ActorName + "','" + DateOfBirth + "'," + MovieWork + ")";
        bool result = Add(query);
        if (result)
        {
            Console.WriteLine("Record inserted...\n You want continue with operation press y for yes\nEnter Key :");
        }
        else
            Console.WriteLine("Record inserted...\n You want continue with operation press y for yes\nEnter Key :");
        char choice = Convert.ToChar(Console.ReadLine());
        if (choice.Equals('y') || choice.Equals('Y'))
        {
            new Actor();
        }
    }
    public void Get()
    {
        string query = "select * from Actors";
        var reader = Get(query);
        Console.WriteLine(reader.Read());
        while (reader.Read())
        {
            Console.WriteLine("Actor Name : " + reader.GetString(1));
        }
        Console.WriteLine(" You want continue with operation press y for yes\nEnter Key :");
        char choice = Convert.ToChar(Console.ReadLine());
        if (choice.Equals('y') || choice.Equals('Y'))
        {
            new Actor();
        }
    }
    public void Delete()
    {
        Console.WriteLine("Enter Actor Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        string query = "delete from Actors where ActorId = " + id + "";
        bool result = Delete(query);
        if (result)
            Console.WriteLine("Record Deleted ...");
        else
            Console.WriteLine("Sorry record are able to Delete ...");

        Console.WriteLine("You want continue with operation press y for yes\nEnter Key :");
        char choice = Convert.ToChar(Console.ReadLine());
        if (choice.Equals('y') || choice.Equals('Y'))
        {
            new Actor();
        }
    }
}
