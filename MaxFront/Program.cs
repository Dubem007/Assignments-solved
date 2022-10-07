// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public abstract class shapes {
    public abstract int shape();
}

public abstract class Orders
{
    public abstract int product();
    public abstract int box();
    
}

// These are for square (Area and Perimeter)
public class Areaofsquare : shapes { 
    public override int shape() {
        int len = 5;
        int area = len * len;
        return area;
    }
}

public class Perimeterofsquare : shapes
{
    public override int shape()
    {
        int len = 5;
        int perimeter = len + len;
        return perimeter;
    }
}

// These are for rectangle (Area and Perimeter)
public class Areaofrectangle : shapes
{
    public override int shape()
    {
        int len = 5;
        int breadth = 4;
        int area = len * breadth;
        return area;
    }
}

public class Perimeterofrectangle : shapes
{
    public override int shape()
    {
        int len = 5;
        int breadth = 4;
        int perimeter = len + breadth;
        return perimeter;
    }
}

// These are for a circle (Area and Perimeter)
public class Areaofcircle : shapes
{
    public override int shape()
    {
        int pie = 5;
        int radius = 4;
        int area = pie * (radius * radius);
        return area;
    }
}

public class Perimeterofcircle : shapes
{
    public override int shape()
    {
        int pie = 5;
        int radius = 4;
        int perimeter = 2*(pie * radius);
        return perimeter;
    }
}


//=======================================================//


public class CostofOrders : Orders
{
    int totalCost = 0;
    public override int product()
    {
        int product = 5;
        return product;
    }

    public override int box()
    {
        
        int sum = 0;
        int[] product = { 6, 8 };
        for (int i = 0; i < product.Length; i++)
        {
            sum += product[i];
        };
        return sum;
    }
   
    

    
}

public class CostofTotal
{
    public int CostofTotalOrders(int product, int[] boxes)
    {
        int totalCost = 0;
        int sum = 0;
        for (int i = 0; i < boxes.Length; i++)
        {
            sum += boxes[i];
        };
        totalCost = sum + product;
        return totalCost;





    }
}

public class Notify {
    public void Notifications(string wants)
    {
        if (wants != "disabled")
        {
            int tes = 1;
            var notify = disablenotify(tes);
            if (notify == true) {
                Console.WriteLine("//===========All notifications are required ===========//");
                Console.WriteLine("Email is been sent by the user");
                Console.WriteLine("Facebook notification is been sent by the user");
                Console.WriteLine("Whats spp notifcation is been sent by the user");
                Console.WriteLine("Instagram notifcation is been sent by the user");
            }
            

        }
        else {
            int tes = 0;
            var notify = disablenotify(tes);
            if (notify == false)
            {
                Console.WriteLine("//===========User disabled notification ===========//");
                Console.WriteLine("Email is been sent by the user");
            }
                
            
        }
        
    }

    private bool disablenotify (int cause)
    {
        if (cause == 0)
        {
            return false;
        }
        else
        {
            
            return true;
        }
    }
}



public class program {
    public static void Main(string[] args)
    {
        Console.WriteLine("//===========================Question 1 ======================//");
        Console.WriteLine("The answers for question 1 are");
        Areaofsquare Asquare = new Areaofsquare();
        Console.WriteLine("The area of square is: " + Asquare.shape());
        Perimeterofsquare Psquare = new Perimeterofsquare();
        Console.WriteLine("The perimeter of square is: " + Psquare.shape());
        Areaofrectangle Arectangle = new Areaofrectangle();
        Console.WriteLine("The area of rectangle is: " + Arectangle.shape());
        Perimeterofrectangle Prectangle = new Perimeterofrectangle();
        Console.WriteLine("The perimeter of rectangle is: " + Prectangle.shape());
        Areaofcircle Acircle = new Areaofcircle();
        Console.WriteLine("The area of circle is: " + Acircle.shape());
        Perimeterofcircle Pcircle = new Perimeterofcircle();
        Console.WriteLine("The perimeter of circle is: " + Pcircle.shape());


        //===========================Question 2 ======================//
        Console.WriteLine("//===========================Question 2 ======================//");
        CostofTotal cost = new CostofTotal();
        int a = 50;
        int[] b = { 16, 27 };
        Console.WriteLine(cost.CostofTotalOrders(a, b));

        
        //==========================Question 3 =======================//
        Console.WriteLine("//===========================Question 3 ======================//");
        Notify noty = new Notify();
        string want = " not disabled";
        noty.Notifications(want);

    }
}
