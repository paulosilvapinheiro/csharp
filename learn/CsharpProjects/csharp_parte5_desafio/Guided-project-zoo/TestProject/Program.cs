// See https://aka.ms/new-console-template for more information
using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

/*

- there will be three visiting shools
    school A has six visiting groups (the default number)
    school B has three visiting groups
    school C has two visiting groups

- foreach each visiting school, perform the following tasks
    Randomize the animals
    Assign the animals to the correct number of groups
    print the school name
    print the animal groups

*/

RandomizeAnimals();

//AssignGroup();

void RandomizeAnimals()
{
    Random random= new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }

    
}

string[,] AssignGroup(int groups = 6)
{
    // Define as dimensões da matriz
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int animals = result.GetLength(1);
    int animal = 0;
    // Preenche a matriz
    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < animals; j++)
        {
            result[i,j] = pettingZoo[animal++];
        }
    }

    return result;
}

string[,] group = AssignGroup();

Console.WriteLine("School A");

// foreach(string animal in pettingZoo) 
// {
//     Console.WriteLine(animal);
// }
PrintGroup(group);

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"GROUP {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i,j].PadRight(10)}\t");
        }   
        Console.WriteLine("");
    }
}

