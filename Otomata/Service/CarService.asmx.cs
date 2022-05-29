using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Sql;
using System.Xml;
using System.Data;


namespace Service
{
    /// <summary>
    /// Summary description for CarService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CarService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet Oku()
        {
            XmlReader reader;
            DataSet ds = new DataSet();
            reader = XmlReader.Create(@"XMLFile1.xml", new XmlReaderSettings());
            ds.ReadXml(reader);
            return ds;
        }
        //public DataSet Kirala()
        //{

        //}

    





        //public void XmlOlustur()
        //{
        //    Otomata.Form2 form2 = new Otomata.Form2();

        //    form2

        //    XmlReader reader;
        //    DataSet ds = new DataSet();
        //    reader = XmlReader.Create(@"araba.xml", new XmlReaderSettings());
        //    ds.ReadXml(reader);
        //    dataGridView1.DataSource = ds.Tables[0];
        //    reader.Close();
        //}

        //[WebMethod]
        //public string XmlOkuma()
        //{
        //    string xmlDosyasi = @"araba.xml";
        //    XmlTextReader XmlOkuyucu = new XmlTextReader(xmlDosyasi);

        //    while (XmlOkuyucu.Read())
        //    {
        //        if (XmlOkuyucu.NodeType == XmlNodeType.Element)
        //        {
        //            ("Etiket: {0} İçerik: {1}", XmlOkuyucu.Name, XmlOkuyucu.ReadElementContentAsString());
        //        }
        //    }

        //    XmlOkuyucu.Close();
        //    return 
        //}
    }
}
