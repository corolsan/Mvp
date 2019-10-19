using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPtest.Presentor;
using MVPtest.View;

namespace MVPtest
{
    public partial class Form1 : Form, IMagazine
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string areaText
        {
            get
            {
                return area.Text;

            }

            set
            {
                area.Text = value;
            }
        }

        public string nameText1
        {
            get
            {
                return textName1.Text;
            }

            set
            {
                textName1.Text = value;

            }
        }

        public string priblText1
        {
            get
            {
                return textPribl1.Text;

            }

            set
            {
                textPribl1.Text = value;

            }
        }

        public string nameProd
        {
            get
            {
                return textNameProdov.Text;

            }

            set
            {
                textNameProdov.Text = value;

            }
        }

        public string nameText2
        {
            get
            {
                return textName2.Text;
            }

            set
            {
                textName2.Text = value;

            }
        }

        public string priblText2
        {
            get
            {
                return textPribl2.Text;

            }

            set
            {
                textPribl2.Text = value;

            }
        }

        public string kolSotr
        {
            get
            {
                return textKolSot.Text;
            }

            set
            {
                textKolSot.Text = value;
            }
        }

        public string nameText3
        {
            get
            {
                return textName3.Text;
            }

            set
            {
                textName3.Text = value;

            }
        }

        public string priblText3
        {
            get
            {
                return textPribl3.Text;

            }

            set
            {
                textPribl3.Text = value;

            }
        }

        public string kolPav
        {
            get
            {
                return textKolPav.Text;
            }

            set
            {
                textKolPav.Text = value;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MagazinePrezentor presentor = new MagazinePrezentor(this);

            presentor.whoBolshe();





        }

        private void textNameProdov_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
