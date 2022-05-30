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
using Otomata.ServiceReference1;

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
        int fiyat = Form1.fiyat;
        int seriNo = Form1.seriNo;
        public static int  index=0;

        public static int kalkan=0;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtEhliyet.Text != "" && txtSoyad.Text != "" && txtTel.Text != "" && txtYas.Text != "")
            {
                if (int.Parse(txtYas.Text) >= 18)
                {
                    CarServiceSoapClient ucret = new CarServiceSoapClient();

                    string mesaj = ucret.Kirala();

                    XDocument xDoc = XDocument.Load("Customers.xml");
                    XElement rootelement = xDoc.Root;
                    XElement newelement = new XElement("Customer");
                    XAttribute serinoatt = new XAttribute("SeriNo", seriNo);
                    XElement lisanselemen = new XElement("LisansNo", txtEhliyet.Text);

                    newelement.Add(serinoatt, lisanselemen);
                    rootelement.Add(newelement);
                    xDoc.Save("Customers.xml");

                    int tutar = fiyat * int.Parse(textBox1.Text);

                    //MessageBox.Show(mesaj + tutar);

                    //XDocument xDocument = XDocument.Load("araba.xml");
                    //XElement root = xDocument.Root;

                    //XmlDocument xmldoc = new XmlDocument();
                    //xmldoc.Load("araba.xml");

                    //foreach (XmlAttribute i in xmldoc.Attributes)
                    //{
                    //    if (i["SeriNo"].HasAttribute()
                    //    {
                    //        XElement durum = new XElement("Durum", 0);
                            
                    //    }

                    //}                   

                    kalkan = seriNo;
                    this.Hide();
                    string title = "Kiralama Başarılı";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(mesaj + tutar, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                    else
                    {
                        // Do something  
                    }
                    
                }
                else
                {
                    MessageBox.Show("18 yaşından küçükler araba kiralayamaz!!");
                    Form1 f1 = new Form1();
                    f1.Show();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgilerinizi giriniz.");
            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            kalkan = 0;
            this.Hide();
            
        }
    }
}
