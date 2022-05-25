
//Welcome Message
Console.WriteLine("---------- Lab2 ----------\n");

//Display menu and allow user to enter option
int option = 0;
do
{
    DisplayMenu();
    Console.WriteLine(" Please enter your choice for menu option.\n");
    option = Convert.ToInt32(Console.ReadLine());
    MenuChoice(option);



} while (option != 0);


// Closing remark
Console.Clear();
Console.WriteLine("Thank your for using my program!");




// Display Menu Method
static void DisplayMenu()
{
    Console.WriteLine("---------- Menu ----------\n");
    Console.WriteLine("1. Add Two Numbers");
    Console.WriteLine("2. Multiplication Table");
    Console.WriteLine("3. Memory Size of Data Type");
    Console.WriteLine("4. Five-Function Calculator");
    Console.WriteLine("0. Exit");
    Console.WriteLine("--------------------------\n");
}

// Menu choice method
static void MenuChoice(int option)
{
    switch(option)
    {
        case 1: Console.WriteLine();
            break;
        case 2: Console.WriteLine();
            break;
        case 3: Console.WriteLine();
            break;
        case 4: Console.WriteLine();
            break;
        case 0: Console.WriteLine();
            break;
        default: Console.WriteLine("Invalid Menu Choice. Please Enter Number Option");
            break;
    }
}


