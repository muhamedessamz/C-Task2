using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2
{
    internal class Program
    {
     
            static void Main()
            { 

                  //Problem1();
                //Problem2();
                //Problem3();
                //Problem4();
                //Problem5();
                //Problem6();
                //Problem7();
                //Problem8();
                //Problem9();
                
            }

            static void Problem1()
            {
                int x = 30;

                int y = 20;

                int sum = x + y;

                Console.WriteLine(sum);
            }

        //Question: What is the shortcut to comment and uncomment a selected block of code in Visual Studio?

        //Comment selected code: Ctrl + K, Ctrl + C

        //Uncomment selected code: Ctrl + K, Ctrl + U



        static void Problem2()
            {
                int x = 10;
                int y = 20;
                Console.WriteLine(x +y);
            }

        //Question: Explain the difference between a runtime error and a logical error with examples.

        // Runtime Error = crashes during execution.
        // Logical Error = wrong output, but no crash.



        static void Problem3()
            {
                string FullName = "Mohamed Essam";
                int Age = 21;
                decimal MonthlySalary = 5670.75M;
                bool IsStudent = true;

                Console.WriteLine($"Name: {FullName}, Age: {Age}, Salary: {MonthlySalary}, Student: {IsStudent}");
            }

        //Question: Why is it important to follow naming conventions such as PascalCase in C#?

        //Using naming conventions like PascalCase improves code readability, ensures consistency, and helps teams understand and maintain the code more easily.



            class Person
            {
                public string Name;
            }

            static void Problem4()
            {
                Person p1 = new Person();
                p1.Name = "Mohamed";
                Person p2 = p1;
                p2.Name = "Essam";
                Console.WriteLine(p1.Name); 
            }

        //Question: Explain the difference between value types and reference types in terms of memory allocation.

        // Value types are stored in the stack and contain the actual value.
        // Reference types are stored in the heap, and variables hold a reference to the object.
        // Modifying a reference type affects all variables pointing to that object.



        static void Problem5()
            {
                int x = 25;
                int y = 6;

                Console.WriteLine("Sum: " + (x + y));
                Console.WriteLine("Difference: " + (x - y));
                Console.WriteLine("Product: " + (x * y));
                Console.WriteLine("Division: " + (x / y));
                Console.WriteLine("Remainder: " + (x % y));
            }

        /* Question: What will be the output of the following code? Explain why:
            int a = 2, b = 7;
            Console.WriteLine(a % b);*/

        // The output is 2 because a (2) is smaller than b (7),
        // so 2 % 7 simply returns 2 (the remainder when 2 is divided by 7).



            static void Problem6()
            {
                int number = 16;

                if (number > 10 && number % 2 == 0)
                {
                    Console.WriteLine("Number is greater than 10 and even.");
                }
                else
                {
                    Console.WriteLine("Number doesn't meet both condition.");
                }
            }
        //Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator?

        // && → Logical AND: used in boolean expressions, stops if the first condition is false (short-circuit).
        // &  → Bitwise AND: compares bits or booleans, always evaluates both sides (no short-circuit).

        static void Problem7()
            {
                double input = 16.65;
                int result = (int)input;
                Console.WriteLine("Explicit cast result: " + result);

                double another = 10;
                double implicitResult = another;

                Console.WriteLine("Implicit result: " + implicitResult);
            }


        //Question: Why is explicit casting required when converting a double to an int?
        // Explicit casting is required when converting from double to int because there's a potential loss of data, such as truncating the decimal part.


        static void Problem8()
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                try
                {
                    int age = int.Parse(input);
                    if (age > 0)
                    {
                        Console.WriteLine("Valid age: " + age);
                    }
                    else
                    {
                        Console.WriteLine("Age must be greater than 0.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

        //Question: What exception might occur if the input is invalid and how can you handle it

        // If the input is not a valid number, FormatException occurs.
        // If the number is too large/small, OverflowException occurs.
        // You can handle them using try-catch blocks.


        static void Problem9()
            {
                int x = 6;
                int y = ++x + x++;
                Console.WriteLine("x: " + x); 
                Console.WriteLine("y: " + y);
            }

        /*Question: Given the code below, what is the value of x after execution? Explain why
        int x = 5;
        int y = ++x + x++;*/

        // After execution:
        // x = 7 → because it was incremented twice (prefix and postfix)
        // y = 12 → because both ++x and x++ used the value 6 at the moment of addition


    }
}

