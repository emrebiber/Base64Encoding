using System;
using System.Text;

namespace Base64Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            var plainText = "Hello, World!";

            byte[] bytes = Encoding.ASCII.GetBytes(plainText);
            string encodedBase64 = Convert.ToBase64String(bytes);

            Console.WriteLine($"Plain Text: {plainText}");
            Console.WriteLine($"Encoded Text: {encodedBase64}");

            var encodedText = "SGVsbG8sIFdvcmxkIQ==";

            bytes = Convert.FromBase64String(encodedText);
            var decodedText = Encoding.ASCII.GetString(bytes);

            Console.WriteLine($"Encoded Text: {encodedText}");
            Console.WriteLine($"Plain Text: {decodedText}");

            Console.ReadLine();
        }
    }
}
