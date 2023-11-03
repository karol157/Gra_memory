using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempGraMemory
{
    public partial class MemoryFrom : Form
    {
        private GameSettings ustawienia;


        MemoryCard _pierwsza = null;
        MemoryCard _drugi = null;


        public MemoryFrom()
        {
            InitializeComponent();
            ustawienia = new GameSettings();

            UstawKontrolki();
            GenerujKLarty();
            timerCzasPodgladu.Start();
        }
        private void UstawKontrolki()
        {
            lblCzasWartosc.Text = ustawienia.CzasGry.ToString();
            lblPunktyWartosc.Text = ustawienia.AktualnePunkty.ToString();
            lblStartInfo.Text = $"Gra zacznie sie za: {ustawienia.CzasPodgladu} sekund";

            lblStartInfo.Visible = true;

            panelKart.Width = ustawienia.Kolumny * ustawienia.Bok
                            + ustawienia.Margines * (ustawienia.Kolumny - 1);
            panelKart.Height = ustawienia.Wiersze * ustawienia.Bok
                            + ustawienia.Margines * (ustawienia.Wiersze - 1);

            Width = panelKart.Width + 40;
            Height = panelKart.Height + 100;




        }
        private void GenerujKLarty()
        {
            List<MemoryCard> memoryCards = new List<MemoryCard>();
            string[] pathsObrazki = Directory.GetFiles(ustawienia.FolderObrazki);
            


            foreach (var img in pathsObrazki)
            {
                Guid id = Guid.NewGuid();
                MemoryCard b1 = new MemoryCard(id, ustawienia.PlikLogo, img);
                memoryCards.Add(b1);

                MemoryCard b2 = new MemoryCard(id, ustawienia.PlikLogo, img);
                memoryCards.Add(b2);
            }

            Random random = new Random();

            panelKart.Controls.Clear();

            for (int x = 0; x < ustawienia.Kolumny; x++)
            {
                for (int y = 0; y < ustawienia.Wiersze; y++)
                {

                    int index = random.Next(0, memoryCards.Count);

                    MemoryCard obecnaGenerowana = memoryCards[index];
                    obecnaGenerowana.Location = new Point((x * ustawienia.Bok), (y * ustawienia.Bok));

                    obecnaGenerowana.Width = ustawienia.Bok;
                    obecnaGenerowana.Height = ustawienia.Bok;

                    obecnaGenerowana.Otworz();

                    obecnaGenerowana.Click += BtnClicked;

                    panelKart.Controls.Add(obecnaGenerowana);
                    memoryCards.Remove(obecnaGenerowana);



                }
            }

        }

        private void timerCzasPodgladu_Tick(object sender, EventArgs e)
        {
            ustawienia.CzasPodgladu--;

            lblStartInfo.Text = $"Początek gry za {ustawienia.CzasPodgladu}.";

            if (ustawienia.CzasPodgladu <= 0)
            {
                lblStartInfo.Visible = false;

                foreach (Control kontrolka in panelKart.Controls)
                {
                    MemoryCard card = (MemoryCard)kontrolka;
                    card.Zakryj();
                }

                timerCzasPodgladu.Stop();

                timerCzasGry.Start();
            }
        }

        private void BtnClicked(object sender, EventArgs e)
        {
            MemoryCard btn = (MemoryCard)sender;

            if (_pierwsza == null)
            {
                _pierwsza = btn;
                _pierwsza.Otworz();
             }
            else
            {
                _drugi = btn;
                _drugi.Otworz();

                panelKart.Enabled = false;

                if (_pierwsza.Id == _drugi.Id)
                {
                    ustawienia.AktualnePunkty++;
                    lblPunktyWartosc.Text = ustawienia.AktualnePunkty.ToString();

                    _pierwsza = null;
                    _drugi = null;

                    panelKart.Enabled = true;                   
                }
                else
                {
                    timerZakrywacz.Start();
                }
            }
        }

        private void timerZakrywacz_Tick(object sender, EventArgs e)
        {
            _pierwsza.Zakryj();
            _drugi.Zakryj();

            _pierwsza = null;
            _drugi = null;

            panelKart.Enabled = true;

            timerZakrywacz.Stop();
        }

        private void timerCzasGry_Tick(object sender, EventArgs e)
        {
            ustawienia.CzasGry--;
            lblCzasWartosc.Text = ustawienia.CzasGry.ToString();

            if (ustawienia.CzasGry <= 0 || ustawienia.AktualnePunkty == ustawienia.MaxePunkty)
            {
                timerCzasGry.Stop();
                timerZakrywacz.Stop();

                DialogResult yesNo = MessageBox.Show($"Zdobyte punkty: {ustawienia.AktualnePunkty}. Grasz ponownie?", "Koniec Gry", MessageBoxButtons.YesNo);

                if (yesNo == DialogResult.Yes)
                {
                    ustawienia.UstawieniaStartowe();
                    GenerujKLarty();
                    UstawKontrolki();

                    panelKart.Enabled = true;
                    _pierwsza = null;
                    _drugi = null;

                    timerCzasPodgladu.Start();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
    }

