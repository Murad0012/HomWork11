namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "java";
            input = input.ToUpper();
            char[] charArray = input.ToCharArray();
            char temp;
            for (int i = 0; i < charArray.Length - i; i++)
            {
                temp = charArray[i];
                charArray[i] = charArray[input.Length - i - 1];
                charArray[input.Length - i - 1] = temp;
            }
            Console.WriteLine(charArray);
        }
    }
}