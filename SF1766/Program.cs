// See https://aka.ms/new-console-template for more information
using SF1766;

class Program
{
    public static void Main()
    {
        var acc = new Account () {Type = "general", Balance = 5000};
        switch (acc.Type)
        {
            case "general":
            acc.GetInterest(new GeneralAccountCalculateInterest());
                Console.WriteLine("The interest is {0}", acc.Interest); 
                break;
            case "salary":
                acc.GetInterest(new SalaryAccountCalculateInterest());
                Console.WriteLine("The interest is {0}", acc.Interest);
                break;
            default:
                Console.WriteLine("Incorrect type of the account");
                break;
        }
        Console.ReadLine();

    }
}