
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
        case 2:
            MultiplicationTable();
            Console.Clear();
            break;
        case 3:
            ByteSize();
            Console.Clear();
            break;
        case 4:
            Calculator();
            Console.Clear();
            break;
        case 0:
            Console.Write("Thank you for using my program!");
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

// Question 2 Method
static void MultiplicationTable()
{
    Console.WriteLine("Enter number to see it's multiplcation table");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the Maximum number for the multiplication table");
    int max = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i <= max; i++)
    {
        Console.WriteLine($"{num} * {i} = {num * i}");
    }

    Thread.Sleep(TimeSpan.FromSeconds(7));

}


// Question 3 method
static void ByteSize()
{
    Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
    Console.WriteLine("Type          Byte(s) of Memory                   Min                 Max");
    Console.WriteLine($"sbyte        {sizeof(sbyte)}                   {sbyte.MinValue}                 {sbyte.MaxValue}");
    Console.WriteLine($"byte         {sizeof(byte)}                    {byte.MinValue}                  {byte.MaxValue}");
    Console.WriteLine($"short        {sizeof(short)}                   {short.MinValue}                 {short.MaxValue}");
    Console.WriteLine($"ushort       {sizeof(ushort)}                  {ushort.MinValue}                {ushort.MaxValue}");
    Console.WriteLine($"int          {sizeof(int)}                     {int.MinValue}                   {int.MaxValue}");
    Console.WriteLine($"uint         {sizeof(uint)}                    {uint.MinValue}                  {uint.MaxValue}");
    Console.WriteLine($"long         {sizeof(long)}                    {long.MinValue}                  {long.MaxValue}");
    Console.WriteLine($"ulong        {sizeof(ulong)}                   {ulong.MinValue}                 {ulong.MaxValue}");
    Console.WriteLine($"float        {sizeof(float)}                   {float.MinValue}                 {float.MaxValue}");
    Console.WriteLine($"double       {sizeof(double)}                  {double.MinValue}                {double.MaxValue}");
    Console.WriteLine($"decimal      {sizeof(decimal)}                 {decimal.MinValue}               {decimal.MaxValue}");
    Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

    Thread.Sleep(TimeSpan.FromSeconds(3));
}

// Question 4 Method
static void Calculator()
{
    string input = "";
    do
    {
        Console.WriteLine("Please enter your first operand.");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your Operator (+, -, *, /, %)");
        string op = Console.ReadLine();
        Console.WriteLine("Please enter your second operand.");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if(op == "+")
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        else if(op == "-")
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        else if (op == "*")
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }
        else if (op == "/")
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
        else if (op == "%")
        {
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        }
        else
        {
            Console.WriteLine("Invalid Operator");
        }

        Console.WriteLine("Type 'esc' to quit or 'continue' to do another operation");
        input = Console.ReadLine();


    } while (input != "esc");

    Thread.Sleep(TimeSpan.FromSeconds(3));
}

