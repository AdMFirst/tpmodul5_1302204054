namespace com.kpl.tp.modul5
{
    
    public class SayaTubeVideo
    {
        protected int id;
        protected string title;
        protected int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new();
            this.id = random.Next(99999);
            this.title = title;
            this.playCount = 0;
        }

        public void increasePlayCount(int number)
        {
            this.playCount += number;
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
            SayaTubeVideo saya = new("Tutorial Design By Contract – Aditya Mardi Pratama.");
            saya.printVideoDetails();
            saya.increasePlayCount(1);
            saya.printVideoDetails();
        }
    }
}
