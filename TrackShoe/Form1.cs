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

        public void Print(Shoe obj)
        {

            MessageBox.Show(obj.imageURL);
            shoePic.Load(obj.imageURL);
        }


      public bool readXML() {

          XDocument shoeDoc = XDocument.Load("shoes.xml");

          List<Shoe> shoeList =
  (from shoes in shoeDoc.Descendants("shoe")
   select new Shoe
   {
       shoeBrand = shoes.Element("shoeBrand").Value,
       shoeModel = shoes.Element("shoeModel").Value,
       startingMiles = shoes.Element("startingMiles").Value,
       imageURL = shoes.Element("image").Element("url").Value,
   }).ToList<Shoe>();

          shoeList.ForEach(Print);
          
          


               
                return true;
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
