namespace MyCalculatorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button18 = new Button();
            button20 = new Button();
            textBox_Results = new TextBox();
            label1 = new Label();
            button11 = new Button();
            CurrentOperation = new Label();
            listBoxHistory = new ListBox();
            ButtonHistory = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 135);
            button1.Name = "button1";
            button1.Size = new Size(73, 61);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(101, 135);
            button2.Name = "button2";
            button2.Size = new Size(73, 61);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(180, 135);
            button3.Name = "button3";
            button3.Size = new Size(73, 61);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(259, 135);
            button4.Name = "button4";
            button4.Size = new Size(73, 61);
            button4.TabIndex = 3;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += operator_click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(338, 135);
            button5.Name = "button5";
            button5.Size = new Size(73, 61);
            button5.TabIndex = 4;
            button5.Text = "CE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnClear_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonShadow;
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(338, 202);
            button6.Name = "button6";
            button6.Size = new Size(73, 61);
            button6.TabIndex = 9;
            button6.Text = "C";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnClearEntry_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLight;
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(259, 202);
            button7.Name = "button7";
            button7.Size = new Size(73, 61);
            button7.TabIndex = 8;
            button7.Text = "*";
            button7.UseVisualStyleBackColor = false;
            button7.Click += operator_click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(180, 202);
            button8.Name = "button8";
            button8.Size = new Size(73, 61);
            button8.TabIndex = 7;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(101, 202);
            button9.Name = "button9";
            button9.Size = new Size(73, 61);
            button9.TabIndex = 6;
            button9.Text = "5";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(22, 202);
            button10.Name = "button10";
            button10.Size = new Size(73, 61);
            button10.TabIndex = 5;
            button10.Text = "4";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Button_click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ControlLight;
            button12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(259, 269);
            button12.Name = "button12";
            button12.Size = new Size(73, 61);
            button12.TabIndex = 13;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = false;
            button12.Click += operator_click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.Location = new Point(180, 269);
            button13.Name = "button13";
            button13.Size = new Size(73, 61);
            button13.TabIndex = 12;
            button13.Text = "3";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Button_click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.Location = new Point(101, 269);
            button14.Name = "button14";
            button14.Size = new Size(73, 61);
            button14.TabIndex = 11;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Button_click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.Location = new Point(22, 269);
            button15.Name = "button15";
            button15.Size = new Size(73, 61);
            button15.TabIndex = 10;
            button15.Text = "1";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Button_click;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.ActiveCaption;
            button16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.Location = new Point(338, 269);
            button16.Name = "button16";
            button16.Size = new Size(73, 128);
            button16.TabIndex = 19;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = false;
            button16.Click += btnEquals_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(180, 336);
            button18.Name = "button18";
            button18.Size = new Size(73, 61);
            button18.TabIndex = 17;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = true;
            button18.Click += Button_click;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button20.Location = new Point(22, 336);
            button20.Name = "button20";
            button20.Size = new Size(152, 61);
            button20.TabIndex = 15;
            button20.Text = "0";
            button20.UseVisualStyleBackColor = true;
            button20.Click += Button_click;
            // 
            // textBox_Results
            // 
            textBox_Results.BackColor = SystemColors.HighlightText;
            textBox_Results.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Results.Location = new Point(22, 65);
            textBox_Results.Name = "textBox_Results";
            textBox_Results.Size = new Size(389, 38);
            textBox_Results.TabIndex = 20;
            textBox_Results.Text = "0";
            textBox_Results.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(102, 26);
            label1.TabIndex = 21;
            label1.Text = "Standard";
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ControlLight;
            button11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(259, 336);
            button11.Name = "button11";
            button11.Size = new Size(73, 61);
            button11.TabIndex = 22;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = false;
            button11.Click += operator_click;
            // 
            // CurrentOperation
            // 
            CurrentOperation.AutoSize = true;
            CurrentOperation.Location = new Point(350, 42);
            CurrentOperation.Name = "CurrentOperation";
            CurrentOperation.Size = new Size(0, 20);
            CurrentOperation.TabIndex = 23;
            // 
            // listBoxHistory
            // 
            listBoxHistory.BackColor = SystemColors.ButtonFace;
            listBoxHistory.BorderStyle = BorderStyle.None;
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.Location = new Point(22, 109);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(124, 20);
            listBoxHistory.TabIndex = 24;
            // 
            // ButtonHistory
            // 
            ButtonHistory.Image = (Image)resources.GetObject("ButtonHistory.Image");
            ButtonHistory.Location = new Point(385, 12);
            ButtonHistory.Name = "ButtonHistory";
            ButtonHistory.Size = new Size(28, 28);
            ButtonHistory.TabIndex = 25;
            ButtonHistory.UseVisualStyleBackColor = true;
            ButtonHistory.Click += ButtonHistory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 417);
            Controls.Add(ButtonHistory);
            Controls.Add(listBoxHistory);
            Controls.Add(CurrentOperation);
            Controls.Add(button11);
            Controls.Add(label1);
            Controls.Add(textBox_Results);
            Controls.Add(button16);
            Controls.Add(button18);
            Controls.Add(button20);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(445, 464);
            MinimumSize = new Size(445, 464);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button18;
        private Button button20;
        private TextBox textBox_Results;
        private Label label1;
        private Button button11;
        private Label CurrentOperation;
        private ListBox listBoxHistory;
        private Button ButtonHistory;
    }
}
