using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Media;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        // this is to set the background music 
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Children song.wav");
        
        string username = Form1.SetValueForText1;
        public Form2()
        {
            InitializeComponent();
            //colouring
            this.listBox3.DrawMode = DrawMode.OwnerDrawFixed;
            this.listBox3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(listBox3_DrawItem);
            this.listBox3.SelectedIndexChanged += new System.EventHandler(listBox3_SelectedIndexChanged_1);

           // placing the cursor at music section
            this.ActiveControl = txt_Music;
            txt_Music.Focus();

            checkBox1.Image = Properties.Resources.Mute1;
           
        }
        public string Encoder(string encode)
        {
            String encoded = WebUtility.UrlEncode(encode);
            return encoded;
        }


        public void writeTXT(string Text)
        {
         string time = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

            // write a text in the generated text file.
            TextWriter tw = new StreamWriter(username + ".txt", true);
            tw.Write(username);
            tw.Write(" " + "/" + time);
            tw.Write(" " + "/" + Text);
            tw.WriteLine();
            tw.Close();
        }

        // this is a table for the history
        DataTable table = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            // this is to load the music when the application run
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer("Children song.wav");
            sp.PlayLooping();

            //read the username based on the text file ( username .txt)
            w_lbl.Text = "  WELCOME " + Form1.SetValueForText1;

            //Here to add columns, rows in the table based on the (username.txt) file.
            table.Columns.Add("UserName", typeof(string));
            table.Columns.Add("Date & Time", typeof(string));
            table.Columns.Add("Query", typeof(string));

            dataGridView1.DataSource = table;

            string[] lines = File.ReadAllLines(username + ".txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }

        }

        private void btn_Music_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("button.wav");
            splayer.Play();

            string M = txt_Music.Text;

            // if user enter invalid search such sex....
            if (M.Contains("sex") == true || M.Contains("porn") == true || M.Contains("fuck") == true || M.Contains("shit") == true || M.Contains("hell") == true || M.Contains("naked") == true 
                || M.Contains("kill") == true || M.Contains("bloody") == true || M.Contains("damn") == true)
            {
                MessageBox.Show("Oops! Invalid search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
            // if empty
            else if (M == "")
            {
                MessageBox.Show("Please enter search keyword", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // if user enter a valid serach keyword
            else
            {
                string musicrquery = "parent directory mp3 -xxx -html -htm -php -shtml -opendivx -md5 -md5sums";
                System.Diagnostics.Process.Start("https://www.google.com/search?num=20&q=" + Encoder("intext:" + txt_Music.Text) + (" ") + Encoder(musicrquery));
                writeTXT("intext:" + txt_Music.Text + (" ") + musicrquery);

            }
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("button.wav");
            splayer.Play();

            string I = txt_Image.Text;

            // if user enter invalid search such sex....
            if (I.Contains("sex") == true ||I.Contains("porn") == true || I.Contains("fuck") == true || I.Contains("shit") == true || I.Contains("hell") == true 
                || I.Contains("naked") == true || I.Contains("kill") == true || I.Contains("kill") == true || I.Contains("bloody") == true || I.Contains("damn") == true)
            {
                MessageBox.Show("Oops! Invalid search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // if empty
            else if (I == "")
            {
                MessageBox.Show("Please enter search keyword", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           // if user enter a valid serach keyword
            else
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?num=20&&hl=en&source=lnms&tbm=isch&q=" + Encoder("indexof:" + txt_Image.Text));
                writeTXT("indexof:" + txt_Image.Text);
                
            }
        }

        private void btn_Video_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("button.wav");
            splayer.Play();

            string V = txt_Video.Text;

            // if user enter invalid search such sex....
            if (V.Contains("sex") == true || V.Contains("porn") == true || V.Contains("fuck") == true || V.Contains("shit") == true || V.Contains("hell") == true 
                || V.Contains("naked") == true || V.Contains("kill") == true || V.Contains("bloody") == true || V.Contains("damn") == true)
            {
                MessageBox.Show("Oops! Invalid search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            // if empty
            else if (V == "")
            {
                MessageBox.Show("Please enter search keyword", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           // if user enter a valid serach keyword
            else
            {
        string moviequery = "parent directory mp4 -xxx -html -htm -php -shtml -opendivx -md5 -md5sums";
                System.Diagnostics.Process.Start("https://www.google.com/search?num=20&q=" + Encoder("intext:" + txt_Video.Text) + (" ") + Encoder(moviequery));
                writeTXT("intext:" + txt_Video.Text + (" ") + moviequery);
            }
        }

        private void btn_App_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("button.wav");
            splayer.Play();

            string A = txt_App.Text;


            // if user enter invalid search such sex....
            if (A.Contains("sex") == true || A.Contains("porn") == true || A.Contains("fuck") == true || A.Contains("shit") == true ||
                A.Contains("hell") == true || A.Contains("naked") == true || A.Contains("kill") == true || A.Contains("bloody") == true || A.Contains("damn") == true)
            {
                MessageBox.Show("Oops! Invalid search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // if empty
            else if (A == "")
            {
                MessageBox.Show("Please enter search keyword", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if user enter a valid serach keyword
            else
            {
                string  appquery= "parent directory exe -xxx -html -htm -php -shtml -opendivx -md5 -md5sums";
                //string appquery = "intext:”parent directory” intext:”[EXE]” ";
                System.Diagnostics.Process.Start("https://www.google.com/search?num=20&q=" + Encoder("intitle:" + txt_App.Text) + (" ") + Encoder(appquery));
                writeTXT("intitle:" + txt_App.Text + (" ") + appquery);
            }
        }

        private void btn_Format_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("button.wav");
            splayer.Play();

            string formatequery;

            // if user enter invalid search such sex....
            string P = txt_Format.Text;
            if (P.Contains("sex") == true || P.Contains("porn") == true || P.Contains("fuck") == true || P.Contains("shit") == true   || P.Contains("hell") == true 
                || P.Contains("naked") == true || P.Contains("kill") == true || P.Contains("bloody") == true || P.Contains("damn") == true)
            {
                MessageBox.Show("Oops! Invalid search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            // if empty
            else if (P == "")
            {
                MessageBox.Show("Please enter search keyword", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if user enter a valid serach keyword
            else
            {
                if (rad_Pdf.Checked)
                {
                    formatequery = (" filetype:" +  "pdf" + " " + txt_Format.Text);
                    
                    System.Diagnostics.Process.Start("https://www.google.com/search?num=20&q=" + Encoder(formatequery));
                    writeTXT("intext:" + txt_Format.Text + (" ") + formatequery);
                }

                if (rad_PPX.Checked)
                {
                    formatequery = (" filetype:" + "pptx" + " " + "OR" + " filetype:" + "ppt" + " " + txt_Format.Text);
                    System.Diagnostics.Process.Start("https://www.google.com/search?num=20&q=" + Encoder(formatequery));
                    writeTXT("intext:" + txt_Format.Text + (" ") + formatequery);
                }

                if (rad_Doc.Checked)
                {
                    formatequery = (" filetype:" + "doc" + " " + "OR" + " filetype:" + "docx" + " " + txt_Format.Text);
                    System.Diagnostics.Process.Start("https://www.google.com/search?num=20&q=" + Encoder(formatequery));
                    writeTXT("intext:" + txt_Format.Text + (" ") + formatequery);
                }
                // if empty for pdf, pptx, doc
                if (P == "")
                {
                    MessageBox.Show("Please enter search keyword", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               /* if (!rad_Doc.Checked && !rad_Pdf.Checked && !rad_PPX.Checked)
                {
                    MessageBox.Show("Please select either doc, pdf or pptx ");
                    return;
                }*/
            }
        }

        private void gb_Music_Enter(object sender, EventArgs e)
        {

            // Ability to press Enter by keyboard for the music
            this.AcceptButton = btn_Music;
        }

        private void gb_Image_Enter(object sender, EventArgs e)
        {
            // Ability to press Enter by keyboard for the Image
            this.AcceptButton = btn_Image;
        }

        private void gb_App_Enter(object sender, EventArgs e)
        {
            // Ability to press Enter by keyboard for the app
            this.AcceptButton = btn_App;
        }

        private void gb_Video_Enter(object sender, EventArgs e)
        {
            // Ability to press Enter by keyboard for the video
            this.AcceptButton = btn_Video;
        }

        private void gb_Format_Enter(object sender, EventArgs e)
        {
            // Ability to press Enter by keyboard for the documents
            this.AcceptButton = btn_Format;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This is to change background from comobox list
            if (comboBox1.SelectedItem.Equals("Flower"))
            {
            this.BackgroundImage = Properties.Resources.Flower;
           
            }
             else if (comboBox1.SelectedItem.Equals("Gambul"))
            {
             this.BackgroundImage = Properties.Resources.Gambul;
              
            }
             else if (comboBox1.SelectedItem.Equals("Stars"))
            {
               this.BackgroundImage = Properties.Resources.Stars;
              
            }
              else if (comboBox1.SelectedItem.Equals("Clouds"))
            {
                this.BackgroundImage = Properties.Resources.Clouds;
           
            }
               else if (comboBox1.SelectedItem.Equals("Kids"))
            {
              this.BackgroundImage = Properties.Resources.Kids;
               
            }
            else if (comboBox1.SelectedItem.Equals("Airship"))
            {
                this.BackgroundImage = Properties.Resources.Airship;

            }
            else if (comboBox1.SelectedItem.Equals("SpongBob"))
            {
                this.BackgroundImage = Properties.Resources.SpongBob;

            }
            else if (comboBox1.SelectedItem.Equals("Whale"))
            {
                this.BackgroundImage = Properties.Resources.Whale;

            }
            else if (comboBox1.SelectedItem.Equals("Hamster"))
            {
                this.BackgroundImage = Properties.Resources.Hamster;

            }
            else if (comboBox1.SelectedItem.Equals("Planet"))
            {
                this.BackgroundImage = Properties.Resources.Planet;

            }
            else if (comboBox1.SelectedItem.Equals("Minions"))
            {
                this.BackgroundImage = Properties.Resources.Minions;

            }
        }


        // this is for displaying the list of recommendations 
        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            encoder en = new encoder();
            string sItem = listBox2.SelectedItem.ToString();

            //for movie
            if (sItem == "Funbrain")
            {
                System.Diagnostics.Process.Start("https://www.funbrain.com/");
            }
            else if (sItem == "Disneynow")
            {
                System.Diagnostics.Process.Start("https://disneynow.com/all-shows/disney-junior");
            }
            else if (sItem == "Metmuseum")
            {
                System.Diagnostics.Process.Start("https://www.metmuseum.org/art/online-features/metkids/");
            }
            else if (sItem == "Cartoonnetwork")
            {
                System.Diagnostics.Process.Start("https://www.cartoonnetworkasia.com");
            }
            else if (sItem == "Pogo")
            {
                System.Diagnostics.Process.Start("https://www.pogo.com/");
            }
            else if (sItem == "Kidssearch")
            {
                System.Diagnostics.Process.Start("https://www.kidssearch.com/video/newvideos.html");
            }

            else if (sItem == "Pluto TV")
            {
                System.Diagnostics.Process.Start("https://corporate.pluto.tv/thanks-for-watching/");
            }
            else if (sItem == "Vudu")
            {
                System.Diagnostics.Process.Start("https://www.vudu.com/content/movies/collection/content/Family-Kids/25593?minVisible=0");
            }
            else if (sItem == "Tubi")
            {
                System.Diagnostics.Process.Start("https://tubitv.com/category/family_movies");
            }
            else if (sItem == "Popcornflix")
            {
                System.Diagnostics.Process.Start("https://www.popcornflix.com/channels/details/familykids");
            }
            
            // from game 
            else if (sItem == "Primarygames")
            {
                System.Diagnostics.Process.Start("https://www.primarygames.com/social_studies.php");
            }
            else if (sItem == "Ducksters")
            {
                System.Diagnostics.Process.Start("https://www.ducksters.com/");
            }
            else if (sItem == "Kidzsearch")
            {
                System.Diagnostics.Process.Start("https://games.kidzsearch.com/computer/title/slither-140844");
            }
            else if (sItem == "Pbskids")
            {
                System.Diagnostics.Process.Start("https://pbskids.org/games/coloring/");
            }
            else if (sItem == "Gamesheep")
            {
                System.Diagnostics.Process.Start("https://www.gamesheep.com");
            }
            else if (sItem == "Education Game")
            {
                System.Diagnostics.Process.Start("https://www.education.com/games/");
            }
            else if (sItem == "Prodigy Game ")
            {
                System.Diagnostics.Process.Start("https://www.prodigygame.com/main-en//");
            }
            else if (sItem == "Climate Kids")
            {
                System.Diagnostics.Process.Start("https://climatekids.nasa.gov/menu/play/");
            }
            else if (sItem == "Clssics for kids")
            {
                System.Diagnostics.Process.Start("https://www.classicsforkids.com/games.html");
            }
            else if (sItem == "CBC Games ")
            {
                System.Diagnostics.Process.Start("https://www.cbc.ca/kids/games");
            }
            else if (sItem == "Jump Start ")
            {
                System.Diagnostics.Process.Start("https://www.jumpstart.com/");
            }
            else if (sItem == "Kids Game")
            {
                System.Diagnostics.Process.Start("https://games.kidzsearch.com/computer/title/ambulance-rescue-driver-simulator-2018-ks120414-166794");
            }
            // for math
            else if (sItem == "Math play ground")
            {
                System.Diagnostics.Process.Start("https://www.mathplayground.com/");
            }
            else if (sItem == "Brain bashers ")
            {
                System.Diagnostics.Process.Start("https://www.brainbashers.com/");
            }
            else if (sItem == "Math way")
            {
                System.Diagnostics.Process.Start("https://www.mathway.com/Algebra");
            }
            else if (sItem == "Cool math games")
            {
                System.Diagnostics.Process.Start("https://www.coolmathgames.com/");
            }
            else if (sItem == "Kidzone ")
            {
                System.Diagnostics.Process.Start("https://kidzone.ws/");
            }
            else if (sItem == "Varsity tutors")
            {
                System.Diagnostics.Process.Start("https://www.varsitytutors.com/aplusmath");
            }
            else if (sItem == "Math worksheets")
            {
                System.Diagnostics.Process.Start("https://www.k5learning.com/free-math-worksheets");
            }
            else if (sItem == "Cymath")
            {
                System.Diagnostics.Process.Start("https://www.cymath.com/");
            }
            // for Education 
            else if (sItem == "Fun teaching")
            {
                System.Diagnostics.Process.Start("https://www.havefunteaching.com/resources/social-studies/worksheets");
            }
            else if (sItem == "Teach kids art ")
            {
                System.Diagnostics.Process.Start("https://www.teachkidsart.net/");
            }
            else if (sItem == "Scholastic")
            {
                System.Diagnostics.Process.Start("https://www.scholastic.com/parents/school-success.html");
            }
            else if (sItem == "Discovery education")
            {
                System.Diagnostics.Process.Start("https://www.discoveryeducation.com/");
            }
            else if (sItem == "Ready")
            {
                System.Diagnostics.Process.Start("https://www.ready.gov/kids");
            }
            else if (sItem == "Education")
            {
                System.Diagnostics.Process.Start("https://www.education.com/worksheets/social-studies//");
            }
            else if (sItem == "Factmonster")
            {
                System.Diagnostics.Process.Start("https://www.factmonster.com/");
            }
            else if (sItem == "Topmarks")
            {
                System.Diagnostics.Process.Start("https://www.topmarks.co.uk/number-facts/number-fact-families");
            }
            else if (sItem == "Kids calculator")
            {
                System.Diagnostics.Process.Start("https://kidssearch.com/KidsCalculator.html");
            }
            else if (sItem == "Education preschool")
            {
                System.Diagnostics.Process.Start("https://www.education.com/games/preschool/");
            }
            else if (sItem == "Translate")
            {
                System.Diagnostics.Process.Start("https://translate.google.com/");
            }
            else if (sItem == "Wikihow")
            {
                System.Diagnostics.Process.Start("https://www.wikihow.com/Read-Music");
            }
            else if (sItem == "Wikihow calcailater")
            {
                System.Diagnostics.Process.Start("https://www.wikihow.com/Calculate-Volume");
            }
            // for Art 
            else if (sItem == "Teach kids art")
            {
                System.Diagnostics.Process.Start("https://www.teachkidsart.net/");
            }
            else if (sItem == "Pbskids coloring")
            {
                System.Diagnostics.Process.Start("https://pbskids.org/games/coloring/");
            }
            else if (sItem == "Kinder art")
            {
                System.Diagnostics.Process.Start("https://www.kinderart.com/");
            }
            else if (sItem == "Metmuseum")
            {
                System.Diagnostics.Process.Start("https://www.metmuseum.org/art/online-features/metkids/");
            }
            else if (sItem == "Art fulparent")
            {
                System.Diagnostics.Process.Start("https://artfulparent.com/kids-arts-crafts-activities-500-fun-artful-things-kids/");
            }
            else if (sItem == "Art for kidshub")
            {
                System.Diagnostics.Process.Start("https://www.artforkidshub.com/");
            }
            else if (sItem == "Nces kids")
            {
                System.Diagnostics.Process.Start("https://nces.ed.gov/nceskids/createagraph/");
            }
            // FOR SPORT 
            else if (sItem == "Sikids")
            {
                System.Diagnostics.Process.Start("https://www.sikids.com/");
            }
            else if (sItem == "Kids Tennis")
            {
                System.Diagnostics.Process.Start("https://www.activekids.com/tennis/articles");
            }

            else if (sItem == "Football")
            {
                System.Diagnostics.Process.Start("https://kids.britannica.com/kids/article/football/353142");
            }
            else if (sItem == "The Little Gym")
            {
                System.Diagnostics.Process.Start("https://www.thelittlegym.com.my/");
            }

            else if (sItem == "Basketball")
            {
                System.Diagnostics.Process.Start("https://basketballqld.com.au/why-you-should-get-your-kids-into-basketball/");
            }
            else if (sItem == "Nascar")
            {
                System.Diagnostics.Process.Start("https://www.nascar.com/");
            }
            else if (sItem == "Nfl sport")
            {
                System.Diagnostics.Process.Start("https://www.nfl.com/");
            }
            else if (sItem == "Nbatry")
            {
                System.Diagnostics.Process.Start("https://www.nba.com/");
            }

        }
        // this is when items selected in recommended links
        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox3.SelectedItems.Contains("Movie"))
           
            {
                Clear();
                string line;
                System.IO.StreamReader file2 =
               new System.IO.StreamReader("Movie.txt");

                while ((line = file2.ReadLine()) != null)
                {
                    listBox2.Items.Add(line);
                    
                }
                file2.Close();
            }

            else
            {
                if (listBox3.SelectedItems.Contains("Game"))
                {
                    Clear();
                    string line;
                    System.IO.StreamReader file3 =
                   new System.IO.StreamReader("Game.txt");

                    while ((line = file3.ReadLine()) != null)
                    {
                        listBox2.Items.Add(line);
                        
                    }


                    file3.Close();
                }
                if (listBox3.SelectedItems.Contains("Math"))
                {
                    Clear();
                    string line;
                    System.IO.StreamReader file4 =
                   new System.IO.StreamReader("Math.txt");

                    while ((line = file4.ReadLine()) != null)
                    {
                        listBox2.Items.Add(line);
                        
                    }
                    file4.Close();
                }
                if (listBox3.SelectedItems.Contains("Sport"))
                {
                    Clear();
                    string line;
                    System.IO.StreamReader file4 =
                   new System.IO.StreamReader("Sport.txt");

                    while ((line = file4.ReadLine()) != null)
                    {
                        listBox2.Items.Add(line);
                        
                    }
                    file4.Close();
                }
                if (listBox3.SelectedItems.Contains("Art"))
                {
                    Clear();
                    string line;
                    System.IO.StreamReader file7 =
                   new System.IO.StreamReader("Art.txt");

                    while ((line = file7.ReadLine()) != null)
                    {
                        listBox2.Items.Add(line);
                        
                    }
                    file7.Close();
                }
                if (listBox3.SelectedItems.Contains("Education"))
                {
                    Clear();
                    string line;
                    System.IO.StreamReader file5 =
                   new System.IO.StreamReader("Education.txt");

                    while ((line = file5.ReadLine()) != null)
                    {
                        listBox2.Items.Add(line);
                        
                    }
                    file5.Close();
                }

            }
        }

        private void Clear()
        {
            listBox2.Items.Clear();
        }
       
        private void btn_Music_MouseEnter(object sender, EventArgs e)
        {
            btn_Music.BackColor = Color.YellowGreen;
        }
        
        private void btn_Music_MouseLeave(object sender, EventArgs e)
        {
            btn_Music.BackColor = Color.Gold;
        }

        // this is to mute or to play the music
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBox1.Checked)
                {
                    sp.Play();
                    checkBox1.Image = Properties.Resources.Mute1;
                }
                else
                {
                    sp.Stop();
                    checkBox1.Image = Properties.Resources.Play1;
                }

            }

        private void btn_App_MouseEnter(object sender, EventArgs e)
        {
            btn_App.BackColor = Color.YellowGreen;
        }

        private void btn_App_MouseLeave(object sender, EventArgs e)
        {
            btn_App.BackColor = Color.Gold;
        }

        private void btn_Image_MouseEnter(object sender, EventArgs e)
        {
            btn_Image.BackColor = Color.YellowGreen;
        }

        private void btn_Image_MouseLeave(object sender, EventArgs e)
        {
            btn_Image.BackColor = Color.Gold;
        }

        private void btn_Video_MouseEnter(object sender, EventArgs e)
        {
            btn_Video.BackColor = Color.YellowGreen;
        }

        private void btn_Video_MouseLeave(object sender, EventArgs e)
        {
            btn_Video.BackColor = Color.Gold;
        }

        private void btn_Format_MouseEnter(object sender, EventArgs e)
        {
            btn_Format.BackColor = Color.YellowGreen;
        }

        private void btn_Format_MouseLeave(object sender, EventArgs e)
        {
            btn_Format.BackColor = Color.Gold;
        }

        private void listBox3_DrawItem(object sender, DrawItemEventArgs e)
        {

            ListBox listBox = (ListBox)sender;
            e.DrawBackground();
            Brush myBrush = Brushes.Black;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                myBrush = Brushes.Blue;
                e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), e.Bounds);
            }

            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);

            }

            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds);
            e.DrawFocusRectangle();
        }

        // this is to display the data in a table 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            
            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            string cellValue = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();

            // do  nothing when username, time are selected
            if (dataGridView1.Rows[rowindex].Cells[0].Selected || dataGridView1.Rows[rowindex].Cells[1].Selected)
            {
                //do nothing
            }

            // go to google when the search query selected
            else
            {
               encoder en = new encoder();
                System.Diagnostics.Process.Start("https://www.google.com/search?num=20&q=" + en.Encoder(cellValue));

            }
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("button.wav");
            splayer.Play();
            Form3 frm3 = new Form3();
         
            frm3.ShowDialog();
           
       
        }
        private void About_btn_MouseEnter(object sender, EventArgs e)
        {
            About_btn.BackColor = Color.Yellow;
        }

        private void About_btn_MouseLeave(object sender, EventArgs e)
        {
            About_btn.BackColor = Color.WhiteSmoke;
        }
    }
    }
   

