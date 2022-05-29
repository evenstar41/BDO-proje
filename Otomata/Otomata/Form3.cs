using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Otomata
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtEhliyet.Text != "" && txtSoyad.Text != "" && txtTel.Text != "" && txtYas.Text != "")
            {
                if (int.Parse(txtYas.Text) >= 18)
                {
                    XDocument xDoc = XDocument.Load("Customers.xml");
                    XElement rootelement = xDoc.Root;
                    XElement newelement = new XElement("Customer");
                    XAttribute serinoatt = new XAttribute("SeriNo", "0");
                    XElement lisanselemen = new XElement("LisansNo", txtEhliyet.Text);

                    newelement.Add(serinoatt, lisanselemen);
                    rootelement.Add(newelement);
                    xDoc.Save("Customers.xml");

                    MessageBox.Show("Araba kiralamanız başarıyla tamamlanmıştır :)");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("18 yaşından küçükler araba kiralayamaz!!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgilerinizi giriniz.");
            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
