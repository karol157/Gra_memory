using System;

namespace MemoryGame
{

    // klasa przechowująca wszystkie ustawienia gry
    public class GameSettings
    {
        // ustawienia gry
        public int CzasGry;
        public int CzasPodgladu;
        public int MaxPunkty;
        public int Wiersze;
        public int Kolumny;
        public int Bok;
        public int Margines;
        public int AktualnePunkty;

        public string PlikLogo = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\logo.jpg";
        public string FolderObrazki = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\memory";


        public GameSettings()
        {
            UstawStartowe();
        }

        // metoda ustawiająca parametry startowe gry
        public void UstawStartowe()
        {
            CzasPodgladu = 5;
            CzasGry = 60;
            MaxPunkty = 0;
            // 4 wiersze x 6 kolumn = 24 karty, czyli wymagane jest,
            // aby w folderze z obrazkami było 12 różnych grafik
            // można zamienić wartości - warto pokazać, że dzięki dynamicznego
            // generowaniu planszy wszystko zadziała
            Wiersze = 4;
            Kolumny = 6;
            Bok = 150;
            Margines = 2;
            AktualnePunkty = 0;
        }
    }
}
