/*Name:Edward Cason
 * Date:2/09/2023
 * Description: Application that computes the first 25 numbers of the Fibonacci sequence 
 */


namespace deliverable4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 25;

            int[] fibonacci = new int[number];

            fibonacci[0] = 0;
            fibonacci[1] = 1; 

            for(int i = 2; i < number; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Fibonacci number " + i + " is: " + fibonacci[i]);
            }
        }
    }
}