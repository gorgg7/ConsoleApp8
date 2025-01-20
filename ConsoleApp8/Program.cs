#region PART1
//1-B
//2-A
//3-B
//4-B
//5-D
//6-A
//7-B
//8-A
//9-B
//10-C
#endregion
#region PART2
//Q1
using System;
//interface ishape
//{
//    double area { get; }
//    void displayshape();
//}
//interface icircle : ishape
//{
//    double radius { get; }

//}
//interface irectangle : ishape
//{
//    double height { get; }
//    double width { get; }
//}
//class circle : icircle
//{
//    public double radius { get; set; }
//    public circle(double radius) 
//    {  this.radius = radius; } 
//    public double area =>Math.PI * radius*radius;
//    public void displayshape()
//    {
//        Console.WriteLine(area);
//    }
//}
//class rectangle : irectangle
//{
//    public double height { get; set; }
//    public double width { get; set; }
//    public rectangle(double height, double width)
//    {
//        this.height = height;
//        this.width = width;
//    }
//    public double area=>width*height;
//    public void displayshape() {
//        Console.WriteLine(area);
//    }
//}
//class program
//{
//   static void Main()
//    {
//        ishape circle = new circle(4);
//        circle.displayshape();
//        ishape rectangle = new rectangle(4, 4);
//        rectangle.displayshape();
//    }
//}

//Q2
interface iauthenication
{
    bool authenticateUser(string username, string password);
    bool authorizeUser(string username, string role);
}

class BasicAuthenticationService : iauthenication
{
    private readonly Dictionary<string, string> _credentials = new Dictionary<string, string>
    {
        { "user1", "password1" },
        { "user2", "password2" }
    };

    private readonly Dictionary<string, string> _roles = new Dictionary<string, string>
    {
        { "user1", "admin" },
        { "user2", "user" }
    };

    public bool authenticateUser(string username, string password)
    {
        if (_credentials.ContainsKey(username) && _credentials[username] == password)
        {
            return true;
        }
        return false;
    }

    public bool authorizeUser(string username, string role)
    {
        if (_roles.ContainsKey(username) && _roles[username] == role)
        {
            return true;
        }
        return false;
    }
}
class Program
{
    static void Main(string[] args)
    {
        iauthenication authService = new BasicAuthenticationService();
        bool isAuthenticated = authService.authenticateUser("user1", "password1");
        bool isAuthorized = authService.authorizeUser("user1", "admin");
        Console.WriteLine($"User authenticated: {isAuthenticated}");
        Console.WriteLine($"User authorized: {isAuthorized}");
    }
}
#endregion
