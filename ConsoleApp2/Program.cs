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

        }
    }
}
