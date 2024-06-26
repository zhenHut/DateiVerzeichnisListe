namespace DateiVerzeichnisListe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnDateiListe = new Button();
            BtnSystemeinträge = new Button();
            BtnInVerzeichnis = new Button();
            BtnNachOben = new Button();
            LblAnzeigeAktuell = new Label();
            LboxAnzeige = new ListBox();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // BtnDateiListe
            // 
            BtnDateiListe.Location = new Point(40, 51);
            BtnDateiListe.Name = "BtnDateiListe";
            BtnDateiListe.Size = new Size(75, 23);
            BtnDateiListe.TabIndex = 0;
            BtnDateiListe.Text = "Dateiliste";
            BtnDateiListe.UseVisualStyleBackColor = true;
            BtnDateiListe.Click += BtnDateiListe_Click;
            // 
            // BtnSystemeinträge
            // 
            BtnSystemeinträge.Location = new Point(168, 51);
            BtnSystemeinträge.Name = "BtnSystemeinträge";
            BtnSystemeinträge.Size = new Size(103, 23);
            BtnSystemeinträge.TabIndex = 1;
            BtnSystemeinträge.Text = "Systemeinträge";
            BtnSystemeinträge.UseVisualStyleBackColor = true;
            BtnSystemeinträge.Click += BtnSystemeinträge_Click;
            // 
            // BtnInVerzeichnis
            // 
            BtnInVerzeichnis.Location = new Point(300, 51);
            BtnInVerzeichnis.Name = "BtnInVerzeichnis";
            BtnInVerzeichnis.Size = new Size(95, 23);
            BtnInVerzeichnis.TabIndex = 2;
            BtnInVerzeichnis.Text = "in Verzeichnis";
            BtnInVerzeichnis.UseVisualStyleBackColor = true;
            BtnInVerzeichnis.Click += BtnInVerzeichnis_Click;
            // 
            // BtnNachOben
            // 
            BtnNachOben.Location = new Point(433, 51);
            BtnNachOben.Name = "BtnNachOben";
            BtnNachOben.Size = new Size(75, 23);
            BtnNachOben.TabIndex = 3;
            BtnNachOben.Text = "nach Oben";
            BtnNachOben.UseVisualStyleBackColor = true;
            BtnNachOben.Click += BtnNachOben_Click;
            // 
            // LblAnzeigeAktuell
            // 
            LblAnzeigeAktuell.AutoSize = true;
            LblAnzeigeAktuell.Location = new Point(45, 86);
            LblAnzeigeAktuell.Name = "LblAnzeigeAktuell";
            LblAnzeigeAktuell.Size = new Size(0, 15);
            LblAnzeigeAktuell.TabIndex = 5;
            // 
            // LboxAnzeige
            // 
            LboxAnzeige.FormattingEnabled = true;
            LboxAnzeige.ItemHeight = 15;
            LboxAnzeige.Location = new Point(40, 110);
            LboxAnzeige.Name = "LboxAnzeige";
            LboxAnzeige.Size = new Size(538, 274);
            LboxAnzeige.TabIndex = 6;
            LboxAnzeige.SelectedIndexChanged += LboxAnzeige_SelectedIndexChanged;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(42, 420);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(0, 15);
            LblAnzeige.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 534);
            Controls.Add(LblAnzeige);
            Controls.Add(LboxAnzeige);
            Controls.Add(LblAnzeigeAktuell);
            Controls.Add(BtnNachOben);
            Controls.Add(BtnInVerzeichnis);
            Controls.Add(BtnSystemeinträge);
            Controls.Add(BtnDateiListe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDateiListe;
        private Button BtnSystemeinträge;
        private Button BtnInVerzeichnis;
        private Button BtnNachOben;
        private Label LblAnzeigeAktuell;
        private ListBox LboxAnzeige;
        private Label LblAnzeige;
    }
}
