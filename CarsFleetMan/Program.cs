using CarsFleetMan;

List<CarFleet> carFleets = new List<CarFleet>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("***********************************");
Console.WriteLine("* CarFleet management App *");
Console.WriteLine("***********************************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingEmployeeFile();
do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {carFleets.Count} carfleet(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("********************");
    Console.WriteLine("* Select an action *");
    Console.WriteLine("********************");

    Console.WriteLine("1: Register carFleet");
    Console.WriteLine("2: View all carFleet");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("5: Modify data");
    Console.WriteLine("6: Delete data");
    Console.WriteLine("9: Quit application");
    Console.Write("Your selection: ");

    userSelection = Console.ReadLine();


    switch (userSelection)
    {
        case "1":
            Utilities.RegisterCarFleet(carFleets);
            break;
        case "2":
            Utilities.ViewAllCarFleets(carFleets);
            break;
        case "3":
            Utilities.SaveCarFleets(carFleets);
            break;
        case "4":
            Utilities.LoadCarFleets(carFleets);
            break;
        case "5":
            Utilities.ModifyCarFleets(carFleets);
            break;
        case "6":
            Utilities.DeleteCarFleets(carFleets);
            break;
        case "9": break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }

}
while (userSelection != "9");

Console.WriteLine("Thanks for using the application");

