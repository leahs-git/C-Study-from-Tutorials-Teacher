// Passing Value Type data variables



int i = 100;


Console.WriteLine(i);
ChangeValue(i);
Console.WriteLine(i);

//output should be:
Console.WriteLine("100 \n200\n100");











static void ChangeValue(int x)
{
    x = 200;

    Console.WriteLine(x);
}