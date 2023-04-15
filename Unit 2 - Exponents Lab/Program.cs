bool loop = true;
string header1 = "Number";
string header2 = "Squared";
string header3 = "Cubed";
do
{
    Console.WriteLine("Learn your squares and cubes!");
    Console.WriteLine();

    Console.Write("Enter an integer:");
    int userinput = int.Parse(Console.ReadLine());

    Console.WriteLine($"{header1,-20} {header2,-20} {header3, +10}");

    Console.WriteLine(new string('=', 52));



    for (int i = 1; i <= userinput; i++)
    {
        int squared = i * i;
        int cubed = i * i * i;

        Console.WriteLine($"{i,-20} {squared, -20} {cubed, +10}");
    }

    Console.WriteLine();

    bool validResponse = false;

    do
    {
        Console.Write("Do you want to proceed? (y/n): ");
        string response = Console.ReadLine();

        if (response.ToLower() == "y" || response.ToLower() == "yes")
        {
            Console.WriteLine("Proceeding...");
            loop = true;
            validResponse = true;
        }
        else if (response.ToLower() == "n" || response.ToLower() == "no")
        {
            Console.WriteLine("Aborting...");
            loop = false;
            validResponse = true;
        }
        else
        {
            Console.WriteLine("Invalid response. Please enter 'y' or 'n'.");
        }
    } while (!validResponse);

    Console.WriteLine();


} while (loop);

Console.WriteLine("Goodbye!");