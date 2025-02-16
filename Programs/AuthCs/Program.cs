using System;

class Program {
    static void Main() {
        string correctPassword = "secret123";

        Console.Write("Введите пароль: ");
        string inputPassword = Console.ReadLine();

        if (inputPassword == correctPassword) {
            Console.WriteLine("Доступ разрешен");
        } else {
            Console.WriteLine("Доступ запрещен");
        }

        Console.ReadKey();
    }
}
