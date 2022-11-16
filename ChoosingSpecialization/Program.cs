Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
    Console.WriteLine();

    Console.WriteLine("Введите число элементов массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
   
    string[] Random(string[] array_random)
    {
    Random rnd = new Random();
    for (int i = 0; i < array_random.Length; i++)
    {
        string? userString = " ";
        Console.WriteLine("Введите элемент массива");
        userString = Console.ReadLine();
        array_random[i] = userString;
    }

    return array_random;
    }
    string[] array = new string[N];
    array = Random(array);
    
    Console.Write("Массив строк [" + String.Join(",",array) + "]"); 

    