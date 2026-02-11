namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Q1: What will this print and explain what happens ?

            //double d = 9.99;
            //int x = (int)d; //Overlodaing
            //Console.WriteLine(x); // 9 >> because this is explicit casting cause data loss
            #endregion

            #region Q2: This code doesn’t compile. Fix it with the smallest change?
            //int n = 5;
            ////double d2 = n / 2; // 2
            //double d2 =(double) n / 2; // 2.5
            //Console.WriteLine(d2);

            #endregion

            #region Q3: You read a number from user input ..Write the correct line to get age as int.

            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine(input);

            #endregion

            #region Q4: What happens here and why ?
            //string s = "12a";
            //int x = int.Parse(s);
            //Console.WriteLine(x);// FormatExciption
            ////Can't convert string format to int
            #endregion

            #region Q5: Complete the code from the previous question so it prints Invalid if conversion into int fails, otherwise prints the number

            //string s = "12a";
            //if(int.TryParse(s , out int x))
            //{
            //    Console.WriteLine($"Valid Number: {x}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Number");
            //}


            #endregion

            #region Q6: What will this print and explain why ?
            //object o = 10;
            //int a = (int)o; // a = 10 after Exciplicit casting o object will assign value to a int
            //Console.WriteLine(a + 1); // 11 

            #endregion

            #region Q7: What will this print and explain why and if there is a problem handle it ?
            //object o = 10;
            ////long x = (long)o;//Invalid CastingExciption 
            ////long x = (long) (int)o;  //Unbox first, then convert
            ////Console.WriteLine(x); 
            //try
            //{
            //    long x = (long)o;
            //    Console.WriteLine(x);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid"); ;
            //}
            #endregion

            #region Q8: Fix this to avoid exceptions and print - 1 if conversion isn’t possible?

            //object o = 10;
            //try
            //{
            //    long x =(long)(int)o;
            //    Console.WriteLine(x);

            //}
            //catch (Exception)
            //{

            //    Console.WriteLine(-1);
            //}
            #endregion


            #region Q9: What will this print and explain why ?

            //string? name = null;
            //Console.WriteLine(name?.Length); //empty space cause string name is nullable

            #endregion

            #region Q10: What will this print and explain the process ?

            //string? name2 = null;
            //int length = name2?.Length ?? 0; // lengh = 0 >> cause Null Coalising print this value 0 if value equal Null
            #endregion

            #region Q11: What’s wrong with this “safe” code and how can we solve it?
            //string? s = null;
            ////int x = int.Parse(s ?? "0");
            //int? x = int.Parse(s ?? "0");
            //if (x.HasValue)
            //{
            //    Console.WriteLine(x.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid value");
            //}


            #endregion
        }
    }
}
