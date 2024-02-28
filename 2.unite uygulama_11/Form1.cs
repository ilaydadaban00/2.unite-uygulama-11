using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch(gun)
            {
                case 1:
                    

                    case 2:
                    

                case 3:
                   
                case 4:
                   
                case 5:
                   
              
                    MessageBox.Show("hafta içi");
                    break;
                case 6:
                case 7:
                   

                    MessageBox.Show("hafta sonu");
                    break;
                default:
                    {
                        MessageBox.Show("hatalı");
                    }
                    break;

                  


            }
        }
    }
}
