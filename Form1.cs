using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Vigenère_s_cipher
{
    public partial class Form1 : Form
    {
        FileStream file = new FileStream("message.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        static char[] chars = new char[]{' ','!','"','#','$','%','&','\'','(',')','*','+',',','-','.','/','0',
            '1','2','3','4','5','6','7','8','9',':',';','<','=','>','?','@','A','Ą','B','C','Ć','D','E',
            'Ę','F','G','H','I','J','K','L','Ł','M','N','Ń','O','Ó','P','Q','R','S','Ś','T','U','V','W',
            'X','Y','Z','Ź','Ż','[','/',']','^','_','`','a','ą','b','c','ć','d','e','ę','f','g','h','i',
            'j','k','l','ł','m','n','ń','o','ó','p','q','r','s','ś','t','u','v','w','x','y','z','ź','ż',
            '{','|','}','~'}; //ASCII code combined with Polish diacritized letters

        static char[,] cryptogram = new char[chars.Length, chars.Length];
        static char[] password;
        static char[] passwordjob;
        static int[] p;
        static int[] m;
        static string message = "";
        static char[] messagechar;

        public Form1()
        {
            InitializeComponent();
            //create cryptogram
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (j + i < chars.Length)
                        cryptogram[i, j] = chars[j + i];
                    else
                        cryptogram[i, j] = chars[j + i - chars.Length];
                }
            }
            //draw a key
            Random r = new Random();
            for (int i = 0; i < r.Next(1, chars.Length); i++)
                tBPassword.Text += Convert.ToString(chars[r.Next(0, chars.Length)]);
        }

        private void Btngo_Click(object sender, EventArgs e)
        {
            //loading the message from the text field and saving it to a file
            if (rBText.Checked == true)
            {
                if (tBText.Text == "")
                {
                    Random r = new Random();
                    for (int i = 0; i < r.Next(1, chars.Length); i++)
                        tBText.Text += Convert.ToString(chars[r.Next(0, chars.Length)]);
                }
                message = tBText.Text;
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(message);
                sw.Close();
            }
            //loading a message from a file and saving it to the text field
            else if (rBFile.Checked==true)
            {
                StreamReader sr = new StreamReader(file);
                message = sr.ReadLine();
                sr.Close();
                tBText.Text = message;
            }
            messagechar = message.ToCharArray();
            //the key cannot be empty!!!
            if (tBPassword.Text == "")
            {
                //draw a key
                Random r = new Random();
                for (int i = 0; i < r.Next(1, chars.Length); i++)
                    tBPassword.Text += Convert.ToString(chars[r.Next(0, chars.Length)]);
            }
            passwordjob = tBPassword.Text.ToCharArray();
            password = new char[message.Length];
            //the length of the password must be equal to or greater than the message!!!
            if (passwordjob.Length < message.Length)
            {
                int x = 0;
                for(int i = 0; i < message.Length; i++)
                {
                    password[i] = passwordjob[x];
                    if (i < passwordjob.Length - 2) x++;
                    else if (i >= passwordjob.Length - 2 && x < passwordjob.Length - 1) x++;
                    else if (i >= passwordjob.Length - 2 && x >= passwordjob.Length - 1) x = 0;
                }
            }
            else for (int i = 0; i < message.Length; i++) password[i] = passwordjob[i];
            p = new int[message.Length];
            //the beginning of the algorithm
            m = new int[message.Length];
            for (int i = 0; i < messagechar.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (messagechar[i] == chars[j]) m[i] = j;
                    if (password[i] == chars[j])
                    {
                        p[i] = j;
                        //operation of "reversing" the password if there is decryption
                        if (rBD.Checked==true) p[i] = (chars.Length - p[i]) % chars.Length;
                    }
                }
            }
            for (int i = 0; i < messagechar.Length; i++) tBMessage.Text += Convert.ToString(cryptogram[m[i], p[i]]);
            //protection against the next operation
            gBSource.Enabled = false;
            gBOperation.Enabled = false;
            gBPassword.Enabled = false;
            tBText.Enabled = false;
        }

        //draw a key
        private void Btndraw_Click(object sender, EventArgs e)
        {
            tBPassword.Text = "";
            Random r = new Random();
            for (int i = 0; i < r.Next(1, chars.Length); i++) 
                tBPassword.Text += Convert.ToString(chars[r.Next(0, chars.Length)]);
        }

        //display the selected operation as the button text
        private void Operation(object sender, EventArgs e)
        {
            if (rBE.Checked == true) btngo.Text = rBE.Text;
            else if (rBD.Checked == true) btngo.Text = rBD.Text;
        }

        //select a message input method
        private void Selectsource(object sender, EventArgs e)
        {
            if (rBText.Checked == true) tBText.Enabled = true;
            else if (rBFile.Checked == true) tBText.Enabled = false;
        }
    }
}
