using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sparks
{
    public partial class Sparks : Form
    {
        public Sparks()
        {
            InitializeComponent();
            buttonspan.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will open setings tab.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Credentials Cleared
            txtBoxRnumber.Clear();
            txtBoxDep.Clear();
            txtBoxName.Clear();
            txtBoxFname.Clear();
            txtBoxBatch.Clear();

            // Course Code Cleared
            crsc1.Text = "--";
            crsc2.Text = "--";
            crsc3.Text = "--";
            crsc4.Text = "--";
            crsc5.Text = "--";
            crsc6.Text = "--";

            // Subjects Cleared
            lblsub1.Text = "--";
            lblsub2.Text = "--";
            lblsub3.Text = "--";
            lblsub4.Text = "--";
            lblsub5.Text = "--";
            lblsub6.Text = "--";

            // Obtained Marks Cleared
            obtmarks1.Clear();
            obtmarks2.Clear();
            obtmarks3.Clear();
            obtmarks4.Clear();
            obtmarks5.Clear();
            obtmarks6.Clear();
            lbltotal.Text = "--";

            // Grades Cleared
            gde1.Text = "--";
            gde2.Text = "--";
            gde3.Text = "--";
            gde4.Text = "--";
            gde5.Text = "--";
            gde6.Text = "--";
            totalgde.Text = "--";

            // Percentage Cleared
            per1.Text = "--";
            per2.Text = "--";
            per3.Text = "--";
            per4.Text = "--";
            per5.Text = "--";
            per6.Text = "--";
            totalper.Text = "--";
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxRnumber_TextChanged(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Roll Number 1
            if (txtBoxRnumber.Text == "1" && txtBoxDep.Text == "BSCS")
            {
                // Course Names
                lblsub1.Text = "Introduction to Computers";
                lblsub2.Text = "Mathematics";
                lblsub3.Text = "Statistics and Data Analysis";
                lblsub4.Text = "Physics";
                lblsub5.Text = "English";
                lblsub6.Text = "Islamic Learning";

                // Course Codes
                crsc1.Text = "CS-771";
                crsc2.Text = "CS-772";
                crsc3.Text = "CS-773";
                crsc4.Text = "CS-774";
                crsc5.Text = "CS-775";
                crsc6.Text = "CS-776";




                // Marks
                int subj1, subj2, subj3, subj4, subj5, subj6, total, totalp;
                string a = obtmarks1.Text;
                
                bool ans = int.TryParse(a, out subj1); // Stack Section

                if (ans == true)
                {
                    
                }
                else
                {
                    MessageBox.Show("Marks Box 1 is Empty!");
                }
                a = obtmarks2.Text;

                ans = int.TryParse(a, out subj2);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 2 is Empty!");
                }
                a = obtmarks3.Text;

                ans = int.TryParse(a, out subj3);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 3 is Empty!");
                }
                a = obtmarks4.Text;

                ans = int.TryParse(a, out subj4);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 4 is Empty!");
                }
                a = obtmarks5.Text;

                ans = int.TryParse(a, out subj5);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 5 is Empty!");
                }
                a = obtmarks6.Text;

                ans = int.TryParse(a, out subj6);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 6 is Empty!");
                }

                
                total = subj1 + subj2 + subj3 + subj4 + subj5 + subj6;



                // Percentage
                int totalperc;
                totalperc = (total * 100) / 600;
                if (subj1 <= 0 || subj1 >= 101)
                {
                    MessageBox.Show("Error: Check Marks Box no. 1");
                    per1.Text = "--";

                } 
                else {
                    totalp = (subj1 * 100) / 100;
                    per1.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                    totalper.Text = totalperc.ToString();
                }

                if (subj2 <= 0 || subj2 >= 101)
                {
                    MessageBox.Show("Error: Check Marks Box no. 2");
                    per2.Text = "--";

                }
                else
                {
                    totalp = (subj2 * 100) / 100;
                    per2.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj3 <= 0 || subj3 >= 101)
                {
                    MessageBox.Show("Error: Check Marks Box no. 3");
                    per3.Text = "--";

                }
                else
                {
                    totalp = (subj3 * 100) / 100;
                    per3.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj4 <= 0 || subj4 >= 101)
                {
                    MessageBox.Show("Error: Check Marks Box no. 4");
                    per4.Text = "--";

                }
                else
                {
                    totalp = (subj4 * 100) / 100;
                    per4.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj5 <= 0 || subj5 >= 101)
                {
                    MessageBox.Show("Error: Check Marks Box no. 5");
                    per5.Text = "--";

                }
                else
                {
                    totalp = (subj5 * 100) / 100;
                    per5.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj6 <= 0 || subj6 >= 101)
                {
                    MessageBox.Show("Error: Check Marks Box no. 6");
                    per6.Text = "--";

                }
                else
                {
                    totalp = (subj6 * 100) / 100;
                    per6.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }
                


                // Grades 
                // Total Grade Sec
                if (totalperc <= 100 && totalperc > 89)
                {
                    totalgde.Text = "A+";
                }
                else if (totalperc <= 85 && totalperc > 74)
                {
                    totalgde.Text = "A";
                }
                else if (totalperc <= 75 && totalperc > 64)
                {
                    totalgde.Text = "B";
                }
                else if (totalperc <= 65 && totalperc > 54)
                {
                    totalgde.Text = "C";
                }
                else if (totalperc <= 55 && totalperc > 44)
                {
                    totalgde.Text = "D";
                }
                else if (totalperc <= 45 && totalperc > 33)
                {
                    totalgde.Text = "E";
                }
                else {
                    totalgde.Text = "F";
                }
                // Grade 1
                if (subj1 <= 100 && subj1 > 84)
                {
                    gde1.Text = "A+";
                }
                else if (subj1 <= 85 && subj1 > 74)
                {
                    gde1.Text = "A";
                }
                else if (subj1 <= 75 && subj1 > 64)
                {
                    gde1.Text = "B";
                }
                else if (subj1 <= 65 && subj1 > 54)
                {
                    gde1.Text = "C";
                }
                else if (subj1 <= 55 && subj1 > 44)
                {
                    gde1.Text = "D";
                }
                else if (subj1 <= 45 && subj1 > 33)
                {
                    gde1.Text = "E";
                }
                else {
                    gde1.Text = "F";
                }

                // Grade 2
                if (subj2 <= 100 && subj2 > 84)
                {
                    gde2.Text = "A+";
                }
                else if (subj2 <= 85 && subj2 > 74)
                {
                    gde2.Text = "A";
                }
                else if (subj2 <= 75 && subj2 > 64)
                {
                    gde2.Text = "B";
                }
                else if (subj2 <= 65 && subj2 > 54)
                {
                    gde2.Text = "C";
                }
                else if (subj2 <= 55 && subj2 > 44)
                {
                    gde2.Text = "D";
                }
                else if (subj2 <= 45 && subj2 > 33)
                {
                    gde2.Text = "E";
                }
                else
                {
                    gde2.Text = "F";
                }

                // Grade 3
                if (subj3 <= 100 && subj3 > 84)
                {
                    gde3.Text = "A+";
                }
                else if (subj3 <= 85 && subj3 > 74)
                {
                    gde3.Text = "A";
                }
                else if (subj3 <= 75 && subj3 > 64)
                {
                    gde3.Text = "B";
                }
                else if (subj3 <= 65 && subj3 > 54)
                {
                    gde3.Text = "C";
                }
                else if (subj3 <= 55 && subj3 > 44)
                {
                    gde3.Text = "D";
                }
                else if (subj3 <= 45 && subj3 > 33)
                {
                    gde3.Text = "E";
                }
                else
                {
                    gde3.Text = "F";
                }

                // Grade 4
                if (subj4 <= 100 && subj4 > 84)
                {
                    gde4.Text = "A+";
                }
                else if (subj4 <= 85 && subj4 > 74)
                {
                    gde4.Text = "A";
                }
                else if (subj4 <= 75 && subj4 > 64)
                {
                    gde4.Text = "B";
                }
                else if (subj4 <= 65 && subj4 > 54)
                {
                    gde4.Text = "C";
                }
                else if (subj4 <= 55 && subj4 > 44)
                {
                    gde4.Text = "D";
                }
                else if (subj4 <= 45 && subj4 > 33)
                {
                    gde4.Text = "E";
                }
                else
                {
                    gde4.Text = "F";
                }

                // Grade 5
                if (subj5 <= 100 && subj5 > 84)
                {
                    gde5.Text = "A+";
                }
                else if (subj5 <= 85 && subj5 > 74)
                {
                    gde5.Text = "A";
                }
                else if (subj5 <= 75 && subj5 > 64)
                {
                    gde5.Text = "B";
                }
                else if (subj5 <= 65 && subj5 > 54)
                {
                    gde5.Text = "C";
                }
                else if (subj5 <= 55 && subj5 > 44)
                {
                    gde5.Text = "D";
                }
                else if (subj5 <= 45 && subj5 > 33)
                {
                    gde5.Text = "E";
                }
                else
                {
                    gde5.Text = "F";
                }

                // Grade 6
                if (subj6 <= 100 && subj6 > 84)
                {
                    gde6.Text = "A+";
                }
                else if (subj6 <= 85 && subj6 > 74)
                {
                    gde6.Text = "A";
                }
                else if (subj6 <= 75 && subj6 > 64)
                {
                    gde6.Text = "B";
                }
                else if (subj6 <= 65 && subj6 > 54)
                {
                    gde6.Text = "C";
                }
                else if (subj6 <= 55 && subj6 > 44)
                {
                    gde6.Text = "D";
                }
                else if (subj6 <= 45 && subj6 > 33)
                {
                    gde6.Text = "E";
                }

                else
                {
                    gde6.Text = "F";
                }



            }
            
            else if (txtBoxRnumber.Text == "1" && txtBoxDep.Text == "bscs")
            {
                // Course Names
                
                lblsub1.Text = "Introduction to Computers";
                lblsub2.Text = "Mathematics";
                lblsub3.Text = "Statistics and Data Analysis";
                lblsub4.Text = "Physics";
                lblsub5.Text = "English";
                lblsub6.Text = "Islamic Learning";

                // Course Code
                crsc1.Text = "CS-771";
                crsc2.Text = "CS-772";
                crsc3.Text = "CS-773";
                crsc4.Text = "CS-774";
                crsc5.Text = "CS-775";
                crsc6.Text = "CS-776";

                // Marks
                // Marks
                int subj1, subj2, subj3, subj4, subj5, subj6, total, totalp;
                string a = obtmarks1.Text;

                bool ans = int.TryParse(a, out subj1); // Stack Section

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 1 is Empty!");
                }
                a = obtmarks2.Text;

                ans = int.TryParse(a, out subj2);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 2 is Empty!");
                }
                a = obtmarks3.Text;

                ans = int.TryParse(a, out subj3);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 3 is Empty!");
                }
                a = obtmarks4.Text;

                ans = int.TryParse(a, out subj4);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 4 is Empty!");
                }
                a = obtmarks5.Text;

                ans = int.TryParse(a, out subj5);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 5 is Empty!");
                }
                a = obtmarks6.Text;

                ans = int.TryParse(a, out subj6);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 6 is Empty!");
                }


                total = subj1 + subj2 + subj3 + subj4 + subj5 + subj6;

                // Percentage
                int totalperc;
                totalperc = (total * 100) / 600;
                if (subj1 <= 0 || subj1 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 1.");
                    per1.Text = "--";

                }
                else
                {
                    totalp = (subj1 * 100) / 100;
                    per1.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                    totalper.Text = totalperc.ToString();
                }

                if (subj2 <= 0 || subj2 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 2.");
                    per2.Text = "--";

                }
                else
                {
                    totalp = (subj2 * 100) / 100;
                    per2.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj3 <= 0 || subj3 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 3.");
                    per3.Text = "--";

                }
                else
                {
                    totalp = (subj3 * 100) / 100;
                    per3.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj4 <= 0 || subj4 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 4.");
                    per4.Text = "--";

                }
                else
                {
                    totalp = (subj4 * 100) / 100;
                    per4.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj5 <= 0 || subj5 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 5.");
                    per5.Text = "--";

                }
                else
                {
                    totalp = (subj5 * 100) / 100;
                    per5.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj6 <= 0 || subj6 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 6.");
                    per6.Text = "--";

                }
                else
                {
                    totalp = (subj6 * 100) / 100;
                    per6.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                // Grades 
                // Total Grade Sec
                if (totalperc <= 100 && totalperc > 89)
                {
                    totalgde.Text = "A+";
                }
                else if (totalperc <= 85 && totalperc > 74)
                {
                    totalgde.Text = "A";
                }
                else if (totalperc <= 75 && totalperc > 64)
                {
                    totalgde.Text = "B";
                }
                else if (totalperc <= 65 && totalperc > 54)
                {
                    totalgde.Text = "C";
                }
                else if (totalperc <= 55 && totalperc > 44)
                {
                    totalgde.Text = "D";
                }
                else if (totalperc <= 45 && totalperc > 33)
                {
                    totalgde.Text = "E";
                }
                else
                {
                    totalgde.Text = "F";
                }
                // Grade 1
                if (subj1 <= 100 && subj1 > 84)
                {
                    gde1.Text = "A+";
                }
                else if (subj1 <= 85 && subj1 > 74)
                {
                    gde1.Text = "A";
                }
                else if (subj1 <= 75 && subj1 > 64)
                {
                    gde1.Text = "B";
                }
                else if (subj1 <= 65 && subj1 > 54)
                {
                    gde1.Text = "C";
                }
                else if (subj1 <= 55 && subj1 > 44)
                {
                    gde1.Text = "D";
                }
                else if (subj1 <= 45 && subj1 > 33)
                {
                    gde1.Text = "E";
                }
                else
                {
                    gde1.Text = "F";
                }

                // Grade 2
                if (subj2 <= 100 && subj2 > 84)
                {
                    gde2.Text = "A+";
                }
                else if (subj2 <= 85 && subj2 > 74)
                {
                    gde2.Text = "A";
                }
                else if (subj2 <= 75 && subj2 > 64)
                {
                    gde2.Text = "B";
                }
                else if (subj2 <= 65 && subj2 > 54)
                {
                    gde2.Text = "C";
                }
                else if (subj2 <= 55 && subj2 > 44)
                {
                    gde2.Text = "D";
                }
                else if (subj2 <= 45 && subj2 > 33)
                {
                    gde2.Text = "E";
                }
                else
                {
                    gde2.Text = "F";
                }

                // Grade 3
                if (subj3 <= 100 && subj3 > 84)
                {
                    gde3.Text = "A+";
                }
                else if (subj3 <= 85 && subj3 > 74)
                {
                    gde3.Text = "A";
                }
                else if (subj3 <= 75 && subj3 > 64)
                {
                    gde3.Text = "B";
                }
                else if (subj3 <= 65 && subj3 > 54)
                {
                    gde3.Text = "C";
                }
                else if (subj3 <= 55 && subj3 > 44)
                {
                    gde3.Text = "D";
                }
                else if (subj3 <= 45 && subj3 > 33)
                {
                    gde3.Text = "E";
                }
                else
                {
                    gde3.Text = "F";
                }

                // Grade 4
                if (subj4 <= 100 && subj4 > 84)
                {
                    gde4.Text = "A+";
                }
                else if (subj4 <= 85 && subj4 > 74)
                {
                    gde4.Text = "A";
                }
                else if (subj4 <= 75 && subj4 > 64)
                {
                    gde4.Text = "B";
                }
                else if (subj4 <= 65 && subj4 > 54)
                {
                    gde4.Text = "C";
                }
                else if (subj4 <= 55 && subj4 > 44)
                {
                    gde4.Text = "D";
                }
                else if (subj4 <= 45 && subj4 > 33)
                {
                    gde4.Text = "E";
                }
                else
                {
                    gde4.Text = "F";
                }

                // Grade 5
                if (subj5 <= 100 && subj5 > 84)
                {
                    gde5.Text = "A+";
                }
                else if (subj5 <= 85 && subj5 > 74)
                {
                    gde5.Text = "A";
                }
                else if (subj5 <= 75 && subj5 > 64)
                {
                    gde5.Text = "B";
                }
                else if (subj5 <= 65 && subj5 > 54)
                {
                    gde5.Text = "C";
                }
                else if (subj5 <= 55 && subj5 > 44)
                {
                    gde5.Text = "D";
                }
                else if (subj5 <= 45 && subj5 > 33)
                {
                    gde5.Text = "E";
                }
                else
                {
                    gde5.Text = "F";
                }

                // Grade 6
                if (subj6 <= 100 && subj6 > 84)
                {
                    gde6.Text = "A+";
                }
                else if (subj6 <= 85 && subj6 > 74)
                {
                    gde6.Text = "A";
                }
                else if (subj6 <= 75 && subj6 > 64)
                {
                    gde6.Text = "B";
                }
                else if (subj6 <= 65 && subj6 > 54)
                {
                    gde6.Text = "C";
                }
                else if (subj6 <= 55 && subj6 > 44)
                {
                    gde6.Text = "D";
                }
                else if (subj6 <= 45 && subj6 > 33)
                {
                    gde6.Text = "E";
                }

                else
                {
                    gde6.Text = "F";
                }



            
        }

            // Roll Number 2
            else if (txtBoxRnumber.Text == "2" && txtBoxDep.Text == "BSIT")
            {
                // Course Names
                lblsub1.Text = "Information and Comm. Tech";
                lblsub2.Text = "Programming Fundamentals";
                lblsub3.Text = "Calculus";
                lblsub4.Text = "Basic Electronics";
                lblsub5.Text = "English";
                lblsub6.Text = "Uni Electives";

                // Course Code
                crsc1.Text = "IT-851";
                crsc2.Text = "IT-852";
                crsc3.Text = "IT-853";
                crsc4.Text = "IT-854";
                crsc5.Text = "IT-855";
                crsc6.Text = "IT-856";

                // Marks
                // Marks
                int subj1, subj2, subj3, subj4, subj5, subj6, total, totalp;
                string a = obtmarks1.Text;

                bool ans = int.TryParse(a, out subj1); // Stack Section

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 1 is Empty!");
                }
                a = obtmarks2.Text;

                ans = int.TryParse(a, out subj2);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 2 is Empty!");
                }
                a = obtmarks3.Text;

                ans = int.TryParse(a, out subj3);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 3 is Empty!");
                }
                a = obtmarks4.Text;

                ans = int.TryParse(a, out subj4);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 4 is Empty!");
                }
                a = obtmarks5.Text;

                ans = int.TryParse(a, out subj5);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 5 is Empty!");
                }
                a = obtmarks6.Text;

                ans = int.TryParse(a, out subj6);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 6 is Empty!");
                }


                total = subj1 + subj2 + subj3 + subj4 + subj5 + subj6;

                // Percentage
                int totalperc;
                totalperc = (total * 100) / 600;
                if (subj1 <= 0 || subj1 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 1.");
                    per1.Text = "--";

                }
                else
                {
                    totalp = (subj1 * 100) / 100;
                    per1.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                    totalper.Text = totalperc.ToString();
                }

                if (subj2 <= 0 || subj2 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 2.");
                    per2.Text = "--";

                }
                else
                {
                    totalp = (subj2 * 100) / 100;
                    per2.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj3 <= 0 || subj3 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 3.");
                    per3.Text = "--";

                }
                else
                {
                    totalp = (subj3 * 100) / 100;
                    per3.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj4 <= 0 || subj4 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 4.");
                    per4.Text = "--";

                }
                else
                {
                    totalp = (subj4 * 100) / 100;
                    per4.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj5 <= 0 || subj5 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 5.");
                    per5.Text = "--";

                }
                else
                {
                    totalp = (subj5 * 100) / 100;
                    per5.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj6 <= 0 || subj6 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 6.");
                    per6.Text = "--";

                }
                else
                {
                    totalp = (subj6 * 100) / 100;
                    per6.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }
                // Grades 
                // Total Grade Sec
                if (totalperc <= 100 && totalperc > 89)
                {
                    totalgde.Text = "A+";
                }
                else if (totalperc <= 85 && totalperc > 74)
                {
                    totalgde.Text = "A";
                }
                else if (totalperc <= 75 && totalperc > 64)
                {
                    totalgde.Text = "B";
                }
                else if (totalperc <= 65 && totalperc > 54)
                {
                    totalgde.Text = "C";
                }
                else if (totalperc <= 55 && totalperc > 44)
                {
                    totalgde.Text = "D";
                }
                else if (totalperc <= 45 && totalperc > 33)
                {
                    totalgde.Text = "E";
                }
                else
                {
                    totalgde.Text = "F";
                }
                // Grade 1
                if (subj1 <= 100 && subj1 > 84)
                {
                    gde1.Text = "A+";
                }
                else if (subj1 <= 85 && subj1 > 74)
                {
                    gde1.Text = "A";
                }
                else if (subj1 <= 75 && subj1 > 64)
                {
                    gde1.Text = "B";
                }
                else if (subj1 <= 65 && subj1 > 54)
                {
                    gde1.Text = "C";
                }
                else if (subj1 <= 55 && subj1 > 44)
                {
                    gde1.Text = "D";
                }
                else if (subj1 <= 45 && subj1 > 33)
                {
                    gde1.Text = "E";
                }
                else
                {
                    gde1.Text = "F";
                }

                // Grade 2
                if (subj2 <= 100 && subj2 > 84)
                {
                    gde2.Text = "A+";
                }
                else if (subj2 <= 85 && subj2 > 74)
                {
                    gde2.Text = "A";
                }
                else if (subj2 <= 75 && subj2 > 64)
                {
                    gde2.Text = "B";
                }
                else if (subj2 <= 65 && subj2 > 54)
                {
                    gde2.Text = "C";
                }
                else if (subj2 <= 55 && subj2 > 44)
                {
                    gde2.Text = "D";
                }
                else if (subj2 <= 45 && subj2 > 33)
                {
                    gde2.Text = "E";
                }
                else
                {
                    gde2.Text = "F";
                }

                // Grade 3
                if (subj3 <= 100 && subj3 > 84)
                {
                    gde3.Text = "A+";
                }
                else if (subj3 <= 85 && subj3 > 74)
                {
                    gde3.Text = "A";
                }
                else if (subj3 <= 75 && subj3 > 64)
                {
                    gde3.Text = "B";
                }
                else if (subj3 <= 65 && subj3 > 54)
                {
                    gde3.Text = "C";
                }
                else if (subj3 <= 55 && subj3 > 44)
                {
                    gde3.Text = "D";
                }
                else if (subj3 <= 45 && subj3 > 33)
                {
                    gde3.Text = "E";
                }
                else
                {
                    gde3.Text = "F";
                }

                // Grade 4
                if (subj4 <= 100 && subj4 > 84)
                {
                    gde4.Text = "A+";
                }
                else if (subj4 <= 85 && subj4 > 74)
                {
                    gde4.Text = "A";
                }
                else if (subj4 <= 75 && subj4 > 64)
                {
                    gde4.Text = "B";
                }
                else if (subj4 <= 65 && subj4 > 54)
                {
                    gde4.Text = "C";
                }
                else if (subj4 <= 55 && subj4 > 44)
                {
                    gde4.Text = "D";
                }
                else if (subj4 <= 45 && subj4 > 33)
                {
                    gde4.Text = "E";
                }
                else
                {
                    gde4.Text = "F";
                }

                // Grade 5
                if (subj5 <= 100 && subj5 > 84)
                {
                    gde5.Text = "A+";
                }
                else if (subj5 <= 85 && subj5 > 74)
                {
                    gde5.Text = "A";
                }
                else if (subj5 <= 75 && subj5 > 64)
                {
                    gde5.Text = "B";
                }
                else if (subj5 <= 65 && subj5 > 54)
                {
                    gde5.Text = "C";
                }
                else if (subj5 <= 55 && subj5 > 44)
                {
                    gde5.Text = "D";
                }
                else if (subj5 <= 45 && subj5 > 33)
                {
                    gde5.Text = "E";
                }
                else
                {
                    gde5.Text = "F";
                }

                // Grade 6
                if (subj6 <= 100 && subj6 > 84)
                {
                    gde6.Text = "A+";
                }
                else if (subj6 <= 85 && subj6 > 74)
                {
                    gde6.Text = "A";
                }
                else if (subj6 <= 75 && subj6 > 64)
                {
                    gde6.Text = "B";
                }
                else if (subj6 <= 65 && subj6 > 54)
                {
                    gde6.Text = "C";
                }
                else if (subj6 <= 55 && subj6 > 44)
                {
                    gde6.Text = "D";
                }
                else if (subj6 <= 45 && subj6 > 33)
                {
                    gde6.Text = "E";
                }

                else
                {
                    gde6.Text = "F";
                }

            }
            else if (txtBoxRnumber.Text == "2" && txtBoxDep.Text == "bsit")
            {
                // Course Names
                lblsub1.Text = "Information and Comm. Tech";
                lblsub2.Text = "Programming Fundamentals";
                lblsub3.Text = "Calculus";
                lblsub4.Text = "Basic Electronics";
                lblsub5.Text = "English";
                lblsub6.Text = "Uni Electives";

                // Course Codes
                crsc1.Text = "IT-851";
                crsc2.Text = "IT-852";
                crsc3.Text = "IT-853";
                crsc4.Text = "IT-854";
                crsc5.Text = "IT-855";
                crsc6.Text = "IT-856";

                // Marks
                // Marks
                int subj1, subj2, subj3, subj4, subj5, subj6, total, totalp;
                string a = obtmarks1.Text;

                bool ans = int.TryParse(a, out subj1); // Stack Section

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 1 is Empty!");
                }
                a = obtmarks2.Text;

                ans = int.TryParse(a, out subj2);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 2 is Empty!");
                }
                a = obtmarks3.Text;

                ans = int.TryParse(a, out subj3);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 3 is Empty!");
                }
                a = obtmarks4.Text;

                ans = int.TryParse(a, out subj4);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 4 is Empty!");
                }
                a = obtmarks5.Text;

                ans = int.TryParse(a, out subj5);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 5 is Empty!");
                }
                a = obtmarks6.Text;

                ans = int.TryParse(a, out subj6);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 6 is Empty!");
                }


                total = subj1 + subj2 + subj3 + subj4 + subj5 + subj6;



                // Percentage
                int totalperc;
                totalperc = (total * 100) / 600;
                if (subj1 <= 0 || subj1 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 1.");
                    per1.Text = "--";

                }
                else
                {
                    totalp = (subj1 * 100) / 100;
                    per1.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                    totalper.Text = totalperc.ToString();
                }

                if (subj2 <= 0 || subj2 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 2.");
                    per2.Text = "--";

                }
                else
                {
                    totalp = (subj2 * 100) / 100;
                    per2.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj3 <= 0 || subj3 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 3.");
                    per3.Text = "--";

                }
                else
                {
                    totalp = (subj3 * 100) / 100;
                    per3.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj4 <= 0 || subj4 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 4.");
                    per4.Text = "--";

                }
                else
                {
                    totalp = (subj4 * 100) / 100;
                    per4.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj5 <= 0 || subj5 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 5.");
                    per5.Text = "--";

                }
                else
                {
                    totalp = (subj5 * 100) / 100;
                    per5.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj6 <= 0 || subj6 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 6.");
                    per6.Text = "--";

                }
                else
                {
                    totalp = (subj6 * 100) / 100;
                    per6.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }


                // Grades 
                // Total Grade Sec
                if (totalperc <= 100 && totalperc > 89)
                {
                    totalgde.Text = "A+";
                }
                else if (totalperc <= 85 && totalperc > 74)
                {
                    totalgde.Text = "A";
                }
                else if (totalperc <= 75 && totalperc > 64)
                {
                    totalgde.Text = "B";
                }
                else if (totalperc <= 65 && totalperc > 54)
                {
                    totalgde.Text = "C";
                }
                else if (totalperc <= 55 && totalperc > 44)
                {
                    totalgde.Text = "D";
                }
                else if (totalperc <= 45 && totalperc > 33)
                {
                    totalgde.Text = "E";
                }
                else
                {
                    totalgde.Text = "F";
                }
                // Grade 1
                if (subj1 <= 100 && subj1 > 84)
                {
                    gde1.Text = "A+";
                }
                else if (subj1 <= 85 && subj1 > 74)
                {
                    gde1.Text = "A";
                }
                else if (subj1 <= 75 && subj1 > 64)
                {
                    gde1.Text = "B";
                }
                else if (subj1 <= 65 && subj1 > 54)
                {
                    gde1.Text = "C";
                }
                else if (subj1 <= 55 && subj1 > 44)
                {
                    gde1.Text = "D";
                }
                else if (subj1 <= 45 && subj1 > 33)
                {
                    gde1.Text = "E";
                }
                else
                {
                    gde1.Text = "F";
                }

                // Grade 2
                if (subj2 <= 100 && subj2 > 84)
                {
                    gde2.Text = "A+";
                }
                else if (subj2 <= 85 && subj2 > 74)
                {
                    gde2.Text = "A";
                }
                else if (subj2 <= 75 && subj2 > 64)
                {
                    gde2.Text = "B";
                }
                else if (subj2 <= 65 && subj2 > 54)
                {
                    gde2.Text = "C";
                }
                else if (subj2 <= 55 && subj2 > 44)
                {
                    gde2.Text = "D";
                }
                else if (subj2 <= 45 && subj2 > 33)
                {
                    gde2.Text = "E";
                }
                else
                {
                    gde2.Text = "F";
                }

                // Grade 3
                if (subj3 <= 100 && subj3 > 84)
                {
                    gde3.Text = "A+";
                }
                else if (subj3 <= 85 && subj3 > 74)
                {
                    gde3.Text = "A";
                }
                else if (subj3 <= 75 && subj3 > 64)
                {
                    gde3.Text = "B";
                }
                else if (subj3 <= 65 && subj3 > 54)
                {
                    gde3.Text = "C";
                }
                else if (subj3 <= 55 && subj3 > 44)
                {
                    gde3.Text = "D";
                }
                else if (subj3 <= 45 && subj3 > 33)
                {
                    gde3.Text = "E";
                }
                else
                {
                    gde3.Text = "F";
                }

                // Grade 4
                if (subj4 <= 100 && subj4 > 84)
                {
                    gde4.Text = "A+";
                }
                else if (subj4 <= 85 && subj4 > 74)
                {
                    gde4.Text = "A";
                }
                else if (subj4 <= 75 && subj4 > 64)
                {
                    gde4.Text = "B";
                }
                else if (subj4 <= 65 && subj4 > 54)
                {
                    gde4.Text = "C";
                }
                else if (subj4 <= 55 && subj4 > 44)
                {
                    gde4.Text = "D";
                }
                else if (subj4 <= 45 && subj4 > 33)
                {
                    gde4.Text = "E";
                }
                else
                {
                    gde4.Text = "F";
                }

                // Grade 5
                if (subj5 <= 100 && subj5 > 84)
                {
                    gde5.Text = "A+";
                }
                else if (subj5 <= 85 && subj5 > 74)
                {
                    gde5.Text = "A";
                }
                else if (subj5 <= 75 && subj5 > 64)
                {
                    gde5.Text = "B";
                }
                else if (subj5 <= 65 && subj5 > 54)
                {
                    gde5.Text = "C";
                }
                else if (subj5 <= 55 && subj5 > 44)
                {
                    gde5.Text = "D";
                }
                else if (subj5 <= 45 && subj5 > 33)
                {
                    gde5.Text = "E";
                }
                else
                {
                    gde5.Text = "F";
                }

                // Grade 6
                if (subj6 <= 100 && subj6 > 84)
                {
                    gde6.Text = "A+";
                }
                else if (subj6 <= 85 && subj6 > 74)
                {
                    gde6.Text = "A";
                }
                else if (subj6 <= 75 && subj6 > 64)
                {
                    gde6.Text = "B";
                }
                else if (subj6 <= 65 && subj6 > 54)
                {
                    gde6.Text = "C";
                }
                else if (subj6 <= 55 && subj6 > 44)
                {
                    gde6.Text = "D";
                }
                else if (subj6 <= 45 && subj6 > 33)
                {
                    gde6.Text = "E";
                }

                else
                {
                    gde6.Text = "F";
                }

            }
            // Roll Number 3
            else if (txtBoxRnumber.Text == "3" && txtBoxDep.Text == "BSSE")
            {
                // Course Names
                lblsub1.Text = "Calculus";
                lblsub2.Text = "Computer Logic Design";
                lblsub3.Text = "Computer Science";
                lblsub4.Text = "Islamic Studies";
                lblsub5.Text = "English";
                lblsub6.Text = "Software Engineering";

                // Course Codes
                crsc1.Text = "SE-571";
                crsc2.Text = "SE-572";
                crsc3.Text = "SE-573";
                crsc4.Text = "SE-574";
                crsc5.Text = "SE-575";
                crsc6.Text = "SE-576";

                // Marks
                int subj1, subj2, subj3, subj4, subj5, subj6, total, totalp;
                string a = obtmarks1.Text;

                bool ans = int.TryParse(a, out subj1); // Stack Section

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 1 is Empty!");
                }
                a = obtmarks2.Text;

                ans = int.TryParse(a, out subj2);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 2 is Empty!");
                }
                a = obtmarks3.Text;

                ans = int.TryParse(a, out subj3);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 3 is Empty!");
                }
                a = obtmarks4.Text;

                ans = int.TryParse(a, out subj4);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 4 is Empty!");
                }
                a = obtmarks5.Text;

                ans = int.TryParse(a, out subj5);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 5 is Empty!");
                }
                a = obtmarks6.Text;

                ans = int.TryParse(a, out subj6);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 6 is Empty!");
                }


                total = subj1 + subj2 + subj3 + subj4 + subj5 + subj6;

                // Percentage
                int totalperc;
                totalperc = (total * 100) / 600;
                if (subj1 <= 0 || subj1 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 1.");
                    per1.Text = "--";

                }
                else
                {
                    totalp = (subj1 * 100) / 100;
                    per1.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                    totalper.Text = totalperc.ToString();
                }

                if (subj2 <= 0 || subj2 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 2.");
                    per2.Text = "--";

                }
                else
                {
                    totalp = (subj2 * 100) / 100;
                    per2.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj3 <= 0 || subj3 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 3.");
                    per3.Text = "--";

                }
                else
                {
                    totalp = (subj3 * 100) / 100;
                    per3.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj4 <= 0 || subj4 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 4.");
                    per4.Text = "--";

                }
                else
                {
                    totalp = (subj4 * 100) / 100;
                    per4.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj5 <= 0 || subj5 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 5.");
                    per5.Text = "--";

                }
                else
                {
                    totalp = (subj5 * 100) / 100;
                    per5.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj6 <= 0 || subj6 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 6.");
                    per6.Text = "--";

                }
                else
                {
                    totalp = (subj6 * 100) / 100;
                    per6.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                // Grades 
                // Total Grade Sec
                if (totalperc <= 100 && totalperc > 89)
                {
                    totalgde.Text = "A+";
                }
                else if (totalperc <= 85 && totalperc > 74)
                {
                    totalgde.Text = "A";
                }
                else if (totalperc <= 75 && totalperc > 64)
                {
                    totalgde.Text = "B";
                }
                else if (totalperc <= 65 && totalperc > 54)
                {
                    totalgde.Text = "C";
                }
                else if (totalperc <= 55 && totalperc > 44)
                {
                    totalgde.Text = "D";
                }
                else if (totalperc <= 45 && totalperc > 33)
                {
                    totalgde.Text = "E";
                }
                else
                {
                    totalgde.Text = "F";
                }
                // Grade 1
                if (subj1 <= 100 && subj1 > 84)
                {
                    gde1.Text = "A+";
                }
                else if (subj1 <= 85 && subj1 > 74)
                {
                    gde1.Text = "A";
                }
                else if (subj1 <= 75 && subj1 > 64)
                {
                    gde1.Text = "B";
                }
                else if (subj1 <= 65 && subj1 > 54)
                {
                    gde1.Text = "C";
                }
                else if (subj1 <= 55 && subj1 > 44)
                {
                    gde1.Text = "D";
                }
                else if (subj1 <= 45 && subj1 > 33)
                {
                    gde1.Text = "E";
                }
                else
                {
                    gde1.Text = "F";
                }

                // Grade 2
                if (subj2 <= 100 && subj2 > 84)
                {
                    gde2.Text = "A+";
                }
                else if (subj2 <= 85 && subj2 > 74)
                {
                    gde2.Text = "A";
                }
                else if (subj2 <= 75 && subj2 > 64)
                {
                    gde2.Text = "B";
                }
                else if (subj2 <= 65 && subj2 > 54)
                {
                    gde2.Text = "C";
                }
                else if (subj2 <= 55 && subj2 > 44)
                {
                    gde2.Text = "D";
                }
                else if (subj2 <= 45 && subj2 > 33)
                {
                    gde2.Text = "E";
                }
                else
                {
                    gde2.Text = "F";
                }

                // Grade 3
                if (subj3 <= 100 && subj3 > 84)
                {
                    gde3.Text = "A+";
                }
                else if (subj3 <= 85 && subj3 > 74)
                {
                    gde3.Text = "A";
                }
                else if (subj3 <= 75 && subj3 > 64)
                {
                    gde3.Text = "B";
                }
                else if (subj3 <= 65 && subj3 > 54)
                {
                    gde3.Text = "C";
                }
                else if (subj3 <= 55 && subj3 > 44)
                {
                    gde3.Text = "D";
                }
                else if (subj3 <= 45 && subj3 > 33)
                {
                    gde3.Text = "E";
                }
                else
                {
                    gde3.Text = "F";
                }

                // Grade 4
                if (subj4 <= 100 && subj4 > 84)
                {
                    gde4.Text = "A+";
                }
                else if (subj4 <= 85 && subj4 > 74)
                {
                    gde4.Text = "A";
                }
                else if (subj4 <= 75 && subj4 > 64)
                {
                    gde4.Text = "B";
                }
                else if (subj4 <= 65 && subj4 > 54)
                {
                    gde4.Text = "C";
                }
                else if (subj4 <= 55 && subj4 > 44)
                {
                    gde4.Text = "D";
                }
                else if (subj4 <= 45 && subj4 > 33)
                {
                    gde4.Text = "E";
                }
                else
                {
                    gde4.Text = "F";
                }

                // Grade 5
                if (subj5 <= 100 && subj5 > 84)
                {
                    gde5.Text = "A+";
                }
                else if (subj5 <= 85 && subj5 > 74)
                {
                    gde5.Text = "A";
                }
                else if (subj5 <= 75 && subj5 > 64)
                {
                    gde5.Text = "B";
                }
                else if (subj5 <= 65 && subj5 > 54)
                {
                    gde5.Text = "C";
                }
                else if (subj5 <= 55 && subj5 > 44)
                {
                    gde5.Text = "D";
                }
                else if (subj5 <= 45 && subj5 > 33)
                {
                    gde5.Text = "E";
                }
                else
                {
                    gde5.Text = "F";
                }

                // Grade 6
                if (subj6 <= 100 && subj6 > 84)
                {
                    gde6.Text = "A+";
                }
                else if (subj6 <= 85 && subj6 > 74)
                {
                    gde6.Text = "A";
                }
                else if (subj6 <= 75 && subj6 > 64)
                {
                    gde6.Text = "B";
                }
                else if (subj6 <= 65 && subj6 > 54)
                {
                    gde6.Text = "C";
                }
                else if (subj6 <= 55 && subj6 > 44)
                {
                    gde6.Text = "D";
                }
                else if (subj6 <= 45 && subj6 > 33)
                {
                    gde6.Text = "E";
                }

                else
                {
                    gde6.Text = "F";
                }

            }
            else if (txtBoxRnumber.Text == "3" && txtBoxDep.Text == "bsse")
            {
                // Course Names
                lblsub1.Text = "Calculus";
                lblsub2.Text = "Computer Logic Design";
                lblsub3.Text = "Computer Science";
                lblsub4.Text = "Islamic Studies";
                lblsub5.Text = "English";
                lblsub6.Text = "Software Engineering";

                // Course Codes
                crsc1.Text = "SE-571";
                crsc2.Text = "SE-572";
                crsc3.Text = "SE-573";
                crsc4.Text = "SE-574";
                crsc5.Text = "SE-575";
                crsc6.Text = "SE-576";


                // Marks
                int subj1, subj2, subj3, subj4, subj5, subj6, total, totalp;
                string a = obtmarks1.Text;

                bool ans = int.TryParse(a, out subj1); // Stack Section

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 1 is Empty!");
                }
                a = obtmarks2.Text;

                ans = int.TryParse(a, out subj2);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 2 is Empty!");
                }
                a = obtmarks3.Text;

                ans = int.TryParse(a, out subj3);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 3 is Empty!");
                }
                a = obtmarks4.Text;

                ans = int.TryParse(a, out subj4);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 4 is Empty!");
                }
                a = obtmarks5.Text;

                ans = int.TryParse(a, out subj5);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 5 is Empty!");
                }
                a = obtmarks6.Text;

                ans = int.TryParse(a, out subj6);

                if (ans == true)
                {

                }
                else
                {
                    MessageBox.Show("Marks Box 6 is Empty!");
                }


                total = subj1 + subj2 + subj3 + subj4 + subj5 + subj6;

                // Percentage
                int totalperc;
                totalperc = (total * 100) / 600;
                if (subj1 <= 0 || subj1 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 1.");
                    per1.Text = "--";

                }
                else
                {
                    totalp = (subj1 * 100) / 100;
                    per1.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                    totalper.Text = totalperc.ToString();
                }

                if (subj2 <= 0 || subj2 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 2.");
                    per2.Text = "--";

                }
                else
                {
                    totalp = (subj2 * 100) / 100;
                    per2.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj3 <= 0 || subj3 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 3.");
                    per3.Text = "--";

                }
                else
                {
                    totalp = (subj3 * 100) / 100;
                    per3.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj4 <= 0 || subj4 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 4.");
                    per4.Text = "--";

                }
                else
                {
                    totalp = (subj4 * 100) / 100;
                    per4.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj5 <= 0 || subj5 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 5.");
                    per5.Text = "--";

                }
                else
                {
                    totalp = (subj5 * 100) / 100;
                    per5.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }

                if (subj6 <= 0 || subj6 >= 101)
                {
                    MessageBox.Show("Wrong Marks Input in Subject 6.");
                    per6.Text = "--";

                }
                else
                {
                    totalp = (subj6 * 100) / 100;
                    per6.Text = Convert.ToString(totalp);
                    lbltotal.Text = total.ToString();
                }


                // Grades 
                // Total Grade Sec
                if (totalperc <= 100 && totalperc > 89)
                {
                    totalgde.Text = "A+";
                }
                else if (totalperc <= 85 && totalperc > 74)
                {
                    totalgde.Text = "A";
                }
                else if (totalperc <= 75 && totalperc > 64)
                {
                    totalgde.Text = "B";
                }
                else if (totalperc <= 65 && totalperc > 54)
                {
                    totalgde.Text = "C";
                }
                else if (totalperc <= 55 && totalperc > 44)
                {
                    totalgde.Text = "D";
                }
                else if (totalperc <= 45 && totalperc > 33)
                {
                    totalgde.Text = "E";
                }
                else
                {
                    totalgde.Text = "F";
                }
                // Grade 1
                if (subj1 <= 100 && subj1 > 84)
                {
                    gde1.Text = "A+";
                }
                else if (subj1 <= 85 && subj1 > 74)
                {
                    gde1.Text = "A";
                }
                else if (subj1 <= 75 && subj1 > 64)
                {
                    gde1.Text = "B";
                }
                else if (subj1 <= 65 && subj1 > 54)
                {
                    gde1.Text = "C";
                }
                else if (subj1 <= 55 && subj1 > 44)
                {
                    gde1.Text = "D";
                }
                else if (subj1 <= 45 && subj1 > 33)
                {
                    gde1.Text = "E";
                }
                else
                {
                    gde1.Text = "F";
                }

                // Grade 2
                if (subj2 <= 100 && subj2 > 84)
                {
                    gde2.Text = "A+";
                }
                else if (subj2 <= 85 && subj2 > 74)
                {
                    gde2.Text = "A";
                }
                else if (subj2 <= 75 && subj2 > 64)
                {
                    gde2.Text = "B";
                }
                else if (subj2 <= 65 && subj2 > 54)
                {
                    gde2.Text = "C";
                }
                else if (subj2 <= 55 && subj2 > 44)
                {
                    gde2.Text = "D";
                }
                else if (subj2 <= 45 && subj2 > 33)
                {
                    gde2.Text = "E";
                }
                else
                {
                    gde2.Text = "F";
                }

                // Grade 3
                if (subj3 <= 100 && subj3 > 84)
                {
                    gde3.Text = "A+";
                }
                else if (subj3 <= 85 && subj3 > 74)
                {
                    gde3.Text = "A";
                }
                else if (subj3 <= 75 && subj3 > 64)
                {
                    gde3.Text = "B";
                }
                else if (subj3 <= 65 && subj3 > 54)
                {
                    gde3.Text = "C";
                }
                else if (subj3 <= 55 && subj3 > 44)
                {
                    gde3.Text = "D";
                }
                else if (subj3 <= 45 && subj3 > 33)
                {
                    gde3.Text = "E";
                }
                else
                {
                    gde3.Text = "F";
                }

                // Grade 4
                if (subj4 <= 100 && subj4 > 84)
                {
                    gde4.Text = "A+";
                }
                else if (subj4 <= 85 && subj4 > 74)
                {
                    gde4.Text = "A";
                }
                else if (subj4 <= 75 && subj4 > 64)
                {
                    gde4.Text = "B";
                }
                else if (subj4 <= 65 && subj4 > 54)
                {
                    gde4.Text = "C";
                }
                else if (subj4 <= 55 && subj4 > 44)
                {
                    gde4.Text = "D";
                }
                else if (subj4 <= 45 && subj4 > 33)
                {
                    gde4.Text = "E";
                }
                else
                {
                    gde4.Text = "F";
                }

                // Grade 5
                if (subj5 <= 100 && subj5 > 84)
                {
                    gde5.Text = "A+";
                }
                else if (subj5 <= 85 && subj5 > 74)
                {
                    gde5.Text = "A";
                }
                else if (subj5 <= 75 && subj5 > 64)
                {
                    gde5.Text = "B";
                }
                else if (subj5 <= 65 && subj5 > 54)
                {
                    gde5.Text = "C";
                }
                else if (subj5 <= 55 && subj5 > 44)
                {
                    gde5.Text = "D";
                }
                else if (subj5 <= 45 && subj5 > 33)
                {
                    gde5.Text = "E";
                }
                else
                {
                    gde5.Text = "F";
                }

                // Grade 6
                if (subj6 <= 100 && subj6 > 84)
                {
                    gde6.Text = "A+";
                }
                else if (subj6 <= 85 && subj6 > 74)
                {
                    gde6.Text = "A";
                }
                else if (subj6 <= 75 && subj6 > 64)
                {
                    gde6.Text = "B";
                }
                else if (subj6 <= 65 && subj6 > 54)
                {
                    gde6.Text = "C";
                }
                else if (subj6 <= 55 && subj6 > 44)
                {
                    gde6.Text = "D";
                }
                else if (subj6 <= 45 && subj6 > 33)
                {
                    gde6.Text = "E";
                }

                else
                {
                    gde6.Text = "F";
                }

            }
            else
                MessageBox.Show("Wrong Input: Check Roll Number or Department!!"); 
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void gde3_Click(object sender, EventArgs e)
        {

        }

        private void obtmarks1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            
            if (txtBoxRnumber.Text == "1" && txtBoxDep.Text == "BSCS" || txtBoxDep.Text == "bscs")
            {
                buttonspan.Show();
                // BSCS
                lblsub1.Text = "Introduction to Computers";
                lblsub2.Text = "Mathematics";
                lblsub3.Text = "Statistics and Data Analysis";
                lblsub4.Text = "Physics";
                lblsub5.Text = "English";
                lblsub6.Text = "Islamic Learning";

                crsc1.Text = "CS-771";
                crsc2.Text = "CS-772";
                crsc3.Text = "CS-773";
                crsc4.Text = "CS-774";
                crsc5.Text = "CS-775";
                crsc6.Text = "CS-776";
            }
            else if (txtBoxRnumber.Text == "2" && txtBoxDep.Text == "BSIT" || txtBoxDep.Text == "bsit")
            {
                buttonspan.Show();
                lblsub1.Text = "Information and Comm. Tech";
                lblsub2.Text = "Programming Fundamentals";
                lblsub3.Text = "Calculus";
                lblsub4.Text = "Basic Electronics";
                lblsub5.Text = "English";
                lblsub6.Text = "Uni Electives";

                // Course Code
                crsc1.Text = "IT-851";
                crsc2.Text = "IT-852";
                crsc3.Text = "IT-853";
                crsc4.Text = "IT-854";
                crsc5.Text = "IT-855";
                crsc6.Text = "IT-856";
            }
            else if (txtBoxRnumber.Text == "3" && txtBoxDep.Text == "BSSE" || txtBoxDep.Text == "bsse")
            {
                buttonspan.Show();
                lblsub1.Text = "Calculus";
                lblsub2.Text = "Computer Logic Design";
                lblsub3.Text = "Computer Science";
                lblsub4.Text = "Islamic Studies";
                lblsub5.Text = "English";
                lblsub6.Text = "Software Engineering";

                // Course Codes
                crsc1.Text = "SE-571";
                crsc2.Text = "SE-572";
                crsc3.Text = "SE-573";
                crsc4.Text = "SE-574";
                crsc5.Text = "SE-575";
                crsc6.Text = "SE-576";
            }
            else {
                MessageBox.Show("Wrong Registration no. or Department.");
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeah! It's working. A new User Component can be added here.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This one's working too.");
        }
    }
    }

