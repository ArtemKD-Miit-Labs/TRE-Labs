#include <iostream>
#include <string>

int main() {
    std::string correctPassword = "secret123";
    std::string inputPassword;

    std::cout << "Введите пароль: ";
    std::cin >> inputPassword;

    if (inputPassword == correctPassword) {
        std::cout << "Доступ разрешен\n";
    } else {
        std::cout << "Доступ запрещен\n";
    }

    return 0;
}
