namespace Milestone_5_Mockup
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
            listBox1 = new ListBox();
            SignInBtn = new Button();
            label1 = new Label();
            Search = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(536, 124);
            listBox1.TabIndex = 0;
            // 
            // SignInBtn
            // 
            SignInBtn.Location = new Point(12, 29);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(75, 23);
            SignInBtn.TabIndex = 1;
            SignInBtn.Text = "Sign In";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Padding = new Padding(200, 0, 200, 0);
            label1.Size = new Size(536, 17);
            label1.TabIndex = 2;
            label1.Text = "Item Accessibility Status";
            label1.Click += label1_Click;
            // 
            // Search
            // 
            Search.Location = new Point(395, 29);
            Search.Name = "Search";
            Search.Size = new Size(153, 23);
            Search.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 216);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 4;
            button1.Text = "Create Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.Location = new Point(155, 216);
            button2.Name = "button2";
            button2.Size = new Size(108, 23);
            button2.TabIndex = 5;
            button2.Text = "Modify Item";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(298, 216);
            button3.Name = "button3";
            button3.Size = new Size(108, 23);
            button3.TabIndex = 6;
            button3.Text = "View Item Details";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(440, 216);
            button4.Name = "button4";
            button4.Size = new Size(108, 23);
            button4.TabIndex = 7;
            button4.Text = "Main Menu";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Search);
            Controls.Add(label1);
            Controls.Add(SignInBtn);
            Controls.Add(listBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button SignInBtn;
        private Label label1;
        private TextBox Search;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
