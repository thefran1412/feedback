using System.Security.Cryptography;
using System.Text;

public class HashStrings
{
    public HashStrings()
    {
    }

    public static byte[] GetHash(string inputString)
    {
        HashAlgorithm algorithm = MD5.Create();  //or use SHA1.Create();
        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
    }
    public static string GetHashedString(string inputString)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in GetHash(inputString))
            sb.Append(b.ToString("X2"));

        return sb.ToString();
    }
}