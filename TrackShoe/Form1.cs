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

        int whichIndex = 0;
        public List<Shoe> shoeList;

        public void Print(Shoe obj)
        {

            MessageBox.Show(obj.imageURL);
          //  
        }


      public int readXML() {

          XDocument shoeDoc = XDocument.Load("shoes.xml");

          shoeList =
  (from shoes in shoeDoc.Descendants("shoe")
   select new Shoe
   {
       shoeBrand = shoes.Element("shoeBrand").Value,
       shoeModel = shoes.Element("shoeModel").Value,
       startingMiles = shoes.Element("startingMiles").Value,
       imageURL = shoes.Element("image").Element("url").Value,
       runLengths = shoes.Elements("runs").Elements("runLength").Attributes("length").ToList<string>(),
   }).ToList<Shoe>();



          populateInitialView(shoeList[0]);

          return shoeList.Count;
            }


   

      public void populateInitialView(Shoe initialShoe)
      {
          
          shoePic.Load(initialShoe.imageURL);
          shoeBrand.Text = initialShoe.shoeBrand + " " + initialShoe.shoeModel;
          shoeMiles.Text = "Current Miles: " + initialShoe.startingMiles;
          MessageBox.Show(initialShoe.runLengths);

      }
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Okay, let's load our XML file//


            int totalNumbers = readXML();

           // MessageBox.Show(totalNumbers.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            advanceToNext(whichIndex);

        }

        public void advanceToNext(int thisIndex)
        {

            thisIndex++;
            whichIndex = thisIndex;

            if (thisIndex > shoeList.Count - 1)
            {
                thisIndex = 0;
                whichIndex = 0;
            }

            //MessageBox.Show(whichIndex.ToString());
            shoePic.Load(shoeList[thisIndex].imageURL);
            shoeBrand.Text = shoeList[thisIndex].shoeBrand + " " + shoeList[thisIndex].shoeModel;
            shoeMiles.Text = "Current Miles: " + shoeList[thisIndex].startingMiles;


        }

        public void regressToPrevious(int thisIndex)
        {
            thisIndex--;
            whichIndex= thisIndex;
            if (thisIndex < 0)
            {
                thisIndex = shoeList.Count -1;
                whichIndex = thisIndex;
            }

            shoePic.Load(shoeList[thisIndex].imageURL);
            shoeBrand.Text = shoeList[thisIndex].shoeBrand + " " + shoeList[thisIndex].shoeModel;
            shoeMiles.Text = "Current Miles: " + shoeList[thisIndex].startingMiles;

        }

        public void prevButton_Click(object sender, EventArgs e)
        {
            regressToPrevious(whichIndex);

        }

        private void shoeMiles_Click(object sender, EventArgs e)
        {

        }

    }
}
