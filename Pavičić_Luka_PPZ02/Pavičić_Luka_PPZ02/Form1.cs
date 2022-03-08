using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pavičić_Luka_PPZ02
{
    public partial class Form1 : Form
    {
        List<Gazirano> listagaziranog = new List<Gazirano>();
        List<Negazirano> listanegaziranog = new List<Negazirano>();
        List<Alkoholno> listaalkoholnog = new List<Alkoholno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpis_Click(object sender, EventArgs e)
        {
            if (rbtnGazirana.Checked == true)
            {
                Gazirano gazirano = new Gazirano(txtNaziv.Text, cmbPakiranje.Text, cmbKolicina.Text, txtCijena.Text);
                listagaziranog.Add(gazirano);
                MessageBox.Show("Uspješan unos gaziranog pića", "Piće", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (rbtNegazirana.Checked == true)
            {
                Negazirano negazirano = new Negazirano(txtNaziv.Text, cmbPakiranje.Text, cmbKolicina.Text, txtCijena.Text);
                listanegaziranog.Add(negazirano);
                MessageBox.Show("Uspješan unos negaziranog pića", "Piće", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (rbtAlkoholna.Checked == true)
            {
                Alkoholno alkoholno = new Alkoholno(txtNaziv.Text, cmbPakiranje.Text, cmbKolicina.Text, txtCijena.Text, trckAlc.Value);
                listaalkoholnog.Add(alkoholno);
                MessageBox.Show("Uspješan unos alkoholnog pića", "Piće", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnIspis_Click(object sender, EventArgs e)
        {

            if (rbtnGazirana.Checked == true)
            {
                rtbIspis.Clear();
                foreach (Gazirano gazirano in listagaziranog)
                {
                    rtbIspis.AppendText(gazirano.ToString());
                }
            }

            if (rbtNegazirana.Checked == true)
            {
                rtbIspis.Clear();
                foreach (Negazirano negazirano in listanegaziranog)
                {
                    rtbIspis.AppendText(negazirano.ToString());
                }
            }

            if (rbtAlkoholna.Checked == true)
            {
                rtbIspis.Clear();
                foreach (Alkoholno alkoholno in listaalkoholnog)
                {
                    rtbIspis.AppendText(alkoholno.ToString());
                }
            }




        }
    }
}
