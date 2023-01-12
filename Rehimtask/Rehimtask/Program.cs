namespace Rehimtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reshadnan Aydanin derecesi
            Console.WriteLine("Reshadin ardicilliqla shahmat, atletika ve taekvanto ballarini girin!");
            int shahResh = Convert.ToInt32(Console.ReadLine());
            int atletResh = Convert.ToInt32(Console.ReadLine());
            int taekResh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aydan ardicilliqla shahmat, atletika ve taekvanto ballarini girin!");
            int shahAydan = Convert.ToInt32(Console.ReadLine());
            int atletAydan = Convert.ToInt32(Console.ReadLine());
            int taekAydan = Convert.ToInt32(Console.ReadLine());
            int Reshadderece = 0;
            int Aydanderece = 0;
            if (shahResh>shahAydan)
            {
                Reshadderece++;
            }

            else
            {
                Aydanderece++;
            }
            if (atletResh>shahAydan )
            {
                Reshadderece++;
            }
            else
            {
                Aydanderece++;
            }
            if (taekResh>taekAydan)
            {
                Reshadderece++;
            }
            else
            {
                Aydanderece++;
            }
            Console.WriteLine($"Reshadin derecesi: {Reshadderece}");
            Console.WriteLine($"Aydanin derecesi: {Aydanderece}");


        }
    }
}