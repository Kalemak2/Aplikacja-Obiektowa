namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Jan", "Kowalski", "14.07.1997");
            Osoba student = new Student("Krystian", "Nowak", "21.02.2004", 2, 5, 252355);
            Osoba pilkarz = new Pilkarz("Robert", "Lewandowski", "21.08.1988", "napastnik", "FC Barcelona");

            osoba.WypiszInfo();
            student.WypiszInfo();
            pilkarz.WypiszInfo();

            Student student2 = new Student("Jan", "Kaczyński", "15.08.2003", 2, 1, 212542);
            Pilkarz pilkarz2 = new Pilkarz("Wojciech", "Szczęsny", "18.04.1990", "bramkarz", "FC Barcelona");

            student2.WypiszInfo();
            pilkarz2.WypiszInfo();

            ((Pilkarz)pilkarz).StrzelGola();
            pilkarz2.StrzelGola();
            pilkarz2.StrzelGola();

            pilkarz.WypiszInfo();
            pilkarz2.WypiszInfo();

            Console.ReadKey();
        }

    }

    class Osoba
    {
        protected string imie { get; set; }
        protected string nazwisko { get; set; }
        protected string dataUrodzenia { get; set; }

        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine($"Imię: {imie}, Nazwisko: {nazwisko}, Data urodzenia: {dataUrodzenia}");
        }
    }

    class Student : Osoba
    {
        private int rok { get; set; }
        private int grupa { get; set; }
        private int nrIndeksu { get; set; }

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu)
       : base(imie, nazwisko, dataUrodzenia)
        {
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Rok: {rok}, Grupa: {grupa}, Nr indeksu: {nrIndeksu}");
        }
    }

    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
            : base(imie, nazwisko, dataUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Pozycja: {pozycja}, Klub: {klub}, Liczba goli: {liczbaGoli}");
        }

        public void StrzelGola()
        {
            liczbaGoli++;
            Console.WriteLine($"{imie} {nazwisko} strzelił gola! Łączna liczba goli: {liczbaGoli}");
        }

    }
}