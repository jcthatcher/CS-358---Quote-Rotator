using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_1
{
    public partial class Form1 : Form
    {
        int tracker;
        string[] quotes;

        public Form1()
        {
            tracker = 0;            
            quotes = new string[]{ "Moral indignation is jealousy with a halo.- H. G. Wells (1866-1946)",
                "The whole problem with the world is that fools and fanatics are always so certain of themselves, and wiser people so full of doubts.- Bertrand Russell (1872-1970)",
                "Victory goes to the player who makes the next-to-last mistake. Savielly Grigorievitch Tartakower (1887-1956)",
                "Don't be so humble - you are not that great. - Golda Meir (1898-1978) ",
                "You can avoid reality, but you cannot avoid the consequences of avoiding reality. - Ayn Rand (1905-1982)"};

            InitializeComponent();
        }

        public void RotateQuote()
        {
            if (tracker == quotes.Length - 1)
            {
                tracker = 0;
            }
            else
            {
                tracker += 1;
            }

            txtDisplay.Text = quotes[tracker];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Text = "Quote " + (tracker + 1).ToString();
            RotateQuote();            
        }
    }
}
