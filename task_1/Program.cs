// Написать программу которая выводит случайное трехзначное число, и удаляет вторую цифру этого числа
int number = new Random ().Next (100, 1000); 
int a = number / 100;
int b= number % 10;
Console.WriteLine($"случайное число = {number}");
Console.WriteLine($"{a}{b}");









