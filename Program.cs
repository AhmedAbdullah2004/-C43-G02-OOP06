using System;

namespace Assignment
{
    // 1
    //class Point3D : ICloneable, IComparable<Point3D>
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public int Z { get; set; }

    //    #region Default constructor
    //    public Point3D() : this(0, 0, 0) { }
    //    #endregion

    //    #region Constructor with one parameters
    //    public Point3D(int x) : this(x, 0, 0) { }
    //    #endregion

    //    #region  Constructor with two parameters
    //    public Point3D(int x, int y) : this(x, y, 0) { }
    //    #endregion

    //    #region Constructor with three parameters
    //    public Point3D(int x, int y, int z)
    //    {
    //        X = x;
    //        Y = y;
    //        Z = z;
    //    }
    //    #endregion

    //    #region Override
    //    public override string ToString()
    //    {
    //        return $"Point Coordinates: ({X}, {Y}, {Z})";
    //    }

    //    public static bool operator ==(Point3D p1, Point3D p2)
    //    {
    //        return (p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z);
    //    }

    //    public static bool operator !=(Point3D p1, Point3D p2)
    //    {
    //        return !(p1 == p2);
    //    }
    //    #endregion

    //    #region Implement ICloneable Interface
    //    public object Clone()
    //    {
    //        return new Point3D(this.X, this.Y, this.Z);
    //    }
    //    #endregion

    //    #region Implement IComparable to Sort Points by X & Y
    //    public int CompareTo(Point3D other)
    //    {
    //        if (this.X != other.X)
    //            return this.X.CompareTo(other.X);
    //        return this.Y.CompareTo(other.Y);
    //    }
    //}
    //#endregion
    // 2
    //class Maths
    //{
    //    public static int Add(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public static int Subtract(int a, int b)
    //    {
    //        return a - b;
    //    }

    //    public static int Multiply(int a, int b)
    //    {
    //        return a * b;
    //    }

    //    public static double Divide(int a, int b)
    //    {
    //        if (b == 0)
    //        {
    //            Console.WriteLine("Division by zero is not allowed!");
    //            return double.NaN;
    //        }
    //        return (double)a / b;
    //    }
    //}

    // 3
    //#region class Discount
    //abstract class Discount
    //{
    //    public string Name { get; set; }
    //    public abstract decimal CalculateDiscount(decimal price, int quantity);
    //}
    //#endregion

    //#region classes Discount inhertance
    //class PercentageDiscount : Discount
    //{
    //    private decimal Percentage;

    //    public PercentageDiscount(decimal percentage)
    //    {
    //        Name = "Percentage Discount";
    //        Percentage = percentage;
    //    }

    //    public override decimal CalculateDiscount(decimal price, int quantity)
    //    {
    //        return price * quantity * (Percentage / 100);
    //    }
    //}

    //class FlatDiscount : Discount
    //{
    //    private decimal FlatAmount;

    //    public FlatDiscount(decimal amount)
    //    {
    //        Name = "Flat Discount";
    //        FlatAmount = amount;
    //    }

    //    public override decimal CalculateDiscount(decimal price, int quantity)
    //    {
    //        return FlatAmount * Math.Min(quantity, 1);
    //    }
    //}

    //class BuyOneGetOneDiscount : Discount
    //{
    //    public BuyOneGetOneDiscount()
    //    {
    //        Name = "Buy One Get One Discount";
    //    }

    //    public override decimal CalculateDiscount(decimal price, int quantity)
    //    {
    //        return (price / 2) * (quantity / 2);
    //    }
    //}
    //#endregion

    //#region class User
    //abstract class User
    //{
    //    public string Name { get; set; }
    //    public abstract Discount GetDiscount();
    //}
    //#endregion

    //#region classes User inhertance
    //class RegularUser : User
    //{
    //    public RegularUser(string name)
    //    {
    //        Name = name;
    //    }

