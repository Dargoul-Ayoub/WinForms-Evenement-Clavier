using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evenement_Clavier
{
    public partial class Form1 : Form
    {
        // imprtant things i have to do if i want the events get worked
        // 1) Go to your form's Properties
        // 2) Look for the "Misc" section and make sure "KeyPreview" is set to "True"
        // e.modifiers when you want to press two keys in the same time

        string keyDown;
        string keyPress;
        string keyUp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyDown = Convert.ToString(e.KeyCode);
            
            listBox1.Items.Add("KeyDown\t" + "KeyCode\t\t" + keyDown);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress = Convert.ToString(e.KeyChar);
            listBox1.Items.Add("KeyPress\t\t" + "KeyChar\t\t" + keyPress);

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keyUp = Convert.ToString(e.KeyCode);
            listBox1.Items.Add("KeyUp\t\t" + "KeyCode\t\t" + keyUp);
            listBox1.Items.Add("=================================================");
            listBox1.SetSelected(listBox1.Items.Count - 1,true);
        }
    }
}
