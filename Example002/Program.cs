// Дано число, обозначающее день недели. Выяснить является номер дня недели выходным? (1==a,2,3,4,5,6,7 = ДНИ НЕДЕЛИ)
Console.WriteLine("Вбейте число");
string NumberA = Console.ReadLine();

int a = Convert.ToInt32(NumberA);

if( a == 6 || a == 7) {
    Console.WriteLine("Номер дня недели является выходным");
} else {
    Console.WriteLine("Номер дня недели не является выходным");
}