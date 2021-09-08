using System;
using System.Text;

namespace Base64Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("emrebiber");
            string base64String = Convert.ToBase64String(bytes);

            Console.WriteLine(base64String);

            // decoding starts here
            bytes = Convert.FromBase64String(base64String);
            var decoded = Encoding.ASCII.GetString(bytes);

            Console.WriteLine(decoded);

            Console.ReadKey();
        }
    }
}
