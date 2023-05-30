using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public class Captcha
    {
        
        string captcha = "";

        public Captcha()
        {
            captcha = "";
        }
        public string LoadCaptcha()
        {
            int number = 0;
            Random refresh = new Random();
            number = refresh.Next(5, 6);
            int capnum = 0;

            captcha = "";
            do
            {
                
                int chr = refresh.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 97 && chr <= 123) || (chr >= 65 && chr <= 90))
                {
                    captcha = captcha + (char)chr;
                    capnum++;
                    if (capnum == number)
                        break;

                }
            }
            while (true);
            //lbl.Text = captcha.ToString();
            return captcha.ToString();

        }

        public bool captchacheck(string user_captcha)

        {
            if (captcha != user_captcha)
            {

                //MessageBox.Show("Please enter the CAPTCHA correctly.");
                //txt_captcha.BackColor = Color.OrangeRed;
                //txt_captcha.Focus();
                return false;
            }
            else
            {
                //MessageBox.Show(" CAPTCHA meets correctly.");
                return true;
                //Login sign_in = new Login(textBox1.Text, textBox2.Text, textBox3.Text);
            }
        }
    }
}
