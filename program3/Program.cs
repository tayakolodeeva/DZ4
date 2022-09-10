// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.

            int[] array = new int[8];
    
 
            Console.WriteLine("Введите 8 элементов массива (элемент -> enter):");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("Созданный массив");
            for (int i = 0; i < array.Length; i++)
            {
                
                Console.Write($"{array[i]} ");
            }
            