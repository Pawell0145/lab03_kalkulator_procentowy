namespace lab03_kalk_proc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Kalkulator procentowy";
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //blokada zmiany wilkoœci okna
            this.MaximizeBox = false;                           //blok maksymalizacji
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDish.DisplayMember = "Value";
            comboBoxDish.ValueMember = "Key";

            comboBoxDish.Items.Clear();

            comboBoxDish.Items.Add(new KeyValuePair<int, string>(250, "szklanka (250ml)"));
            comboBoxDish.Items.Add(new KeyValuePair<int, string>(40, "kieliszek (40ml)"));

            comboBoxDish.SelectedIndex = 0;

            comboBoxSubst.DisplayMember = "Value";
            comboBoxSubst.ValueMember = "Key";

            comboBoxSubst.Items.Clear();

            comboBoxSubst.Items.Add(new KeyValuePair<int, string>(5, "piwo (5%)"));
            comboBoxSubst.Items.Add(new KeyValuePair<int, string>(40, "wódka (40%)"));

            comboBoxSubst.SelectedIndex = 0;

            UpdateVolumes();
        }

        int selectedValueNaczynie => comboBoxDish.SelectedItem is KeyValuePair<int, string> kvp ? kvp.Key : 0;
        int selectedValueProcent => comboBoxSubst.SelectedItem is KeyValuePair<int, string> kvp ? kvp.Key : 0;

        private void UpdateVolumes()
        {
            try
            {
                // Jeœli kontrolki to NumericUpDown — u¿ywamy Value (bez problemów z kultur¹)
                double vol = double.Parse(txtBoxVol.Text);
                double percent = double.Parse(txtBoxPerc.Text);
                int count = int.Parse(domainUpDownNumb.Text);

                var input = new user_input(vol, percent, count);

                // Sformatuj wedle potrzeby, tu domyœlne ToString()
                totalVolume.Text = input.Subst_sum().ToString();
                subVolume.Text = input.Clean_subst_vol().ToString();
            }
            catch (Exception)
            {
                // W razie b³êdu zachowaj puste/0 i (opcjonalnie) zaloguj/wyœwietl info podczas debugowania
                totalVolume.Text = string.Empty;
                subVolume.Text = string.Empty;
            }
        }


        private void clear_Click_1(object sender, EventArgs e)
        {
            txtBoxVol.Clear();
            txtBoxPerc.Clear();
            domainUpDownNumb.ResetText();
        }

        private void submit_Click_1(object sender, EventArgs e)
        {
            UpdateVolumes();
        }

        private void comboBoxDish_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtBoxVol.Text = selectedValueNaczynie.ToString();
        }

        private void comboBoxSubst_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtBoxPerc.Text = selectedValueProcent.ToString();
        }
    }
}

