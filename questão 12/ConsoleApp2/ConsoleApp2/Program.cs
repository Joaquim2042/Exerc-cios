#include <iostream>

int main()
{
    int valor1, valor2;

    // Loop até os valores serem diferentes
    do
    {
        std::cout << "Digite o primeiro valor: ";
        std::cin >> valor1;

        std::cout << "Digite o segundo valor: ";
        std::cin >> valor2;

        if (valor1 == valor2)
        {
            std::cout << "Os valores devem ser diferentes. Tente novamente.\n";
        }

    } while (valor1 == valor2);

    // Exibe o maior valor
    if (valor1 > valor2)
    {
        std::cout << "O maior valor é: " << valor1 << std::endl;
    }
    else
    {
        std::cout << "O maior valor é: " << valor2 << std::endl;
    }

    return 0;
}
