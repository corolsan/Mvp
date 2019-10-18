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

        public string nameText
        {
            get
            {
                return textName.Text;
            }

            set
            {
                textName.Text = value;

            }
        }

        public string priblText
        {
            get
            {
                return textPribl.Text;

            }

            set
            {
                textPribl.Text = value;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MagazinePrezentor presentor = new MagazinePrezentor(this);

            presentor.Deistvie();





        }
    }
}
