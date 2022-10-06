int [] array = new int [8];
/*int n = 10;*/

for (int i = 0; i< array.Length; i++)
    array [i] = new Random().Next (1,11);
    /*array [i] = Convert.ToInt32(Console.ReadLine());*/

/*Console.WriteLine("[" + string.Join(", " , array)+ "]");*/
Console.WriteLine($"[{string.Join(", ", array)}]"); 