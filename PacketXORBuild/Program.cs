using System;
using System.Text;

namespace PacketXORBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is for quickly changing your PacketXOR (ProcessKey) in the Server and Client applications.
            Console.WriteLine("Enter your new ProcessKey: ");

            byte[] KeyToBase64 = Encoding.UTF8.GetBytes(Console.ReadLine());
            byte[] Base64KeyToBytes = Encoding.ASCII.GetBytes(Convert.ToBase64String(KeyToBase64));

            StringBuilder sb = new StringBuilder("char[] ProcessKey =\n{\n");
            for (int i = 0; i < Base64KeyToBytes.Length; i++)
            {
                byte b = Base64KeyToBytes[i];
                _ = sb.Append($"    Convert.ToChar({b})");
                if (i < Base64KeyToBytes.Length - 1)
                {
                    _ = sb.Append(",\n");
                }
            }
            _ = sb.Append("\n};");

            Console.WriteLine("\n" + sb);
            Console.ReadLine();
        }
    }
}
