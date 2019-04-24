//Harley Veillette 2019-04-24
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList text = new ArrayList();

        string textRight = string.Empty;
        string textReverse = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            ////Show message the right way
            lblMessage.Text = textRight;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            ////Show message the reverse way
            lblMessage.Text = textReverse;
        }

        private void sentence()
        {
            //Clear the string and make place to re-write it and not duplicate it
            textRight = string.Empty;
            textReverse = string.Empty;

            //Create the sentence by adding each elements of the list
            foreach (string a in text)
            {
                textRight += a;
            }


            text.Reverse();

            //Create the same sentence but in...reverse
            foreach (string a in text)
            {
                textReverse += a;
            }
            text.Reverse();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add the elements in the arraylist
            text.Add("I ");
            text.Add("Love ");
            text.Add("Programming ");
            text.Add("So ");
            text.Add("Much ");

            //Generate the string for the label
            sentence();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //insert a new element inside the list at a specific index
            text.Insert(1, txtSecondPos.Text);
            sentence();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // remove a element with the specific index
            text.RemoveAt(1);
            sentence();
        }
    }
}
