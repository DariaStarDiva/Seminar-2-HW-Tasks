//выводит 3значное число и удаляет вторую цифру
Console.Clear();
int n = new Random().Next(100, 1000);
Console.WriteLine ($" Сгенерированное число: {n}");

int n1 = n / 100;
int n2 = n% 10;
/*Console.Write (n1);
Console.Write (n2);*/
Console.WriteLine(n1*10+n2);