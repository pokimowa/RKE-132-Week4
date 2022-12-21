
string hello = "hello!";
hello = hello.Replace(hello[0], Char.ToUpper( hello[0]));
Console.WriteLine(hello);

int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.WriteLine(numbers.Length);
return;
Random rnd = new Random();
int cpuRandom;

bool LoopActive = true;


while(LoopActive)
{
    cpuRandom = rnd.Next(1,4);
    Console.WriteLine($"cpu has generated{cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");

    int userNumber = Int32.Parse(Console.ReadLine());
     
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        break;
    }else
    {
        Console.WriteLine("oops. TRy again.");
    }
}

Console.WriteLine("Have a nice day!");