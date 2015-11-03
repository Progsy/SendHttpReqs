using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendHttpReqs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendReqButton_Click(object sender, EventArgs e)
        {
            if (urlBox.Text != null && urlBox.Text != "") 
            {
                CreateRequest();
            }
        }

        void CreateRequest() 
        {
            string postData = reqpayloadBox.Text;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            WebRequest request = WebRequest.Create(urlBox.Text);
            request.UseDefaultCredentials = true;
            request.Method = "POST";
            request.ContentLength = byteArray.Length;
            request.ContentType = contenttypeBox.Text;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();
            responseBox.Text = ((HttpWebResponse)response).StatusDescription;

            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            serverrespBox.Text = responseFromServer;

            reader.Close();
            dataStream.Close();
            response.Close();
        }
    }
}
