// very very imp question what is the diffrence between refrence and out keyword?
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()//caller
        {
            int value = 100;
            Console.WriteLine(value);
            Program.sum(ref value);
            Console.WriteLine(value);
            Console.ReadLine();
        }
    public static int sum(ref int x)//called or cally
        {
            x = x + 1;
            Console.WriteLine(x);
            return x;
        }
    }*/
//call by value: passing the any integer value toa called method known as a method call by value 
//in case of call by value if any modification happend inside called method 
//it will not reflect to caller


//call by refrence: passing the any integer value toa called method known as a method call by value 
//in case of call by value if any modification happend inside called method 
//it will  reflect to caller
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()//caller
    {
        int value = 100;
        Console.WriteLine(value);
        Program e = new Program();
        e.sum(ref value);
        Console.WriteLine(value);
        Console.ReadLine();
    }
    public int sum(ref int x)//called or cally
    {
        x = x + 1;
        Console.WriteLine(x);
        return x;
    }// it is bai-darection
}*/
//call by value: passing the any integer value to a called method known as a method call by value 
//in case of call by value if any modification happend inside called method 
//it will not reflect to caller


//call by refrence: passing the any integer value toa called method known as a method call by value 
//in case of call by value if any modification happend inside called method 
//it will  reflect to caller


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()//caller
    {
        int value;
        Program e = new Program();
        e.sum(out value);
        Console.WriteLine(value);
        Console.ReadLine();
    }
    public int sum(out int x)//called or cally
    {
        x = 200;
        return 144;
    }
} //out is the uni-darection
*/
/*using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main() //caller 
    {
        int i = 10;
        Console.WriteLine(i);
        Sum(ref i);
        Console.WriteLine(i);
        Console.ReadLine();

    }

    public static void Sum(ref int x) //called method
    {
        x = x + 10;

        Console.WriteLine(x);
    }



}
*/


/*
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main() //caller 
    {
        int i = 100; // 0001010
        Console.WriteLine(i);
        Sum(ref i);
        Console.WriteLine(i);
        Console.ReadLine();

    }

    public static void Sum(ref int x) //called method  0001010 and 100
    {
        x = x + 10;

        Console.WriteLine(x);
    }



}

*/
/*using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main() //caller 
    {
        int i = 50;
        Sum(out i);
        Console.WriteLine(i);
        Console.ReadLine();
    }

    public static void Sum(out int x) //called method  0001010 and 100
    {

        x = 1000;

    }

}
*/
/*using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {

        Employee e1 = new Employee();
        e1.Sum(100);
        e1.Sum(100, 200);
        Console.ReadLine();
        //Method Overloading :-if a class have multiple methods with same name but different in parameter.
        //known as method overloading 

        //rules of defining method overloading 
        //1. method name will be same 
        //3. number of parameter willm be  different
        //4. type of parameter will  be  different 
        //5. order of parameter will be  different 
        //6. retuen type can be anythink.


    }

    public void Sum(int x)
    {
        Console.WriteLine("Sum of x and y : " + x);
    }

    public void Sum(int x, int y)
    {
        Console.WriteLine("Sum of x and y : " + x + y);
    }

    public void Sum(int x, int y, int z)
    {
        Console.WriteLine("Sum of x and y : " + x + y + z);
    }

}*/

