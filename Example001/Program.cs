// По двум заданным числам проверять является ли одно квадратом другого?
Console.WriteLine("Введите первое число");
string NumberA = Console.ReadLine();
Console.WriteLine("Введите второе число");
string NumberB = Console.ReadLine();

int a = Convert.ToInt32(NumberA);
int b = Convert.ToInt32(NumberB);

if (a * a == b) {
    Console.WriteLine("Первое число является квадратом второго");
}
else {
    Console.WriteLine ("Первое число не является квадратом второго");
}