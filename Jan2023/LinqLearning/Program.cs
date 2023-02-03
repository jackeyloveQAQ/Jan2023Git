namespace LinqLearning;

public class Program
{
    public static void Main()
    {
        var thi = new EmployeeService();
        thi.Demo();
    }
}
// In-Memory: data/memory that is stored in Collection
/* List, Dictionary, Arrays can use linq because the output of 
 linq is IEnumerable*/
/*Out-memory: database of outside sources: Linq can still be used
 * on these but hte output would be IQueryable
 */
//Linq Providers:
//LINQ to Objects: Inmemory sources
//LINQ to entities: processing data stored in External databases
//LINQ to XML: not common practice

//delagates, Lambda expressions, Extension methods, Collection
//ORMs: Object Relational Mapping: connect the ASP.Net Application
//To SQL Server without any "Impendance mismatch"

//Map means conversion of object types 

//ORMs need providers: they are the connection that will connect
//your linq to SQL server

//Databases, Querying, Er Diagrams 
//One to many, one to one
//Many to Many:
//One Movies can have many genres
//One genre can have many movies that have it
//We create a junction table called MovieGenre
//Movie that a foriegn key to a list of MovieGenres
//Genre that also has a foreign key MovieGenre
/*
 public class MovieGenre{
    public int id{get; set;}
    public int MovieID{get;set;}
    public int GenreId{get;set;}
}
 */