namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wish;
            int wishFulfillmentDay;
            Console.Write("Каково будет ваше желание: ");
            wish = Console.ReadLine();
            Console.Write("Через сколько дней вы хотите, что-бы желание было исполнено: ");
            wishFulfillmentDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше желание - " + wish + ", будет исполнено через - " + wishFulfillmentDay + " дней.");
        }
    }
}