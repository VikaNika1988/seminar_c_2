// Напишите программу, которая принимает число и проверяет кратно ли оно одновременно числам 7 и 23
Console.WriteLine ("напишите число");
int a = int.Parse(Console.ReadLine()!);
if (a % 7 == 0 && a % 23 == 0){
    Console.WriteLine($"число {a} одновременно кратно и 7 и 23");
}
else{Console.WriteLine ("не кратно");}

