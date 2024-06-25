namespace Console_Ekranı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kisiler ks = new kisiler();
            string ads;
            string meslegi;
            Console.Write("Ad Soyad ve MesleğiniziGiriniz Lütfen : ");
            ads = Console.ReadLine();
            meslegi = Console.ReadLine();
            ks.kisilistesi(ads, meslegi);
            Console.Read();

        }
    }
}