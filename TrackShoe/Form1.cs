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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TrackShoe
{
   
   
    public partial class mainForm : Form
    {
        
      public string readXML() {

          XDocument shoeDoc = XDocument.Load("shoes.xml");

          List<Shoe> shoeList =
  (from shoes in shoeDoc.Descendants("shoe")
   select new Shoe
   {
       shoeBrand = shoes.Element("shoeBrand").Value,
       shoeModel = shoes.Element("shoeModel").Value,
       startingMiles = shoes.Element("startingMiles").Value,
   }).ToList<Shoe>();

          foreach(int element in shoeList) {

          MessageBox.Show();

          }
            /*
             *  XmlSerializer ser = new XmlSerializer(typeof(XmlNode));
    XmlNode myNode= new XmlDocument().
    CreateNode(XmlNodeType.Element, "MyNode", "ns");
    myNode.InnerText = "Hello Node";
    TextWriter writer = new StreamWriter(filename);
    ser.Serialize(writer, myNode);
    writer.Close();
             * 
             * 
             */ 

            //string shoeDocString;
            //shoeDocString = File.ReadAllText("shoes.xml");

//            XDocument xDoc = XDocument.Parse(shoeDocString);

  //          var allShoes = (from x in xDoc.Descendants("shoe")
    //                        select new Shoe {
      //                          shoeBrand = x.Element("shoeBrand").Value;
        //                   }


           /* XmlNode thisShoe = shoeDoc.SelectSingleNode("/shoeConfig/shoe/shoeBrand/text()");

            foreach (XmlNode Shoe in shoeDoc.SelectNodes("/shoeConfig/shoe")) {
 
           // MessageBox.Show();
           // MessageBox.Show(Shoe.SelectSingleNode("shoeModel/text()").InnerText);

                    



                shoePic.Load("http://www.emory.edu/home/_includes/images/callout/campus-visit.jpg");

        //    }
            */
            return "foo";

        //}
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
