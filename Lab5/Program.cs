using System.Security.Cryptography;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Программа хеширования сообщений.");
        Console.WriteLine("Введите сообщение: ");
        var message = Console.ReadLine();
        if (message is null) {
            Console.WriteLine("Сообщение не введено");
            return;
        }

        using (var hasher = SHA256.Create()) {
            var saltedMessage = string.Concat(message, s);
            byte[] bytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(saltedMessage));

            var hashMessage = BitConverter.ToString(bytes).Replace("-", "").ToLower();

            Console.WriteLine($"Хешированная строка: {hashMessage}");
        }
    }

    private static string s = "tralivali";
}