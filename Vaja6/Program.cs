using System.IO;

namespace vaja6 {

  
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
        public int id; //Naredi javni int, ki bo bil shranjen kot id.
        public string u_ime; //Javni string, ki bo shranjen za up. ime.
        public string u_geslo; //javni string, ki bo shranjen za up. geslo.
        public static int stIg = 1; // Javni int, ki je zadolzen za štetje igralcev.

        public Igralec(string ime, string geslo)
        {
            u_ime = ime.Trim();
            u_geslo = geslo.Trim();
            id = stIg;
            stIg++;
        }

        // Kopirni konstruktor
        public Igralec(Igralec drugi)
        {
            this.u_ime = drugi.u_ime;
            this.u_geslo = drugi.u_geslo;
            this.id = stIg; // nov igralec dobi svoj unikaten id
            stIg++;
        }

        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        public int Id {
            get
            {
                return id;
            }
        }

        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
