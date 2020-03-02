using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q2
{
    public partial class CALCULATOR : System.Web.UI.Page
    {
        
        static char b;
        static float a, c,d;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button1.Text;

            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button1.Text;
            }          
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button2.Text;

            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button2.Text;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button3.Text;

            }
            else
            { TextBox1.Text = TextBox1.Text + Button3.Text;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button4.Text;

            }
            else
            { TextBox1.Text = TextBox1.Text + Button4.Text;
            }
        }


        protected void Button5_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button5.Text;

            }
            else
            { TextBox1.Text = TextBox1.Text + Button5.Text;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button6.Text;

            }
            else
            { TextBox1.Text = TextBox1.Text + Button6.Text;
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button7.Text;

            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button7.Text;
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button8.Text;

            }
            else
            {
                TextBox1.Text = TextBox1.Text + Button8.Text;
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button9.Text;

            }
            else
            { TextBox1.Text = TextBox1.Text + Button9.Text;
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {
                TextBox1.Text = "";
                TextBox1.Text = TextBox1.Text + Button10.Text;

            }
            else
            { TextBox1.Text = TextBox1.Text + Button10.Text;
            }
        }


        protected void add_Click(object sender, EventArgs e)
        {
            a= Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '+';
            TextBox1.Text += b;


        }

        protected void sub_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '-';
            TextBox1.Text += b;
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '*';
            TextBox1.Text += b;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void div_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            b = '/';
            TextBox1.Text += b;
        }

        protected void equal_Click(object sender, EventArgs e)
        {
            c = Convert.ToInt32(TextBox1.Text);
            TextBox1.Text = "";
            if(b=='+')
            {
                d = a + c;
                TextBox1.Text = TextBox1.Text + d;
                a = d;
            }

            else if (b == '-')
            {
                d = a - c;
                TextBox1.Text = TextBox1.Text + d;
                a = d;
            }
            else if (b == '*')
            {
                d = a * c;
                TextBox1.Text = TextBox1.Text + d;
                a = d;
            }
            else
            {
                    d = a / c;
                    TextBox1.Text = TextBox1.Text + d;
                    a = d;
                
                
            }
        }
    }
}