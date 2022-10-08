/*написать программу, которая будет на вход принимать два числа, и выявлять является ли второе число кратным первому.
если число не является кратным,то программа выводит остаток от деления*/
Console.WriteLine ("введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
int res = num1 % num2;
if(res == 0){
    Console.WriteLine ($"число {num1} кратно {num2}");
}
else { Console.WriteLine ($"число {num1} не кратно {num2}");}