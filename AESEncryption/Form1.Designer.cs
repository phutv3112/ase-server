
namespace AESEncryption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxInput = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            buttonExit = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            textBoxEncryptPassword = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            textIP = new System.Windows.Forms.TextBox();
            cbAesKeySize = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            buttonEncrypt = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            button5 = new System.Windows.Forms.Button();
            textBoxDebug = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxInput.Location = new System.Drawing.Point(8, 46);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new System.Drawing.Size(523, 27);
            textBoxInput.TabIndex = 0;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            textBoxInput.MouseDoubleClick += textBoxInput_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(8, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(147, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter plain input text";
            // 
            // buttonExit
            // 
            buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonExit.Location = new System.Drawing.Point(602, 281);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(94, 28);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(8, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(335, 20);
            label2.TabIndex = 4;
            label2.Text = "Provide password to use for encryption (16 chars)";
            // 
            // textBoxEncryptPassword
            // 
            textBoxEncryptPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxEncryptPassword.Location = new System.Drawing.Point(8, 109);
            textBoxEncryptPassword.MaxLength = 32;
            textBoxEncryptPassword.Name = "textBoxEncryptPassword";
            textBoxEncryptPassword.Size = new System.Drawing.Size(390, 27);
            textBoxEncryptPassword.TabIndex = 3;
            textBoxEncryptPassword.TextChanged += textBoxEncryptPassword_TextChanged;
            textBoxEncryptPassword.Leave += textBoxEncryptPassword_Leave;
            textBoxEncryptPassword.MouseDoubleClick += textBoxEncryptPassword_MouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textIP);
            groupBox1.Controls.Add(cbAesKeySize);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxEncryptPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxInput);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(13, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(775, 208);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Encryption";
            // 
            // textIP
            // 
            textIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textIP.Location = new System.Drawing.Point(10, 171);
            textIP.MaxLength = 32;
            textIP.Name = "textIP";
            textIP.Size = new System.Drawing.Size(521, 27);
            textIP.TabIndex = 9;
            // 
            // cbAesKeySize
            // 
            cbAesKeySize.FormattingEnabled = true;
            cbAesKeySize.Items.AddRange(new object[] { "128", "192", "256" });
            cbAesKeySize.Location = new System.Drawing.Point(404, 108);
            cbAesKeySize.Name = "cbAesKeySize";
            cbAesKeySize.Size = new System.Drawing.Size(127, 27);
            cbAesKeySize.TabIndex = 8;
            cbAesKeySize.SelectedIndexChanged += cbAesKeySize_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(568, 105);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(115, 29);
            button2.TabIndex = 6;
            button2.Text = "Generate Key";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(568, 46);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 29);
            button1.TabIndex = 5;
            button1.Text = "Plaintext";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Enabled = false;
            buttonEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonEncrypt.Location = new System.Drawing.Point(450, 281);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new System.Drawing.Size(94, 28);
            buttonEncrypt.TabIndex = 8;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(23, 175);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 20);
            label5.TabIndex = 10;
            label5.Text = "Client IP Address";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(319, 281);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(94, 28);
            button5.TabIndex = 14;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBoxDebug
            // 
            textBoxDebug.Location = new System.Drawing.Point(10, 33);
            textBoxDebug.Name = "textBoxDebug";
            textBoxDebug.ReadOnly = true;
            textBoxDebug.Size = new System.Drawing.Size(747, 26);
            textBoxDebug.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxDebug);
            groupBox3.Location = new System.Drawing.Point(12, 345);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(775, 73);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Double click inside any field above to see its value in bytes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 429);
            Controls.Add(button5);
            Controls.Add(groupBox3);
            Controls.Add(label5);
            Controls.Add(buttonEncrypt);
            Controls.Add(groupBox1);
            Controls.Add(buttonExit);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Encryption AES";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEncryptPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbAesKeySize;
        private System.Windows.Forms.TextBox textBoxDebug;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textIP;
    }
}

