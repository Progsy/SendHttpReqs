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
                iterations = Int32.Parse(textBox1.Text);
                checkiterations();
            }
        }

        int iterations;
        int sentitemes = 0;
        void CreateRequest() 
        {
            try
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
                statlab.Text = ((HttpWebResponse)response).StatusDescription;

                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                sentitemes++;
                string responseFromServer = "Requests Sent: " + sentitemes.ToString() + "\n" + reader.ReadToEnd();
                serverrespBox.Text = responseFromServer;

                reader.Close();
                dataStream.Close();
                response.Close();
                checkiterations();
            }
            catch (Exception ex) 
            {
                serverrespBox.Text = ex.Message;
            }
        }

        void checkiterations() 
        {
            if (iterations > 0)
            {
                iterations -= 1;
                textBox1.Text = iterations.ToString();
                CreateRequest();
            }
        }
        Dictionary<string, WebRequest> requests;
        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string postData = reqpayloadBox.Text;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                WebRequest request = WebRequest.Create(urlBox.Text);
                request.UseDefaultCredentials = true;
                request.Method = "POST";
                request.ContentLength = byteArray.Length;
                request.ContentType = contenttypeBox.Text;

                savedreqs.Items.Add(request);
                requests.Add(textBox2.Text, request);
                foreach (var thing in requests) 
                {
                    savedreqs.Items.Add(thing.Key);
                }
            }
            catch (Exception ex) 
            {
                serverrespBox.Text = ex.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
