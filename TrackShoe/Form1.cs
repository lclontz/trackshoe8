using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace TrackShoe
{
   
    public partial class mainForm : Form
    {
        
        public string readXML() {

            XmlDocument shoeDoc = new XmlDocument();
            shoeDoc.Load("shoes.xml");

            XmlNode thisShoe = shoeDoc.SelectSingleNode("/shoeConfig/shoe/shoeBrand/text()");

            foreach (XmlNode Shoe in shoeDoc.SelectNodes("/shoeConfig/shoe")) {
 
            MessageBox.Show(Shoe.SelectSingleNode("shoeBrand/text()").InnerText);
            MessageBox.Show(Shoe.SelectSingleNode("shoeModel/text()").InnerText);


            }
            return "foo";

        }
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Okay, let's load our XML file//
            
            readXML();



        }
    }
}
