using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otomata.ServiceReference1;

namespace Otomata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        int kalkan = Form3.kalkan;
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CarServiceSoapClient urun = new CarServiceSoapClient();
            dataGridView1.DataSource = urun.Oku().Tables[0];
            if (kalkan>0)
            {
              

            }
            label1.Text = kalkan.ToString();
        }
        public static int fiyat;
        public static int seriNo;
        int index = Form3.index;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seriNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SeriNo"].Value);
            fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Fiyat"].Value);
            kalkan = 0;
            Form3  f3= new Form3();
            f3.ShowDialog();
            this.Hide();
        }
    }
}
