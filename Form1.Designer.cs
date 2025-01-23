namespace TemperatureConverterLesson
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
            this.lbl_Input = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Separator = new System.Windows.Forms.Button();
            this.cb_Input = new System.Windows.Forms.ComboBox();
            this.cb_Output = new System.Windows.Forms.ComboBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Input.ForeColor = System.Drawing.Color.White;
            this.lbl_Input.Location = new System.Drawing.Point(142, 92);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(137, 16);
            this.lbl_Input.TabIndex = 0;
            this.lbl_Input.Text = "Placeholder Label Input";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.White;
            this.lbl_Output.Location = new System.Drawing.Point(142, 298);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(147, 16);
            this.lbl_Output.TabIndex = 1;
            this.lbl_Output.Text = "Placeholder Label Output";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Gray;
            this.btn_Clear.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(528, 336);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(49, 48);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_1.ForeColor = System.Drawing.Color.Black;
            this.btn_1.Location = new System.Drawing.Point(528, 174);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(50, 48);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_2.Location = new System.Drawing.Point(584, 174);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(50, 48);
            this.btn_2.TabIndex = 4;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_3.Location = new System.Drawing.Point(640, 174);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(50, 48);
            this.btn_3.TabIndex = 5;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_4.Location = new System.Drawing.Point(528, 228);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(50, 48);
            this.btn_4.TabIndex = 6;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_5.Location = new System.Drawing.Point(584, 228);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(50, 48);
            this.btn_5.TabIndex = 7;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_6.Location = new System.Drawing.Point(640, 228);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(50, 48);
            this.btn_6.TabIndex = 8;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_7.Location = new System.Drawing.Point(528, 282);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(50, 48);
            this.btn_7.TabIndex = 9;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_8.Location = new System.Drawing.Point(584, 282);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(50, 48);
            this.btn_8.TabIndex = 10;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_9.Location = new System.Drawing.Point(640, 282);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(50, 48);
            this.btn_9.TabIndex = 11;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_0.Location = new System.Drawing.Point(584, 336);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(50, 48);
            this.btn_0.TabIndex = 12;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // btn_Separator
            // 
            this.btn_Separator.BackColor = System.Drawing.Color.Gray;
            this.btn_Separator.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Separator.ForeColor = System.Drawing.Color.White;
            this.btn_Separator.Location = new System.Drawing.Point(640, 336);
            this.btn_Separator.Name = "btn_Separator";
            this.btn_Separator.Size = new System.Drawing.Size(50, 48);
            this.btn_Separator.TabIndex = 13;
            this.btn_Separator.Text = ".";
            this.btn_Separator.UseVisualStyleBackColor = false;
            this.btn_Separator.Click += new System.EventHandler(this.btn_InputClick);
            // 
            // cb_Input
            // 
            this.cb_Input.FormattingEnabled = true;
            this.cb_Input.Location = new System.Drawing.Point(144, 130);
            this.cb_Input.Name = "cb_Input";
            this.cb_Input.Size = new System.Drawing.Size(121, 21);
            this.cb_Input.TabIndex = 14;
            // 
            // cb_Output
            // 
            this.cb_Output.FormattingEnabled = true;
            this.cb_Output.Location = new System.Drawing.Point(144, 336);
            this.cb_Output.Name = "cb_Output";
            this.cb_Output.Size = new System.Drawing.Size(121, 21);
            this.cb_Output.TabIndex = 15;
            // 
            // btn_Convert
            // 
            this.btn_Convert.BackColor = System.Drawing.Color.Gray;
            this.btn_Convert.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Convert.ForeColor = System.Drawing.Color.White;
            this.btn_Convert.Location = new System.Drawing.Point(528, 125);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(162, 43);
            this.btn_Convert.TabIndex = 17;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = false;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.cb_Output);
            this.Controls.Add(this.cb_Input);
            this.Controls.Add(this.btn_Separator);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Separator;
        private System.Windows.Forms.ComboBox cb_Input;
        private System.Windows.Forms.ComboBox cb_Output;
        private System.Windows.Forms.Button btn_Convert;
    }
}

