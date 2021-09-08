using System;
using System.Text;

namespace Base64Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes;

            // encoding string
            var plainText = "Hello, World!";

            bytes = Encoding.ASCII.GetBytes(plainText);
            string encodedBase64 = Convert.ToBase64String(bytes);

            Console.WriteLine($"Plain Text: {plainText}");
            Console.WriteLine($"Encoded Text: {encodedBase64}");

            // decoding string
            var encodedText = "SGVsbG8sIFdvcmxkIQ==";

            bytes = Convert.FromBase64String(encodedText);
            var decodedText = Encoding.ASCII.GetString(bytes);

            Console.WriteLine($"Encoded Text: {encodedText}");
            Console.WriteLine($"Plain Text: {decodedText}");

            Console.ReadLine();
        }
    }
}
