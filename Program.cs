//Criar função que imprime 15 letras do alfabeto, sendo que cada letra deve ser impressa em uma linha de forma aleatoria.
//Exemplo de saída:
//A
//B
//C
//D
//E
//F
//G

using System;

//função que traz uma letra aleatoria
public static class RandomLetter
{
    public static char GetLetter()
    {
        Random random = new Random();
        int num = random.Next(0, 26); // 26 letras no alfabeto
        char let = (char)('a' + num);
        return let;
    }
}

//função que imprime 15 letras aleatorias
public static class PrintLetter
{
    public static void Print()
    {
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(RandomLetter.GetLetter());
        }
    }
}

//função principal
class Program
{
    static void Main(string[] args)
    {
        PrintLetter.Print();
    }
}