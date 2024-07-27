using System;
using System.Text;

class Program
{
    static void Main()
    {
        string encryptedMessage = "10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011";
        string[] encryptedBytes = encryptedMessage.Split(' ');

        StringBuilder decryptedMessage = new StringBuilder();

        foreach (string byteStr in encryptedBytes)
        {
            string rearrangedByte = RearrangeBits(byteStr);
            char decodedChar = (char)Convert.ToInt32(rearrangedByte, 2);
            decryptedMessage.Append(decodedChar);
        }

        Console.WriteLine("Decrypted Message: " + decryptedMessage.ToString());
    }

    static string RearrangeBits(string byteStr)
    {
        char[] bits = byteStr.ToCharArray();

        // troca os 2 bits
        char temp = bits[6];
        bits[6] = bits[7];
        bits[7] = temp;

        // troca de 4 bits com os próximos 4 bits
        for (int i = 0; i < 4; i++)
        {
            temp = bits[i];
            bits[i] = bits[i + 4];
            bits[i + 4] = temp;
        }

        return new string(bits);
    }
}
