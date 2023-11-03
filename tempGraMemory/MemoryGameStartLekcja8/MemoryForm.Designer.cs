namespace MemoryGame
{
   partial class MemoryForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            this.timerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.lblCzas = new System.Windows.Forms.Label();
            this.lblCzasWartosc = new System.Windows.Forms.Label();
            this.lblPunkty = new System.Windows.Forms.Label();
            this.lblPunktyWartosc = new System.Windows.Forms.Label();
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.panelKart = new System.Windows.Forms.Panel();
            this.lblStartInfo = new System.Windows.Forms.Label();
            this.timerCzasPodgladu = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerZakrywacz
            // 
            this.timerZakrywacz.Interval = 1000;
            this.timerZakrywacz.Tick += new System.EventHandler(this.timerZakrywacz_Tick);
            // 
            // lblCzas
            // 
            this.lblCzas.AutoSize = true;
            this.lblCzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCzas.ForeColor = System.Drawing.Color.Black;
            this.lblCzas.Location = new System.Drawing.Point(17, 16);
            this.lblCzas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCzas.Name = "lblCzas";
            this.lblCzas.Size = new System.Drawing.Size(64, 25);
            this.lblCzas.TabIndex = 0;
            this.lblCzas.Text = "Czas:";
            // 
            // lblCzasWartosc
            // 
            this.lblCzasWartosc.AutoSize = true;
            this.lblCzasWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCzasWartosc.ForeColor = System.Drawing.Color.Black;
            this.lblCzasWartosc.Location = new System.Drawing.Point(85, 16);
            this.lblCzasWartosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCzasWartosc.Name = "lblCzasWartosc";
            this.lblCzasWartosc.Size = new System.Drawing.Size(36, 25);
            this.lblCzasWartosc.TabIndex = 1;
            this.lblCzasWartosc.Text = "60";
            // 
            // lblPunkty
            // 
            this.lblPunkty.AutoSize = true;
            this.lblPunkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunkty.ForeColor = System.Drawing.Color.Black;
            this.lblPunkty.Location = new System.Drawing.Point(167, 16);
            this.lblPunkty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPunkty.Name = "lblPunkty";
            this.lblPunkty.Size = new System.Drawing.Size(78, 25);
            this.lblPunkty.TabIndex = 2;
            this.lblPunkty.Text = "Punkty:";
            // 
            // lblPunktyWartosc
            // 
            this.lblPunktyWartosc.AutoSize = true;
            this.lblPunktyWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunktyWartosc.ForeColor = System.Drawing.Color.Black;
            this.lblPunktyWartosc.Location = new System.Drawing.Point(241, 16);
            this.lblPunktyWartosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPunktyWartosc.Name = "lblPunktyWartosc";
            this.lblPunktyWartosc.Size = new System.Drawing.Size(24, 25);
            this.lblPunktyWartosc.TabIndex = 3;
            this.lblPunktyWartosc.Text = "0";
            // 
            // timerCzasGry
            // 
            this.timerCzasGry.Interval = 1000;
            this.timerCzasGry.Tick += new System.EventHandler(this.timerCzasGry_Tick);
            // 
            // panelKart
            // 
            this.panelKart.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelKart.Location = new System.Drawing.Point(8, 49);
            this.panelKart.Margin = new System.Windows.Forms.Padding(4);
            this.panelKart.Name = "panelKart";
            this.panelKart.Size = new System.Drawing.Size(772, 25);
            this.panelKart.TabIndex = 4;
            // 
            // lblStartInfo
            // 
            this.lblStartInfo.AutoSize = true;
            this.lblStartInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblStartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartInfo.Location = new System.Drawing.Point(416, 16);
            this.lblStartInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartInfo.Name = "lblStartInfo";
            this.lblStartInfo.Size = new System.Drawing.Size(172, 25);
            this.lblStartInfo.TabIndex = 0;
            this.lblStartInfo.Text = "Początek gry za 5.";
            // 
            // timerCzasPodgladu
            // 
            this.timerCzasPodgladu.Interval = 1000;
            this.timerCzasPodgladu.Tick += new System.EventHandler(this.timerCzasPodgladu_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 89);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStartInfo);
            this.Controls.Add(this.panelKart);
            this.Controls.Add(this.lblPunktyWartosc);
            this.Controls.Add(this.lblPunkty);
            this.Controls.Add(this.lblCzasWartosc);
            this.Controls.Add(this.lblCzas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemoryForm";
            this.Text = "Gra w memory";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Timer timerZakrywacz;
        private System.Windows.Forms.Label lblCzas;
        private System.Windows.Forms.Label lblCzasWartosc;
      private System.Windows.Forms.Label lblPunkty;
      private System.Windows.Forms.Label lblPunktyWartosc;
      private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Panel panelKart;
      private System.Windows.Forms.Label lblStartInfo;
      private System.Windows.Forms.Timer timerCzasPodgladu;
        private System.Windows.Forms.Label label1;
    }
}

