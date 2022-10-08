// напишите программу, которая на вход принимает два числа, и проверяет является ли одно число квадратом другого?
Console.WriteLine ("введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
if (num1/num2==num2 || num2/num1==num1){
    Console.WriteLine ("является");
}
else { Console.WriteLine ("не является");}