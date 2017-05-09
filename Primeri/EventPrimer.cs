using System;

namespace konzolniPrimeri
{
    class EventPrimer
    {
        
        public delegate void SretanRodjendanDelegat(object sender, EventArgs e);    //deklaracija događaja 
        public event SretanRodjendanDelegat EventSretanRodjendan;
        //ovo je standardni oblik deklariranja Event-a ,dakle navođenje delegata
        // i davanje imena našem event-u
        private string ime;
        private string prezime;
        private DateTime datum;
        public DateTime Datum
        {
            get { return datum; }

            set     //ovdje "podižemo događaj" 
            {
                datum = value;
                if (datum.ToString("dd MM") == DateTime.Now.ToString("dd MM"))
                {
                    if (EventSretanRodjendan != null)
                    {
                        EventSretanRodjendan(this, new EventArgs());
                    }
                }
            }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string IspisImePrezime()//ovu metodu možemo i preklopiti s metodom ToString() 
        {
            return this.Ime + " " + Prezime;
        }
    }
    class EventGlavni
    {
        static void Main(string[] args)
        {
            EventPrimer slavljenik = new EventPrimer();
            Console.WriteLine("Upišite ime : ");
            slavljenik.Ime = Console.ReadLine();
            Console.WriteLine("Upišite prezime : ");
            slavljenik.Prezime = Console.ReadLine();
            Console.WriteLine("Upišite datum : ");
            slavljenik.EventSretanRodjendan +=new EventPrimer.SretanRodjendanDelegat(Slavljenik);//ovdje implementiramo događaj
            try
            {
                slavljenik.Datum = DateTime.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška pri unosu ->{0}", ex.Message);
            }
            slavljenik.EventSretanRodjendan -=
               new EventPrimer.SretanRodjendanDelegat(Slavljenik);
            Console.WriteLine();//ispisuje se samo pozdrav ako ne slavite
                                //ako slavite ->sve se ispisuje  
            Console.WriteLine("Pozdrav , {0}", slavljenik.IspisImePrezime());
           // Console.ReadKey();
        }
        //ovo je metoda koja je u sastavu delegata koja se poziva 
        //na temelju event-a
        static void Slavljenik(object sender, EventArgs e)
        {
            Console.WriteLine("Sretan rođendan Vama prije pozdrava{0}",
                ((EventPrimer)sender).IspisImePrezime());
        }
    }
}
