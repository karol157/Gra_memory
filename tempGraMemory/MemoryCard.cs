using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms.VisualStyles;

namespace tempGraMemory
{
    public class MemoryCard : Label
    {

        public Guid Id;
        public Image Tyl;
        public Image Obrazek;

        public MemoryCard(Guid Id, string pathTyl, string pathObrazek)
        {
            this.Id = Id;
            this.Tyl = Image.FromFile(pathTyl);
            this.Obrazek = Image.FromFile(pathObrazek);
            BackgroundImageLayout = ImageLayout.Stretch;

        }
        public void Zakryj()
        {
            BackgroundImage = Tyl;
            Enabled = true;
        }       
        public void Otworz()
        {
            BackgroundImage = Obrazek;
            Enabled = false;
        }


    }
}
