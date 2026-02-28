
public class throwkeyword
{
    public static void Main(String[] args)
    {
        Console.WriteLine("enter an amount");
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            Console.WriteLine("amount withdraw successfully");
        }
        else
        {
            throw new InvalidAmountException("Please enter valid amount");
        }
    }

}
