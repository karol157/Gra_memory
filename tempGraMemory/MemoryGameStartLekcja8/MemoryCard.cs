using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
   public class MemoryCard : Label
   {
      public Guid Id;
      public Image Tyl;
      public Image Obrazek;

      public MemoryCard(Guid id, string tylPath, string obrazekPath)
      {
         Id = id;
         Tyl = Image.FromFile(tylPath);
         Obrazek = Image.FromFile(obrazekPath);
         BackgroundImageLayout = ImageLayout.Stretch;
      }

      // metoda ukrywa grafikę (ustawia logo) i wyłącza kartę
      public void Zakryj()
      {
         BackgroundImage = Tyl;
         Enabled = true;
      }

      // metoda odkrywa grafikę (ustawia obrazek) i włącza kartę
      public void Odkryj()
      {
         BackgroundImage = Obrazek;
         Enabled = false;
      }
   }
}
