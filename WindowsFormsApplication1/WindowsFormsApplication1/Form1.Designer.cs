namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textUserId = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textGetUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textGetResolt = new System.Windows.Forms.TextBox();
            this.labResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textUserId
            // 
            this.textUserId.Location = new System.Drawing.Point(59, 33);
            this.textUserId.Name = "textUserId";
            this.textUserId.Size = new System.Drawing.Size(100, 20);
            this.textUserId.TabIndex = 2;
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(59, 77);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(100, 20);
            this.textTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "title";
            // 
            // textGetUserId
            // 
            this.textGetUserId.Location = new System.Drawing.Point(59, 213);
            this.textGetUserId.Name = "textGetUserId";
            this.textGetUserId.Size = new System.Drawing.Size(75, 20);
            this.textGetUserId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "userID";
            // 
            // textGetResolt
            // 
            this.textGetResolt.Location = new System.Drawing.Point(59, 269);
            this.textGetResolt.Multiline = true;
            this.textGetResolt.Name = "textGetResolt";
            this.textGetResolt.Size = new System.Drawing.Size(528, 282);
            this.textGetResolt.TabIndex = 8;
            // 
            // labResponse
            // 
            this.labResponse.AutoSize = true;
            this.labResponse.Location = new System.Drawing.Point(220, 33);
            this.labResponse.Name = "labResponse";
            this.labResponse.Size = new System.Drawing.Size(61, 13);
            this.labResponse.TabIndex = 9;
            this.labResponse.Text = "Response: ";
            this.labResponse.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 624);
            this.Controls.Add(this.labResponse);
            this.Controls.Add(this.textGetResolt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textGetUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.textUserId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textUserId;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGetUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textGetResolt;
        private System.Windows.Forms.Label labResponse;
    }
}

