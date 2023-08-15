// See https://aka.ms/new-console-template for more information
Console.Title = "Bank of system";
string name1, name2;
int pass1, pass2, i, balance, valu;
i = 1;
valu = 1 | 2 | 3 | 4 | 5;
balance = 0;
z:
Console.WriteLine("Enter your name");
name1 = Console.ReadLine();
Console.WriteLine("Enter your password");
pass1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your name agin");
name2 = Console.ReadLine();
Console.WriteLine("Enter your password agin");
pass2 = Convert.ToInt32(Console.ReadLine());

if ((name1 == name2) & (pass1 == pass2))
{
    Console.WriteLine($" Hellow, Welcom {name1} in the bank system\n");
ret:
    Console.WriteLine("To know your balance, click 1");
    Console.WriteLine("To withdraw an amount from your balance, click 2");
    Console.WriteLine("To transfer an amount of your balance, click 3");
    Console.WriteLine("Deposit an amount in your account, click 4");
    Console.WriteLine("To get out of the program, click 5");
    valu = int.Parse(Console.ReadLine());
    if (valu == 1)
    {
        Console.WriteLine($"balance is  {balance}\n");
        goto ret;
    }
    else if (valu == 2)
    {
        Console.WriteLine("Enter the amount");
        int withdraw = int.Parse(Console.ReadLine());
        if (withdraw <= balance)
        {
            Console.WriteLine("Ok, operation accomplished successfully");
            Console.WriteLine($"An amount has been withdrawn    {withdraw}");
            balance = balance - withdraw;
            Console.WriteLine($"Balance is   {balance}");
        }
        else
            Console.WriteLine("Your balance is not enough");
        Console.WriteLine("\n");
        goto ret;
    }
    else if (valu == 3)
    {
        Console.WriteLine("Enter the amount");
        int transfer = int.Parse(Console.ReadLine());
        if (transfer <= balance)
        {
            Console.WriteLine("Enter the recipient's name");
            string recipient = Console.ReadLine();
            Console.WriteLine("Ok, operation accomplished successfully");
            Console.WriteLine($"An amount has been transferrd {transfer} to {recipient}");
            balance = balance - transfer;
            Console.WriteLine($"Balance is   {balance}");
        }
        else
            Console.WriteLine("Your balance is not enough");
        Console.WriteLine("\n");
        goto ret;
    }
    else if (valu == 4)
    {
        Console.WriteLine("Enter the amount");
        int depos = int.Parse(Console.ReadLine());
        balance = depos + balance;
        Console.WriteLine("Ok, operation accomplished successfully");
        Console.WriteLine($"Balance is   {balance}\n");
        goto ret;
    }
    else
        return;
}
else if (i < 3)
{
    Console.WriteLine("error, name and bassword not same");
    i++;
    goto z;
}
else
    Console.WriteLine("error    error   error   error");
Console.ReadKey();

