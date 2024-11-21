using System.Security.Cryptography;
using System.Text;

namespace AdventOfCodeCSharp._2015;


public class Advent20154 {
    public string Hash = string.Empty;
    
    public void Run()
    {
            string secretKey = "bgvyzdsv"; // Replace with your input
            int number = 0;


            using (MD5 md5 = MD5.Create())
            {
                while (true)
                {
                    // Combine the secret key and the current number
                    string input = secretKey + number;

                    // Compute the MD5 hash
                    byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

                    // Convert hash to hexadecimal string
                    Hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                    // Check if the hash starts with five zeroes
                    if (Hash.StartsWith("000000"))
                    {
                        break;
                    }

                    number++;
                }
            }

            Console.WriteLine($"The smallest number is: {number}");
        }
    }