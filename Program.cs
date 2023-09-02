internal class Program
{
    public static void Main(string[] args)
    {
        int x=9;
        int y=15;
        Console.WriteLine(x+y);

        int sonuc=Topla(x,y);
        Console.WriteLine(sonuc);

        int sonuc2=ArttirveTopla(x,y);
        EkranaYazdir(Convert.ToString(sonuc2));
        EkranaYazdir(Convert.ToString(x+y));
    }

    public static int Topla(int deger1, int deger2)
    {
        return deger1 + deger2;
    }

    public static void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public static int ArttirveTopla(int deger1, int deger2)
    {
        deger1 += 1;
        deger2 +=1;
        return deger1+deger2;
    }
}