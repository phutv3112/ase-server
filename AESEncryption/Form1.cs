using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Net.Http;
using AESEncryption.Model;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using System.Net.Sockets;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;

namespace AESEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbAesKeySize.SelectedIndex = 0;
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        static void SendSocket(string filePath, string ip)
        {
            try
            {
                IPAddress address = IPAddress.Parse(ip);

                TcpListener listener = new TcpListener(address, 9999);

                // 1. listen
                listener.Start();

                Socket socket = listener.AcceptSocket();

                var stream = new NetworkStream(socket);
                
                byte[] buffer = File.ReadAllBytes(filePath); // Đọc dữ liệu từ file dưới dạng byte

                // 3. send
                stream.Write(buffer, 0, buffer.Length);
                // 4. close
                stream.Close();
                socket.Close();
                listener.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
        static void SendSocketKey(string key, string ip)
        {
            try
            {
                IPAddress address = IPAddress.Parse(ip); //"192.168.1.4"

                TcpListener listener = new TcpListener(address, 8888);

                // 1. listen
                listener.Start();

                Socket socket = listener.AcceptSocket();

                var stream = new NetworkStream(socket);
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                writer.WriteLine(key);
                
                // 4. close
                stream.Close();
                socket.Close();
                listener.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {

            try
            {
                AES.Encrypt(textBoxInput.Text, textBoxEncryptPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SendSocketKey(textBoxEncryptPassword.Text, textIP.Text);
            SendSocket("_encrypted.txt", textIP.Text);

        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //var data = Decrypt(textBoxEncrypted.Text, textBoxDcryptPassword.Text);
                //textBoxDecryptOutput.Text = data.StringEncryptOrDecrypt;
                //textTimeDecrypt.Text = data.DecrypEncryptTime.ToString("0.#############");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxEncryptPassword.Enabled = textBoxInput.Text.Length > 0;
            buttonEncrypt.Enabled = textBoxInput.Text.Length > 0;
        }

        private void textBoxEncryptPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxInput.Enabled = textBoxInput.Text.Length > 0;
            buttonEncrypt.Enabled = textBoxInput.Text.Length > 0;

        }

        private void textBoxEncrypted_TextChanged(object sender, EventArgs e)
        {
            //textBoxDcryptPassword.Enabled = textBoxEncrypted.Text.Length > 0;
            //buttonDecrypt.Enabled = textBoxEncrypted.Text.Length > 0;
        }

        private void textBoxDcryptPassword_TextChanged(object sender, EventArgs e)
        {
            //textBoxEncrypted.Enabled = textBoxEncrypted.Text.Length > 0;
            //buttonDecrypt.Enabled = textBoxEncrypted.Text.Length > 0;
        }


        private void textBoxEncryptPassword_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBoxInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (textBoxInput.Text.Length > 0)
            {
                byte[] InputBytes = Encoding.UTF8.GetBytes(textBoxInput.Text);
                textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
            }
        }

        private void textBoxEncryptPassword_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (textBoxEncryptPassword.Text.Length > 0)
            {
                byte[] InputBytes = Encoding.UTF8.GetBytes(textBoxEncryptPassword.Text);
                textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
            }
        }

        //private void textBoxEncryptedOutput_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (textBoxEncryptedOutput.Text.Length > 0)
        //    {
        //        byte[] InputBytes = Convert.FromBase64String(textBoxEncryptedOutput.Text);
        //        textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
        //    }
        //}

        //private void textBoxEncrypted_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    byte[] InputBytes = Convert.FromBase64String(textBoxEncrypted.Text);
        //    textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
        //}

        //private void textBoxDcryptPassword_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (textBoxDcryptPassword.Text.Length > 0)
        //    {
        //        byte[] InputBytes = Encoding.UTF8.GetBytes(textBoxDcryptPassword.Text);
        //        textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", "");
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxInput.Text = openFile.FileName;
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string randomString = "";

            int length = 16;
            int keySize=int.Parse(cbAesKeySize.Text);
            if (keySize == 128)
            {
                length = 16;
            }else if (keySize == 192)
            {
                length = 24;
            }
            else
            {
                length = 32;
            }
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            for (int i = 0; i < length; i++)
            {
                randomString += chars[random.Next(chars.Length)];
            }
            textBoxEncryptPassword.Text = randomString;
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFile = new OpenFileDialog();
        //    if (openFile.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            using (StreamReader sr = new StreamReader(openFile.FileName))
        //            {
        //                string content = sr.ReadToEnd();
        //                textBoxEncrypted.Text = content;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //    };
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxEncryptPassword.Text = "";
            textBoxInput.Text = "";
            
            //textBoxDcryptPassword.Text = "";
            //textBoxDecryptOutput.Text = "";
            //textBoxEncrypted.Text = "";
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFile = new OpenFileDialog();
        //    if (openFile.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            using (StreamReader sr = new StreamReader(openFile.FileName))
        //            {
        //                string content = sr.ReadToEnd();
        //                textBoxDcryptPassword.Text = content;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //    };
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEncryptedOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDecryptOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbAesKeySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int keySize=int.Parse(cbAesKeySize.Text);
            if(keySize == 128)
            {
                label2.Text = "Provide password to use for encryption (16 chars)";
                textBoxEncryptPassword.MaxLength = 16;
            }else if(keySize == 192) 
            {
                label2.Text = "Provide password to use for encryption (24 chars)";
                textBoxEncryptPassword.MaxLength = 24;
            }
            else
            {
                label2.Text = "Provide password to use for encryption (32 chars)";
                textBoxEncryptPassword.MaxLength = 32;
            }
            
        }
    }
}
