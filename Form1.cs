using System;
using System.IO;
using System.Windows.Forms;
using System.Media;


namespace FinalProject
{

    public partial class Form1 : Form
    {
        public static string SetValueForText1 = "";
        public Form1()
        {
            InitializeComponent();
            // this is to make the cursor start at the first textbox
            this.ActiveControl = txt1;
            txt1.Focus();
        }

        
        private void btn1_Click(object sender, EventArgs e)
        {
            //this sound for the button enter when pressed
            SoundPlayer splayer = new SoundPlayer("buttonenter.wav");
            splayer.Play();

            SetValueForText1 = txt1.Text;

            // This is to generate a txt file based on the the username
            TextWriter tw = new StreamWriter(SetValueForText1 + ".txt", true);
            tw.Close();

            // if the user forgot to enter his/her username
            if (txt1.Text == "")
            {
                MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           //if user enter correctly the username, it will direct the user to form2
            else
            {
                Form2 frm2 = new Form2();
                Hide();
                frm2.ShowDialog();
                this.Close();
            }

        }

        

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this to set the textbox only accept text not a number
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

            }
        }

        
    }
}
