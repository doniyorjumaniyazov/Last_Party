//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//ибо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

    
        Console.WriteLine("Введите элементы массива через запятую:");
        string[] arr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)!;

        string[] resultArr = new string[arr.Length];
        int resultIndex = 0;

        foreach (string s in arr)
        {
            if (s.Length <= 3)
            {
                resultArr[resultIndex++] = s;
            }
        }

        Array.Resize(ref resultArr, resultIndex);

        Console.WriteLine("Конечный массив строк: " + string.Join(", ", resultArr));

