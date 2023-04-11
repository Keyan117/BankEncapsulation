namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var KeyanAccount = new BankAccount();
            
            Console.WriteLine("How much would you like to deposit?");
            
            var amountToDeposit = double.Parse(Console.ReadLine()); 
 
            KeyanAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {KeyanAccount.GetBalance()}");
        }
    }
}
