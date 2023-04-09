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
                imageIA.Visible = true; // Afficher l'image si le bouton radio est coché
                imageJ2.Visible = false; // Masquer l'image si le bouton radio est coché
            }
            else
            {
                imageIA.Visible = false; // Masquer l'image si le bouton radio est décoché
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdoJ2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJ2.Checked)
            {
                imageJ2.Visible = true; // Afficher l'image si le bouton radio est coché
                imageIA.Visible = false; // Masquer l'image si le bouton radio est coché
            }
            else
            {
                imageJ2.Visible = false; // Masquer l'image si le bouton radio est décoché
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
    }
}