﻿Console.WriteLine("Введите Ф.И.О.: ");
string? fullname = Console.ReadLine();
Console.WriteLine("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите e-mail: ");
string? email = Console.ReadLine();
Console.WriteLine("Введите кол-во баллов по математике: ");
double pointsMath = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кол-во баллов по программированию: ");
double pointsProg = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кол-во баллов по физике: ");
double pointsPhysic = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Ф.И.О.: {fullname} Возраст: {age} e-mail {email} баллы по математике: {pointsMath} баллы по программированию: {pointsProg} баллы по физике: {pointsPhysic}");
Console.ReadLine();
