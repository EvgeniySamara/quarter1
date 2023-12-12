

///Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
///длина которых меньше, либо равна 3 символам. 
///Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
///При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



    static string[] arrinput (int array_len)
    {  
       /// string [] array = new string[4] {"Hello", "2", "world", "ghghg"};
     string [] array = new string[array_len];
     for(int i = 0; i < array.Length; i++)
    {
    Console.Write($"Введите {i+1} элемент:");
      array[i] = Console.ReadLine();
    }
 
     return array;
    }

    Console.WriteLine("Введите размерность массива:");
    int len = Convert.ToInt32(Console.ReadLine());

     string [] stringlist = new string[len];
     string [] result = new string[len];
     

     stringlist = arrinput(len);


     Console.WriteLine("Результат:");    
     int count = 0
   for(int i = 0; i < stringlist.Length; i++)
    {
        if (stringlist[i].Length<=3)
        
      
    }
        
  

