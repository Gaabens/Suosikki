namespace Suosikki
{
    public partial class SuosikkiForm : Form
    {
        public SuosikkiForm()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("c:\\Users\\gabriel.savinen\\OneDrive - Keski-Uudenmaan koulutuskuntayhtymä\\Harjoitukset\\Suosikki\\pojat.txt");
            string[] tytot = File.ReadAllLines("c:\\Users\\gabriel.savinen\\OneDrive - Keski-Uudenmaan koulutuskuntayhtymä\\Harjoitukset\\Suosikki\\tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1, laskurit = 1;

            foreach (string poika in pojat)

            {
                if (nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + " . suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }

                laskurip++;
            }

            foreach (string tytto in tytot)

            {
                if (nimi == tytto)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + " . suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }

                laskurit++;
            }

            if (VastausLB.Visible == false) 
            
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta! :( ";
                VastausLB.Visible = true;
            }
        }

    }

}
