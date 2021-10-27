namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SoulMaster master = new SoulMaster("Kicata", 80);

            System.Console.WriteLine(master.ToString());
        }
    }
}