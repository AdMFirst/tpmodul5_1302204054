namespace com.kpl.tp.modul5
{
    using System.Diagnostics.Contracts;
    
    public class SayaTubeVideo
    {
        protected int id;
        protected string title;
        protected int playCount;

        
        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null, "input null!");
            Contract.Requires(title.Length <= 100, "input terlalu panjang!");

            Random random = new();
            this.id = random.Next(99999);
            this.title = title;
            this.playCount = 0;
        }

        public void increasePlayCount(int number)
        {
            Contract.Requires(number <= 10000000, "input terlalu besar!");
            try
            {
                checked
                {
                    this.playCount += number;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID\t\t:"+this.id.ToString());
            Console.WriteLine("Title\t\t:"+this.title);
            Console.WriteLine("Play Count\t:" + this.playCount.ToString());
        }
    }

    public class main
    {
        public static void Main()
        {
            //test contract 1, title must not null
            SayaTubeVideo test = new(null);
            test.printVideoDetails();

            //test contract 2, title must be less than 100 char
            SayaTubeVideo baru = new("123456789012345678901234567890123456789012345678901234567890" +
                "12345678901234567890123456789012345678901234567890123456789012345678901234567890");
            baru.printVideoDetails();

            SayaTubeVideo saya = new("Tutorial Design By Contract – Aditya Mardi Pratama.");
            saya.printVideoDetails();

            //test overflow prevention
            for (int i = 0; i < 4; i++)
            {
                saya.increasePlayCount(536870912);
            }
            saya.printVideoDetails();
        }
    }
}
