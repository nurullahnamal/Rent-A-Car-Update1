namespace Rent_A_Car_Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmM��teriEkle ekle = new frmM��teriEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmM��teriListele listele = new frmM��teriListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAra�Kay�t kay�t = new frmAra�Kay�t();
            kay�t.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAra�Listele listele=new frmAra�Listele();
            listele.ShowDialog();
        }
    }
}