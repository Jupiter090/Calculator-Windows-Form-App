
namespace WindowsFormsApp1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.number1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.previouse_result = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.number1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.number1.Location = new System.Drawing.Point(38, 234);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(67, 65);
            this.number1.TabIndex = 99999;
            this.number1.TabStop = false;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.onNumberBtnClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(111, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 65);
            this.button2.TabIndex = 99999;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onNumberBtnClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(184, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 65);
            this.button3.TabIndex = 99999;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onNumberBtnClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button4.Location = new System.Drawing.Point(257, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 65);
            this.button4.TabIndex = 99999;
            this.button4.TabStop = false;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onOperationBtnClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button5.Location = new System.Drawing.Point(38, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 65);
            this.button5.TabIndex = 99999;
            this.button5.TabStop = false;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.onNumberBtnClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button6.Location = new System.Drawing.Point(111, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 65);
            this.button6.TabIndex = 99999;
            this.button6.TabStop = false;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.onNumberBtnClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button7.Location = new System.Drawing.Point(184, 305);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 65);
            this.button7.TabIndex = 99999;
            this.button7.TabStop = false;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.onNumberBtnClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button8.Location = new System.Drawing.Point(257, 305);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 65);
            this.button8.TabIndex = 7;
            this.button8.TabStop = false;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.onOperationBtnClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button9.Location = new System.Drawing.Point(38, 377);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 65);
            this.button9.TabIndex = 8;
            this.button9.TabStop = false;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.onNumberBtnClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button10.Location = new System.Drawing.Point(111, 377);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 65);
            this.button10.TabIndex = 9;
            this.button10.TabStop = false;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.onNumberBtnClick);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button11.Location = new System.Drawing.Point(184, 377);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 65);
            this.button11.TabIndex = 10;
            this.button11.TabStop = false;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.onNumberBtnClick);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button12.Location = new System.Drawing.Point(257, 377);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 65);
            this.button12.TabIndex = 11;
            this.button12.TabStop = false;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.onOperationBtnClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(257, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 65);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onOperationBtnClick);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button13.Location = new System.Drawing.Point(184, 448);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(67, 65);
            this.button13.TabIndex = 13;
            this.button13.TabStop = false;
            this.button13.Text = "=";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.onResultBtnClick);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.result.Location = new System.Drawing.Point(52, 80);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 48);
            this.result.TabIndex = 14;
            // 
            // previouse_result
            // 
            this.previouse_result.AutoSize = true;
            this.previouse_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previouse_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.previouse_result.Location = new System.Drawing.Point(52, 30);
            this.previouse_result.Name = "previouse_result";
            this.previouse_result.Size = new System.Drawing.Size(0, 29);
            this.previouse_result.TabIndex = 15;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button14.Location = new System.Drawing.Point(111, 448);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(67, 65);
            this.button14.TabIndex = 16;
            this.button14.TabStop = false;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.onNumberBtnClick);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button15.Location = new System.Drawing.Point(38, 163);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(140, 65);
            this.button15.TabIndex = 17;
            this.button15.TabStop = false;
            this.button15.Text = "AC";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.onACBtnClick);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button16.Location = new System.Drawing.Point(184, 163);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(140, 65);
            this.button16.TabIndex = 18;
            this.button16.TabStop = false;
            this.button16.Text = "DEL";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.onDELBtnClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 115);
            this.panel1.TabIndex = 19;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(2, 1);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 0;
            this.button17.TabStop = false;
            this.button17.Text = "About";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button18.Location = new System.Drawing.Point(38, 448);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(67, 65);
            this.button18.TabIndex = 21;
            this.button18.TabStop = false;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.onDecimalPointBtnClick);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(83, 1);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 1;
            this.button19.TabStop = false;
            this.button19.Text = "End";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(362, 557);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.previouse_result);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 604);
            this.MinimumSize = new System.Drawing.Size(380, 604);
            this.Name = "Calculator";
            this.RightToLeftLayout = true;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyPressed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label previouse_result;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}

