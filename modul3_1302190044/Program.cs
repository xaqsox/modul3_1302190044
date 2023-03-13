enum buah
{
    Apel,
    Aprikot,
    Alpukat,
    Pisang,
    Paprika,
    Blackberry,
    Ceri,
    Kelapa,
    Jagung
}

class KodeBuah
{
    public string getKdBuah { get; set;  }
    public buah isibuah { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        KodeBuah Buahx = new KodeBuah
        {
            getKdBuah = "A00",
            isibuah = buah.Apel
        };
        KodeBuah Buahy = new KodeBuah
        {
            getKdBuah = "B00",
            isibuah = buah.Aprikot
        };
        KodeBuah Buahz = new KodeBuah
        {
             getKdBuah = "C00",
             isibuah = buah.Alpukat
        };
        KodeBuah Buahxz = new KodeBuah
        {
            getKdBuah = "D00",
            isibuah = buah.Blackberry
        };
        KodeBuah Buahyz = new KodeBuah
        {
            getKdBuah = "E00",
            isibuah = buah.Ceri
        };
        KodeBuah Buahzz = new KodeBuah
        {
            getKdBuah = "F00",
            isibuah = buah.Kelapa
        };
        KodeBuah Buah1 = new KodeBuah
        {
            getKdBuah = "H00",
            isibuah = buah.Jagung
        };
        KodeBuah Buah2 = new KodeBuah
        {
            getKdBuah = "I00",
            isibuah = buah.Pisang
        };

        Console.WriteLine(Buahx.getKdBuah + "||" + Buahx.isibuah);
        Console.WriteLine(Buahy.getKdBuah + "||" + Buahy.isibuah);
        Console.WriteLine(Buahz.getKdBuah + "||" + Buahz.isibuah);
        Console.WriteLine(Buahxz.getKdBuah + "||" + Buahxz.isibuah);
        Console.WriteLine(Buahyz.getKdBuah + "||" + Buahyz.isibuah);
        Console.WriteLine(Buahzz.getKdBuah + "||" + Buahzz.isibuah);
        Console.WriteLine(Buah1.getKdBuah + "||" + Buah1.isibuah);
        Console.WriteLine(Buah2.getKdBuah + "||" + Buah2.isibuah);

    }
}