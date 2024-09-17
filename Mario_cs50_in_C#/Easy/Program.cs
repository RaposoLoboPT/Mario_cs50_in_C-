int num;
do
{
    Console.WriteLine("Diga um número entre 1 e 10:");
    num = int.Parse(Console.ReadLine());
} while (num < 1 || num > 10);

string stairs = "#";

for (int i = 0; i < num; i++)
{
    Console.WriteLine(stairs.PadLeft(num));
    stairs += "#";
}