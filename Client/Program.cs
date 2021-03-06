﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decryption Server.
            var IP = "127.0.0.1";
            var Port = 11000;
            var Server = new IPEndPoint(IPAddress.Parse(IP), Port);
            //

            Console.WriteLine("Send your string...");

            while (true)
            {
                using (var Client = new UdpClient())
                {
                    try
                    {
                        Client.Connect(Server);

                        // Send the packet, receive, and translate.
                        byte[] SendPacket = Encoding.ASCII.GetBytes(PacketXOR(Console.ReadLine()));
                        Client.Send(SendPacket, SendPacket.Length);

                        byte[] ReceivePacket = Client.Receive(ref Server);
                        string TranslatePacket = PacketXOR(Encoding.UTF8.GetString(ReceivePacket));

                        // Logging.
                        if (Regex.Match(TranslatePacket, @"^Error: \b").Success)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        Console.Write(TranslatePacket + "\n\n");
                        Console.ResetColor();

                        // Close until your next request.
                        Client.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n" + "Error: {0}", ex);
                        Console.ResetColor();
                    }
                }
            }
        }

        // Masking the plain-text (mind your own business, WireShark) in the packets with a simple XOR.
        private static string PacketXOR(string input)
        {
            char[] ProcessKey =
             {
                Convert.ToChar(86),
                Convert.ToChar(87),
                Convert.ToChar(53),
                Convert.ToChar(79),
                Convert.ToChar(78),
                Convert.ToChar(85),
                Convert.ToChar(120),
                Convert.ToChar(117),
                Convert.ToChar(78),
                Convert.ToChar(110),
                Convert.ToChar(111),
                Convert.ToChar(122),
                Convert.ToChar(90),
                Convert.ToChar(84),
                Convert.ToChar(90),
                Convert.ToChar(104),
                Convert.ToChar(99),
                Convert.ToChar(106),
                Convert.ToChar(85),
                Convert.ToChar(52),
                Convert.ToChar(86),
                Convert.ToChar(68),
                Convert.ToChar(99),
                Convert.ToChar(52),
                Convert.ToChar(78),
                Convert.ToChar(71),
                Convert.ToChar(73),
                Convert.ToChar(51),
                Convert.ToChar(78),
                Convert.ToChar(68),
                Convert.ToChar(74),
                Convert.ToChar(66),
                Convert.ToChar(82),
                Convert.ToChar(106),
                Convert.ToChar(86),
                Convert.ToChar(112),
                Convert.ToChar(77),
                Convert.ToChar(106),
                Convert.ToChar(107),
                Convert.ToChar(119),
                Convert.ToChar(83),
                Convert.ToChar(107),
                Convert.ToChar(56),
                Convert.ToChar(51),
                Convert.ToChar(98),
                Convert.ToChar(72),
                Convert.ToChar(108),
                Convert.ToChar(74),
                Convert.ToChar(78),
                Convert.ToChar(68),
                Convert.ToChar(69),
                Convert.ToChar(52),
                Convert.ToChar(85),
                Convert.ToChar(51),
                Convert.ToChar(107),
                Convert.ToChar(122),
                Convert.ToChar(98),
                Convert.ToChar(85),
                Convert.ToChar(86),
                Convert.ToChar(108),
                Convert.ToChar(85),
                Convert.ToChar(110),
                Convert.ToChar(81),
                Convert.ToChar(49),
                Convert.ToChar(89),
                Convert.ToChar(84),
                Convert.ToChar(90),
                Convert.ToChar(48),
                Convert.ToChar(77),
                Convert.ToChar(122),
                Convert.ToChar(69),
                Convert.ToChar(119),
                Convert.ToChar(78),
                Convert.ToChar(69),
                Convert.ToChar(86),
                Convert.ToChar(117),
                Convert.ToChar(89),
                Convert.ToChar(86),
                Convert.ToChar(70),
                Convert.ToChar(87),
                Convert.ToChar(78),
                Convert.ToChar(106),
                Convert.ToChar(73),
                Convert.ToChar(53),
                Convert.ToChar(84),
                Convert.ToChar(110),
                Convert.ToChar(78),
                Convert.ToChar(54),
                Convert.ToChar(85),
                Convert.ToChar(85),
                Convert.ToChar(82),
                Convert.ToChar(109),
                Convert.ToChar(78),
                Convert.ToChar(68),
                Convert.ToChar(104),
                Convert.ToChar(81),
                Convert.ToChar(85),
                Convert.ToChar(85),
                Convert.ToChar(53),
                Convert.ToChar(116),
                Convert.ToChar(83),
                Convert.ToChar(106),
                Convert.ToChar(77),
                Convert.ToChar(53),
                Convert.ToChar(87),
                Convert.ToChar(106),
                Convert.ToChar(104),
                Convert.ToChar(112),
                Convert.ToChar(87),
                Convert.ToChar(106),
                Convert.ToChar(73),
                Convert.ToChar(49),
                Convert.ToChar(77),
                Convert.ToChar(50),
                Convert.ToChar(120),
                Convert.ToChar(54),
                Convert.ToChar(85),
                Convert.ToChar(106),
                Convert.ToChar(99),
                Convert.ToChar(122),
                Convert.ToChar(83),
                Convert.ToChar(86),
                Convert.ToChar(108),
                Convert.ToChar(110),
                Convert.ToChar(77),
                Convert.ToChar(106),
                Convert.ToChar(100),
                Convert.ToChar(104),
                Convert.ToChar(89),
                Convert.ToChar(122),
                Convert.ToChar(89),
                Convert.ToChar(120),
                Convert.ToChar(79),
                Convert.ToChar(68),
                Convert.ToChar(108),
                Convert.ToChar(52),
                Convert.ToChar(79),
                Convert.ToChar(86),
                Convert.ToChar(100),
                Convert.ToChar(73),
                Convert.ToChar(78),
                Convert.ToChar(84),
                Convert.ToChar(104),
                Convert.ToChar(105),
                Convert.ToChar(100),
                Convert.ToChar(48),
                Convert.ToChar(103),
                Convert.ToChar(52),
                Convert.ToChar(77),
                Convert.ToChar(68),
                Convert.ToChar(77),
                Convert.ToChar(51),
                Convert.ToChar(77),
                Convert.ToChar(106),
                Convert.ToChar(85),
                Convert.ToChar(49),
                Convert.ToChar(78),
                Convert.ToChar(87),
                Convert.ToChar(74),
                Convert.ToChar(54),
                Convert.ToChar(78),
                Convert.ToChar(68),
                Convert.ToChar(89),
                Convert.ToChar(50),
                Convert.ToChar(77),
                Convert.ToChar(87),
                Convert.ToChar(100),
                Convert.ToChar(79),
                Convert.ToChar(98),
                Convert.ToChar(84),
                Convert.ToChar(99),
                Convert.ToChar(51),
                Convert.ToChar(78),
                Convert.ToChar(49),
                Convert.ToChar(78),
                Convert.ToChar(115),
                Convert.ToChar(78),
                Convert.ToChar(72),
                Convert.ToChar(103),
                Convert.ToChar(51),
                Convert.ToChar(83),
                Convert.ToChar(109),
                Convert.ToChar(120),
                Convert.ToChar(79),
                Convert.ToChar(77),
                Convert.ToChar(84),
                Convert.ToChar(74),
                Convert.ToChar(121),
                Convert.ToChar(78),
                Convert.ToChar(87),
                Convert.ToChar(107),
                Convert.ToChar(51),
                Convert.ToChar(101),
                Convert.ToChar(106),
                Convert.ToChar(74),
                Convert.ToChar(116),
                Convert.ToChar(81),
                Convert.ToChar(49),
                Convert.ToChar(73),
                Convert.ToChar(120),
                Convert.ToChar(100),
                Convert.ToChar(84),
                Convert.ToChar(66),
                Convert.ToChar(54),
                Convert.ToChar(77),
                Convert.ToChar(84),
                Convert.ToChar(70),
                Convert.ToChar(85),
                Convert.ToChar(78),
                Convert.ToChar(84),
                Convert.ToChar(90),
                Convert.ToChar(111),
                Convert.ToChar(77),
                Convert.ToChar(86),
                Convert.ToChar(70),
                Convert.ToChar(76),
                Convert.ToChar(79),
                Convert.ToChar(87),
                Convert.ToChar(85),
                Convert.ToChar(50),
                Convert.ToChar(78),
                Convert.ToChar(106),
                Convert.ToChar(86),
                Convert.ToChar(90),
                Convert.ToChar(83),
                Convert.ToChar(70),
                Convert.ToChar(74),
                Convert.ToChar(54),
                Convert.ToChar(90),
                Convert.ToChar(110),
                Convert.ToChar(66),
                Convert.ToChar(54),
                Convert.ToChar(99),
                Convert.ToChar(84),
                Convert.ToChar(103),
                Convert.ToChar(52),
                Convert.ToChar(83),
                Convert.ToChar(87),
                Convert.ToChar(70),
                Convert.ToChar(79),
                Convert.ToChar(86),
                Convert.ToChar(107),
                Convert.ToChar(77),
                Convert.ToChar(119),
                Convert.ToChar(79),
                Convert.ToChar(86),
                Convert.ToChar(74),
                Convert.ToChar(74),
                Convert.ToChar(101),
                Convert.ToChar(110),
                Convert.ToChar(99),
                Convert.ToChar(119),
                Convert.ToChar(77),
                Convert.ToChar(84),
                Convert.ToChar(104),
                Convert.ToChar(71),
                Convert.ToChar(86),
                Convert.ToChar(108),
                Convert.ToChar(78),
                Convert.ToChar(68),
                Convert.ToChar(86),
                Convert.ToChar(50),
                Convert.ToChar(74),
                Convert.ToChar(118),
                Convert.ToChar(77),
                Convert.ToChar(106),
                Convert.ToChar(65),
                Convert.ToChar(119),
                Convert.ToChar(86),
                Convert.ToChar(106),
                Convert.ToChar(99),
                Convert.ToChar(48),
                Convert.ToChar(77),
                Convert.ToChar(71),
                Convert.ToChar(70),
                Convert.ToChar(71),
                Convert.ToChar(90),
                Convert.ToChar(70),
                Convert.ToChar(78),
                Convert.ToChar(106),
                Convert.ToChar(82),
                Convert.ToChar(122),
                Convert.ToChar(86),
                Convert.ToChar(89),
                Convert.ToChar(77),
                Convert.ToChar(122),
                Convert.ToChar(100),
                Convert.ToChar(71),
                Convert.ToChar(77),
                Convert.ToChar(85),
                Convert.ToChar(90),
                Convert.ToChar(68),
                Convert.ToChar(77),
                Convert.ToChar(48),
                Convert.ToChar(119),
                Convert.ToChar(52),
                Convert.ToChar(84),
                Convert.ToChar(68),
                Convert.ToChar(82),
                Convert.ToChar(84),
                Convert.ToChar(77),
                Convert.ToChar(68),
                Convert.ToChar(89),
                Convert.ToChar(122),
                Convert.ToChar(100),
                Convert.ToChar(85),
                Convert.ToChar(104),
                Convert.ToChar(105),
                Convert.ToChar(77),
                Convert.ToChar(68),
                Convert.ToChar(85),
                Convert.ToChar(120),
                Convert.ToChar(86),
                Convert.ToChar(107),
                Convert.ToChar(86),
                Convert.ToChar(83),
                Convert.ToChar(77),
                Convert.ToChar(107),
                Convert.ToChar(100),
                Convert.ToChar(97),
                Convert.ToChar(89),
                Convert.ToChar(84),
                Convert.ToChar(74),
                Convert.ToChar(54),
                Convert.ToChar(77),
                Convert.ToChar(84),
                Convert.ToChar(81),
                Convert.ToChar(122),
                Convert.ToChar(99),
                Convert.ToChar(110),
                Convert.ToChar(90),
                Convert.ToChar(79),
                Convert.ToChar(77),
                Convert.ToChar(48),
                Convert.ToChar(73),
                Convert.ToChar(48),
                Convert.ToChar(82),
                Convert.ToChar(88),
                Convert.ToChar(89),
                Convert.ToChar(61)
            };

            byte[] FinalKey = Convert.FromBase64CharArray(ProcessKey, 0, ProcessKey.Length);
            char[] output = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = (char)(input[i] ^ FinalKey[i % FinalKey.Length]);
            }

            Array.Clear(ProcessKey, 0, ProcessKey.Length);
            Array.Clear(FinalKey, 0, FinalKey.Length);

            return new string(output);
        }
    }
}
