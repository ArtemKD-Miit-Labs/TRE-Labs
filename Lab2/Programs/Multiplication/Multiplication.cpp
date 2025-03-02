// Multiplication.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>

unsigned int mul(unsigned int a);

int main()
{
    unsigned int num;
    std::cout << "Enter number: ";
    std::cin >> num;

    int result = mul(num);

    std::cout << "Mul: " << result << std::endl;
}

unsigned int mul(unsigned int a)
{
    return a * 4;
};