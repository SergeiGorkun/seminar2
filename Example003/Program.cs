// Задать номер четверти, показать диапазоны для возможных координат.
Console.WriteLine("Введи номер четверти");
string NumberA = Console.ReadLine();

if(NumberA == "1") {
    Console.WriteLine("Номер четверти равен единице");
} else if(NumberA == "2"){
    Console.WriteLine("Номер четверти равен двойке");
} else if(NumberA == "3"){
    Console.WriteLine("Номер четверти равен тройке");
} else if(NumberA == "4"){
    Console.WriteLine("Номер четверти равен четверке");
} else {
    Console.WriteLine("Ошибка, четверти не существует");
}