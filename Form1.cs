namespace puissance_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoIA.Checked)
            {
                imageIA.Visible = true; // Afficher l'image si le bouton radio est coch�
                imageJ2.Visible = false; // Masquer l'image si le bouton radio est coch�
            }
            else
            {
                imageIA.Visible = false; // Masquer l'image si le bouton radio est d�coch�
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdoJ2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJ2.Checked)
            {
                imageJ2.Visible = true; // Afficher l'image si le bouton radio est coch�
                imageIA.Visible = false; // Masquer l'image si le bouton radio est coch�
            }
            else
            {
                imageJ2.Visible = false; // Masquer l'image si le bouton radio est d�coch�
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJ2J.Checked)
            {
                rdoJ1R.Checked = true;
                pnlJ1.BackColor = Color.Red;
                pnlJ2.BackColor = Color.Gold;
            }
        }

        private void rdoJ1J_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoJ1J.Checked)
            {
                rdoJ2R.Checked= true;
                pnlJ1.BackColor= Color.Gold;
                pnlJ2.BackColor = Color.Red;
            }
        }

        private void rdoJ1R_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJ1R.Checked)
            {
                rdoJ2J.Checked = true;
                pnlJ1.BackColor = Color.Red;
                pnlJ2.BackColor = Color.Gold;
            }
        }

        private void rdoJ2R_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJ2R.Checked)
            {
                rdoJ1J.Checked = true;
                pnlJ1.BackColor = Color.Gold;
                pnlJ2.BackColor = Color.Red;
            }
        }

        private void imageIA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // Cacher la fen�tre actuelle
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}