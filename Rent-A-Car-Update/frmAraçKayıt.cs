using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rent_A_Car_Update
{
    public partial class frmAraçKayıt : Form
    {
        Araç_Kiralama arackiralama =new Araç_Kiralama();
        public frmAraçKayıt()
        {
            InitializeComponent();
        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SeriCombo.Items.Clear();
                if (MarkaCombo.SelectedItem.ToString() == "Opel")
                {
                    SeriCombo.Items.Add("Astra");
                    SeriCombo.Items.Add("Vectra");
                    SeriCombo.Items.Add("Corsa");

                }
                else if (MarkaCombo.SelectedIndex==1)
                {
                    SeriCombo.Items.Add("Megane");
                    SeriCombo.Items.Add("Clio");
                    SeriCombo.Items.Add("Symbool");

                }
                else if (MarkaCombo.SelectedIndex == 2)
                {
                    SeriCombo.Items.Add("linea");
                    SeriCombo.Items.Add("egea");

                }
                else if (MarkaCombo.SelectedIndex == 3)
                {
                    SeriCombo.Items.Add("mustang");
                    SeriCombo.Items.Add("focus");
                    SeriCombo.Items.Add("fiesta");

                }
            }
            catch 
            {

                ;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into araç(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,durumu) values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@durumu)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka",Plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", MarkaCombo.Text);
            komut2.Parameters.AddWithValue("@seri", SeriCombo.Text);
            komut2.Parameters.AddWithValue("@yil", Modeltxt.Text);
            komut2.Parameters.AddWithValue("@renk", Renktxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", YakitCombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti",int.Parse( KiraUcretitxt.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@durumu", "bos");
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            SeriCombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";



        }
    }
}
