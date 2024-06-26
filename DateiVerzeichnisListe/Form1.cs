namespace DateiVerzeichnisListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // hier ein Pfad einfügen zb. C:\Users\Username\Documents
            string verz = @"";
            if (Directory.Exists(verz))
            {
                Directory.SetCurrentDirectory(verz);

            }
            else
                MessageBox.Show($"Verzeichnis {verz} existiert nicht");

            LblAnzeigeAktuell.Text = Directory.GetCurrentDirectory();
        }

        private void BtnDateiListe_Click(object sender, EventArgs e)
        {
            string verz = Directory.GetCurrentDirectory();
            string[] dateiliste = Directory.GetFiles(verz);
            LboxAnzeige.Items.Clear();
            foreach (string s in dateiliste)
            {
                LboxAnzeige.Items.Add(s);
            }
        }

        private void BtnSystemeinträge_Click(object sender, EventArgs e)
        {
            Systemeintraege();
        }

        private void BtnInVerzeichnis_Click(object sender, EventArgs e)
        {
            if (LboxAnzeige.SelectedIndex != -1)
            {
                try
                {
                    Directory.SetCurrentDirectory(LboxAnzeige.Text);
                }
                catch
                {
                    MessageBox.Show($"{LboxAnzeige.Text} ist kein Verzeichnis");
                }
            }
            else 
            {
                MessageBox.Show("Kein Eintrag ausgewählt");
            }

            LblAnzeige.Text = Directory.GetCurrentDirectory();
            Systemeintraege();
        }

        private void BtnNachOben_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("..");
            LblAnzeige.Text = Directory.GetCurrentDirectory();
            Systemeintraege();
        }

        private void Systemeintraege()
        {
            string verz = Directory.GetCurrentDirectory();
            string[] dateiliste = Directory.GetFileSystemEntries(verz);
            LboxAnzeige.Items.Clear();
            foreach (string s in dateiliste)
                LboxAnzeige.Items.Add(s);
        }

        private void LboxAnzeige_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LboxAnzeige.SelectedIndex != -1)
            {
                string name = LboxAnzeige.Text;
                LblAnzeige.Text = $"{name}\n"
                    + $"Erzeugt: {File.GetCreationTime(name)}\n"
                    + $"Letzter Zugriff: {File.GetLastAccessTime(name)}\n"
                    + $"Letzter Schreibzugriff: {File.GetLastWriteTime(name)}";
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");
        }
    }
}
