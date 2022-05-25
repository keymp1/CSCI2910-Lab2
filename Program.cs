
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
        case 1:
            Addition();
            Console.Clear();
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

// Question 1 Method
static void Addition()
{
    Console.WriteLine("---------- Adding Two Numbers ----------\n");
    Console.WriteLine("Enter your first number.");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your second number.");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The sum of {num1} plus {num2} equals {num1 + num2}\n");

    // This clears the console screen after a 3 second  delay.
    // Credit from: https://social.msdn.microsoft.com/Forums/vstudio/en-US/e78af15d-c9f6-4685-9382-4c185c3e663c/c-how-to-make-the-console-process-delay?forum=csharpgeneral
    Thread.Sleep(TimeSpan.FromSeconds(3));

}


