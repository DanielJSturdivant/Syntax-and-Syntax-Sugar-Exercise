namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            string response = (answer < 9) ? response = $"{answer} is less than nine" : response = $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);
        }
    }
}
