using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempGraMemory
{
    public class GameSettings
    {
        public int AktualnePunkty;
        public int MaxePunkty;
        public int CzasGry;
        public int CzasPodgladu;
        public int Wiersze;
        public int Kolumny;
        public int Bok;
        public int Margines;

        public string PlikLogo = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\logo.jpg";
        public string FolderObrazki = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\memory";

        public GameSettings()
        {
            UstawieniaStartowe();
        }

        public void UstawieniaStartowe()
        {
            AktualnePunkty = 0;
            CzasGry = 60;
            CzasPodgladu = 5;
            Wiersze = 4;
            Kolumny = 6;
            Bok = 150;
            Margines = 2;
            MaxePunkty = 12;
        }
    }
}
