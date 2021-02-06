using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectnote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string decimals = "";
        public static string pointreal = "";

        public static int maxpointint;
        public static int outcome;
        public static int pointfinish;


        public static int mode = 1; // 1 = mode 1 = punt/max punt * 9 + 1 = standaard
        public static decimal point = 0; // 1 = mode 1 = punt/max punt * 9 + 1 = standaard

        public static int studenten = 0;
        public static decimal cijfertotaal = 0;

        public static decimal voldoende = 55 / 10;
        public static decimal matig = 62 / 10;
        public static decimal super = 82 / 10;

        public static decimal highestpoint = 0;
        public static decimal lowestpoint = 10;

        public static int onvoldoende = 0;

        //not used for now begin
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }
        //not used for now end

        private void button1_Click(object sender, EventArgs e) //op click uitrekenen
        {

            //step 1: transferring the names
            textBox69.Text = textBox9.Text;
            textBox71.Text = textBox13.Text;
            textBox72.Text = textBox14.Text;
            textBox73.Text = textBox15.Text;
            textBox74.Text = textBox16.Text;
            textBox75.Text = textBox17.Text;
            textBox76.Text = textBox18.Text;
            textBox78.Text = textBox19.Text; //bad placing
            textBox79.Text = textBox20.Text; //bad placing
            textBox77.Text = textBox21.Text; //bad placing
            textBox80.Text = textBox22.Text;
            textBox81.Text = textBox23.Text;
            textBox82.Text = textBox24.Text;
            textBox83.Text = textBox25.Text;
            textBox84.Text = textBox26.Text;
            textBox85.Text = textBox27.Text;
            textBox86.Text = textBox28.Text;
            textBox87.Text = textBox29.Text;
            textBox88.Text = textBox30.Text;
            textBox89.Text = textBox31.Text;
            textBox90.Text = textBox32.Text;
            textBox91.Text = textBox33.Text;
            textBox92.Text = textBox34.Text; //bad placing
            textBox93.Text = textBox36.Text; //bad placing
            textBox94.Text = textBox37.Text;
            textBox95.Text = textBox38.Text;
            textBox96.Text = textBox39.Text;
            //step 2: calculating and transferring notes

            //in general
            //creating a int from maxpoint
            string maxpointstring = textBox12.Text;

            int maxpointint = Convert.ToInt32(maxpointstring);

            //creating a int from *x
            string timeninestring = textBox126.Text;
            decimal timenineint = Convert.ToDecimal(timeninestring);
            //creating a int from +x
            string add1string = textBox127.Text;
            decimal add1dec = Convert.ToDecimal(add1string);
            //creating a int from +y

            //specific note transferring

            //person 1
            if (textBox10.Text != "")
            {
                string pointstring2 = textBox10.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox70.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox70.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox70.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox70.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox70.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox70.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox70.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox70.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox70.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox70.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox70.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox70.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox70.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox70.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox70.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox70.Text = "error";
                }
                studenten = studenten + 1;
            }


            //person 2
            //creating a int from points
            if (textBox41.Text != "")
            {
                string pointstring2 = textBox41.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox97.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox97.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox97.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox97.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox97.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox97.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox97.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox97.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox97.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox97.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }

                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox97.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox97.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox97.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox97.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox97.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox97.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 3
            //creating a int from points
            if (textBox35.Text != "")
            {
                string pointstring2 = textBox35.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox98.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox98.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox98.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox98.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox98.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox98.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox98.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox98.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox98.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox98.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox98.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox98.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox98.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox98.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox98.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox98.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 4
            if (textBox40.Text != "")
            {
                string pointstring2 = textBox40.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox108.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox108.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox108.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox108.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox108.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox108.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox108.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox108.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox108.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox108.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox108.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox108.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox108.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox108.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox108.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox108.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 5

            if (textBox42.Text != "")
            {
                string pointstring2 = textBox42.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox107.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox107.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox107.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox107.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox107.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox107.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox107.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox107.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox107.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox107.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox107.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox107.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox107.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox107.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox107.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox107.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 6

            if (textBox43.Text != "")
            {
                string pointstring2 = textBox43.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox106.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox106.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox106.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox106.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox106.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox106.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox106.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox106.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox106.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox106.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox106.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox106.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox106.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox106.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox106.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox106.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 7
            if (textBox44.Text != "")
            {
                string pointstring2 = textBox44.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox105.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox105.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox105.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox105.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox105.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox105.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox105.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox105.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox105.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox105.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox105.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox105.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox105.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox105.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox105.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox105.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 8
            if (textBox45.Text != "")
            {
                string pointstring2 = textBox45.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox104.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox104.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox104.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox104.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox104.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox104.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox104.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox104.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox104.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox104.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox104.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox104.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox104.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox104.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox104.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox104.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 9
            if (textBox46.Text != "")
            {
                string pointstring2 = textBox46.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox103.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox103.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox103.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox103.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox103.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox103.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox103.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox103.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox103.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox103.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox103.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox103.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox103.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox103.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox103.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox103.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 10
            if (textBox47.Text != "")
            {
                string pointstring2 = textBox47.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox102.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox102.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox102.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox102.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox102.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox102.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox102.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox102.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox102.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox102.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox102.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox102.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox102.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox102.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox102.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox102.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 11
            if (textBox48.Text != "")
            {
                string pointstring2 = textBox48.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox101.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox101.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox101.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox101.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox101.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox101.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox101.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox101.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox101.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox101.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox101.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox101.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox101.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox101.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox101.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox101.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 12
            if (textBox49.Text != "")
            {
                string pointstring2 = textBox49.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox100.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox100.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox100.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox100.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox100.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox100.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox100.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox100.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox100.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox100.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox100.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox100.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox100.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox100.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox100.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox100.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 13
            if (textBox50.Text != "")
            {
                string pointstring2 = textBox50.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox99.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox99.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox99.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox99.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox99.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox99.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox99.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox99.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox99.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox99.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox99.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox99.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox99.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox99.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox99.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox99.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 14
            if (textBox51.Text != "")
            {
                string pointstring2 = textBox51.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox110.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox110.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox110.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox110.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox110.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox110.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox110.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox110.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox110.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox110.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox110.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox110.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox110.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox110.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox110.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox110.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 15
            if (textBox52.Text != "")
            {
                string pointstring2 = textBox52.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox109.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox109.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox109.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox109.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox109.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox109.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox109.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox109.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox109.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox109.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox109.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox109.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox109.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox109.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox109.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox109.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 16
            if (textBox53.Text != "")
            {
                string pointstring2 = textBox53.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox111.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox111.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox111.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox111.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox111.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox111.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox111.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox111.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox111.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox111.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox111.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox111.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox111.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox111.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox111.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox111.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 17
            if (textBox54.Text != "")
            {
                string pointstring2 = textBox54.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox112.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox112.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox112.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox112.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox112.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox112.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox112.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox112.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox112.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox112.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox112.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox112.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox112.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox112.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox112.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox112.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 18
            if (textBox55.Text != "")
            {
                string pointstring2 = textBox55.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox113.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox113.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox113.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox113.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox113.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox113.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox113.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox113.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox113.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox113.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox113.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox113.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox113.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox113.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox113.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox113.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 19
            if (textBox56.Text != "")
            {
                string pointstring2 = textBox56.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox114.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox114.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox114.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox114.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox114.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox114.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox114.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox114.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox114.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox114.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox114.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox114.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox114.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox114.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox114.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox114.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 20
            if (textBox57.Text != "")
            {
                string pointstring2 = textBox57.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox115.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox115.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox115.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox115.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox115.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox115.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox115.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox115.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox115.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox115.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox115.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox115.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox115.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox115.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox115.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox115.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 21
            if (textBox58.Text != "")
            {
                string pointstring2 = textBox58.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox116.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox116.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox116.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox116.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox116.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox116.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox116.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox116.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox116.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox116.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox116.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox116.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox116.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox116.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox116.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox116.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 22
            if (textBox59.Text != "")
            {
                string pointstring2 = textBox59.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox117.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox117.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox117.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox117.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox117.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox117.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox117.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox117.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox117.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox117.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox117.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox117.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox117.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox117.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox117.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox117.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 23
            if (textBox60.Text != "")
            {
                string pointstring2 = textBox60.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox118.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox118.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox118.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox118.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox118.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox118.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox118.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox118.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox118.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox118.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox118.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox118.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox118.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox118.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox118.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox118.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 24
            if (textBox61.Text != "")
            {
                string pointstring2 = textBox61.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox119.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox119.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox119.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox119.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox119.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox119.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox119.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox119.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox119.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox119.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }

                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox119.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox119.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox119.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox119.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox119.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox119.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 25
            if (textBox62.Text != "")
            {
                string pointstring2 = textBox62.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox120.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox120.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox120.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox120.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox120.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox120.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox120.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox120.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox120.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox120.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox120.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox120.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox120.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox120.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox120.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox120.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 26
            if (textBox63.Text != "")
            {
                string pointstring2 = textBox63.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox121.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox121.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox121.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox121.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox121.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox121.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox121.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox121.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox121.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox121.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox121.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox121.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox121.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox121.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox121.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox121.Text = "error";
                }
                studenten = studenten + 1;
            }

            //person 27
            if (textBox64.Text != "")
            {
                string pointstring2 = textBox64.Text;
                decimal pointint2 = Convert.ToDecimal(pointstring2);
                decimal step1 = pointint2 / maxpointint;
                decimal step2 = step1 * timenineint;
                if (mode == 1 || mode == 2) // 1 or 2
                {
                    decimal outcome = step2 + add1dec;
                    textBox122.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox122.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox122.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox122.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox122.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 3) //nivvelation
                {
                    decimal outcomeprep = step2 + add1dec;
                    decimal notenotgot = 10 - outcomeprep;
                    decimal outcome = outcomeprep + notenotgot / 20;
                    textBox122.Text = outcome.ToString();
                    cijfertotaal = cijfertotaal + outcome;
                    if (outcome < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox122.BackColor = Color.Red;
                    }
                    else if (outcome > voldoende && outcome < matig) //between 5.5 and 6.2
                    {
                        textBox122.BackColor = Color.Yellow;
                    }
                    else if (outcome > super) //higher then 8.2
                    {
                        textBox122.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox122.BackColor = Color.White;
                    }
                    if (outcome > highestpoint)
                    {
                        highestpoint = outcome;
                    }
                    if (lowestpoint > outcome)
                    {
                        lowestpoint = outcome;
                    }
                }
                else if (mode == 4)
                {
                    decimal mistakes = maxpointint - pointint2; //decimal mistakes :D
                    decimal pointsmin = mistakes * point;
                    decimal pointfinish = 10 - pointsmin;
                    textBox122.Text = pointfinish.ToString();
                    cijfertotaal = cijfertotaal + pointfinish;
                    if (pointfinish < voldoende)
                    {
                        onvoldoende = onvoldoende + 1;
                        textBox122.BackColor = Color.Red;
                    }
                    else if (pointfinish > voldoende && pointfinish < matig) //between 5.5 and 6.2
                    {
                        textBox122.BackColor = Color.Yellow;
                    }
                    else if (pointfinish > super) //higher then 8.2
                    {
                        textBox122.BackColor = Color.Green;
                    }
                    else
                    {
                        textBox122.BackColor = Color.White;
                    }
                    if (pointfinish > highestpoint)
                    {
                        highestpoint = pointfinish;
                    }
                    if (lowestpoint > pointfinish)
                    {
                        lowestpoint = pointfinish;
                    }
                }
                else
                {
                    textBox122.Text = "error";
                }
                studenten = studenten + 1;
            }

            //statistiek

            //gemiddelde
            decimal gemiddelde = cijfertotaal / studenten;
            textBox137.Text = "gemiddelde:" + " " + gemiddelde.ToString(); //gemiddelde: 7,23 is een voorbeeld

            //onvoldoendes
            textBox138.Text = "onvoldoendes:" + " " + onvoldoende.ToString();

            //onvoldoendes percentage
            decimal onvoldoendesper = onvoldoende * 100/ studenten;
            textBox141.Text = "onvoldoendes per:" + " " + onvoldoendesper.ToString() + "%";

            //hoogste punt
            textBox139.Text = highestpoint.ToString();
            textBox140.Text = lowestpoint.ToString();


            //reset
            studenten = 0;
            cijfertotaal = 0;
            onvoldoende = 0;


        }

        private void button2_Click(object sender, EventArgs e) //normering veranderen
        {
            normselect norm = new normselect();
            norm.Show();
        }

        private void button3_Click(object sender, EventArgs e) //bevestigen
        {
            if (mode == 1) //mode = 1
            {
                textBox126.Text = "9";
                textBox127.Text = "1";
                textBox130.Text = "0";
                //statistiek
                textBox135.Text = "mildheid: redelijk mild";
                textBox142.Text = "nivellering: geen";
            }
            else if (mode == 2)
            {
                textBox126.Text = "10";
                textBox127.Text = "0";
                textBox130.Text = "0";
                //statistiek
                textBox135.Text = "mildheid: normaal";
                textBox142.Text = "nivellering: geen";
            }
            else if (mode == 3)
            {
                textBox126.Text = "9,5";
                textBox127.Text = "0,5";
                textBox130.Text = "(10-punt/20)";
                //statistiek
                textBox135.Text = "mildheid: erg mild";
                textBox142.Text = "nivellering: klein beetje";
            }
            else if (mode == 4)
            {
                textBox126.Text = "0";
                textBox127.Text = "0";
                textBox130.Text = "0";

                //creating a int from maxpoint
                string maxpointstring = textBox12.Text;
                int maxpointint = Convert.ToInt32(maxpointstring);

                //statistiek - mildheid
                decimal fiftyeightpercent = 85 / 100; //decimal kon niet met double multiply
                decimal hunderdfifteenpercent = 115 / 100;

                decimal mediumdifficulty = 10 / maxpointint;
                decimal easydifficulty = mediumdifficulty * fiftyeightpercent;
                decimal harddifficulty = mediumdifficulty * hunderdfifteenpercent;

                if (point == mediumdifficulty)
                {
                    textBox135.Text = "mildheid: normaal";
                    textBox142.Text = "nivellering: geen";
                }
                else if (point < mediumdifficulty && point > easydifficulty) //point is bigger then easy and smaller then medium
                {
                    textBox135.Text = "mildheid: redelijk mild";
                    textBox142.Text = "nivellering: klein beetje";
                }
                else if (point > mediumdifficulty && point < harddifficulty) //point is bigger then medium and smaller then hard
                {
                    textBox135.Text = "mildheid: redelijk streng";
                    textBox142.Text = "denivellering: klein beetje";
                }
                else if (point < easydifficulty) //point is smaller as easy
                {
                    textBox135.Text = "mildheid: erg mild";
                    textBox142.Text = "nivellering: veel";
                }
                else if (point > harddifficulty) //point is bigger as hard
                {
                    textBox135.Text = "mildheid: erg streng";
                    textBox142.Text = "denivellering: veel";
                }
                else
                {
                    textBox135.Text = "mildheid: onbekend";
                    textBox142.Text = "nivellering: onbekend";
                }
            }
        }
    }
}