    //    public override Discount GetDiscount()
    //    {
    //        return new PercentageDiscount(5);
    //    }
    //}

    //class PremiumUser : User
    //{
    //    public PremiumUser(string name)
    //    {
    //        Name = name;
    //    }

    //    public override Discount GetDiscount()
    //    {
    //        return new FlatDiscount(100);
    //    }
    //}

    //class GuestUser : User
    //{
    //    public GuestUser(string name)
    //    {
    //        Name = name;
    //    }

    //    public override Discount GetDiscount()
    //    {
    //        return null; 
    //    }
    //}
    //#endregion 
    class Program
    {
        static void Main(string[] args)
        {
            #region 1- First Project:
        //    Point3D P = new Point3D(10, 10, 10);
        //    Console.WriteLine(P.ToString());

        //    Console.Write("Enter P1 (X, Y, Z): ");
        //    string[] input1 = Console.ReadLine().Split(',');
        //    Point3D P1 = new Point3D(int.Parse(input1[0]), int.Parse(input1[1]), int.Parse(input1[2]));

        //    Console.Write("Enter P2 (X, Y, Z): ");
        //    string[] input2 = Console.ReadLine().Split(',');
        //    Point3D P2 = new Point3D(int.Parse(input2[0]), int.Parse(input2[1]), int.Parse(input2[2]));

        //    Console.WriteLine(P1 == P2 ? "P1 and P2 are Equal" : "P1 and P2 are NOT Equal");

        //    Point3D P1_Clone = (Point3D)P1.Clone();
        //    Console.WriteLine($"Cloned P1: {P1_Clone}");

        //    Point3D[] pointsArray = {
        //    new Point3D(5, 3, 1),
        //    new Point3D(2, 4, 7),
        //    new Point3D(5, 2, 6),
        //    new Point3D(1, 9, 3)
        //};

        //    Console.WriteLine("\nBefore Sorting:");
        //    foreach (var point in pointsArray) Console.WriteLine(point);

        //    Array.Sort(pointsArray);

        //    Console.WriteLine("\nAfter Sorting:");
        //    foreach (var point in pointsArray)
        //        Console.WriteLine(point);

            #endregion

            #region 2- Second Project:
            //Console.WriteLine("Addition: " + Maths.Add(10, 5));
            //Console.WriteLine("Subtraction: " + Maths.Subtract(10, 5));
            //Console.WriteLine("Multiplication: " + Maths.Multiply(10, 5));
            //Console.WriteLine("Division: " + Maths.Divide(10, 5));
            #endregion

            #region 3- Third Project:
            //Console.WriteLine("Enter user type (Regular, Premium, Guest): ");
            //string userType = Console.ReadLine().Trim().ToLower();

            //Console.Write("Enter your name: ");
            //string userName = Console.ReadLine();

            //User user;
            //switch (userType)
            //{
            //    case "regular":
            //        user = new RegularUser(userName);
            //        break;
            //    case "premium":
            //        user = new PremiumUser(userName);
            //        break;
            //    case "guest":
            //        user = new GuestUser(userName);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid user type. Defaulting to Guest.");
            //        user = new GuestUser(userName);
            //        break;
            //}

            //Console.Write("Enter product price: ");
            //decimal price = decimal.Parse(Console.ReadLine());

            //Console.Write("Enter quantity: ");
            //int quantity = int.Parse(Console.ReadLine());

            //Discount discount = user.GetDiscount();
            //decimal discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0;
            //decimal finalPrice = (price * quantity) - discountAmount;

            //Console.WriteLine($"\nUser: {user.Name} ({userType.ToUpper()})");
            //Console.WriteLine($"Product Price: ${price} | Quantity: {quantity}");
            //Console.WriteLine($"Discount Applied: {discount?.Name ?? "No Discount"}");
            //Console.WriteLine($"Total Discount: ${discountAmount}");
            //Console.WriteLine($"Final Price: ${finalPrice}");
            #endregion
        }
    }
}
