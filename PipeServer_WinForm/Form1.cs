﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;

namespace PipeServer_WinForm
{
    public partial class Form1 : Form
    {
        NamedPipeServerStream pipeServer;

        public Form1()
        {
            InitializeComponent();

            lbInfo.Text = "This is server side.\nClick Connect to set up connection";

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            try
            {
                // Read user input from the console and sends that to the client process.
                using (StreamWriter sw = new StreamWriter(pipeServer))
                {
                    sw.AutoFlush = true;
                    sw.WriteLine(tbInput.Text.ToString());
                }
            }
            // Catch the IOException that is raised if the pipe is broken or disconnected.
            catch (IOException ex) 
            {
                lbInfo.Text += "ERROR: " + ex.Message;
            }



            lbState.Text = "Message sent. If you want to send again please click \"Connect\" again.";

            //Enable the "Send" button
            btnSend.Enabled = false;

        }

        private void lbInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (pipeServer != null)
            {
                pipeServer.Close();
            }
            pipeServer = new NamedPipeServerStream("testpipe", PipeDirection.Out);
            lbState.Text += "\nNamedPipeServerStream object has been created.";

            lbState.Text = "\nWaiting for client connection...";
            // Wait for a client to connect

            pipeServer.WaitForConnection();

            if (pipeServer.IsConnected)
            {
                lbState.Text += "\nClient connected.";
                lbState.Text += "\nEnter text.";
            }

            //Disable the button in case for causing "close pipe" exception
            btnSend.Enabled = true;





        }

        private void lbState_Click(object sender, EventArgs e)
        {

        }
    }
}
