using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string strId = textUserId.Text;
            string strName = textTitle.Text;

            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "user_id=" + strId;
            postData += ("&title=" + strName);
            MyWebRequest My = new MyWebRequest("http://zozatree.herokuapp.com/api/titles", "POST", postData);
            string HtmlResult = My.GetResponse();
            //wc.Headers["Content-type"] = "application/x-www-form-urlencoded";

            //string HtmlResult = wc.UploadString(URL, myParamters);

            string bodySeparator = "{";
            string[] stringSeparators = new string[] { bodySeparator };
            string[] splitBodey = HtmlResult.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            List<UserBO> u = new List<UserBO>();
            foreach (string item in splitBodey)
            {
                UserBO b = new UserBO(item.Replace("}",""));
                u.Add(b);
                if (b.UserId != -1)
                    labResponse.Text += b.toString();
            }
     
        
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
          
            string GetData = "user_id=" + textGetUserId.Text;
            MyWebRequest My = new MyWebRequest("http://zozatree.herokuapp.com/api/titles?" + GetData, "GET");

            string HtmlResult = My.GetResponse();

            string bodySeparator = "{";
            string[] stringSeparators = new string[] { bodySeparator };
            string[] splitBodey = HtmlResult.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            List<UserBO> u = new List<UserBO>();
            foreach (string item in splitBodey)
            {
                UserBO b = new UserBO(item.Replace("}", ""));
                u.Add(b);
                if(b.UserId!=-1)
                textGetResolt.Text += b.toString()+'\n';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
