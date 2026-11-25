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
            lbx_itemDisplay = new ListBox();
            SignInBtn = new Button();
            label1 = new Label();
            Search = new TextBox();
            btn_createItem = new Button();
            btn_modifyItem = new Button();
            btn_viewItem = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lbx_itemDisplay
            // 
            lbx_itemDisplay.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbx_itemDisplay.FormattingEnabled = true;
            lbx_itemDisplay.Location = new Point(17, 143);
            lbx_itemDisplay.Margin = new Padding(4, 5, 4, 5);
            lbx_itemDisplay.Name = "lbx_itemDisplay";
            lbx_itemDisplay.Size = new Size(764, 202);
            lbx_itemDisplay.TabIndex = 0;
            // 
            // SignInBtn
            // 
            SignInBtn.Location = new Point(17, 48);
            SignInBtn.Margin = new Padding(4, 5, 4, 5);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(107, 38);
            SignInBtn.TabIndex = 1;
            SignInBtn.Text = "Sign In";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(17, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(286, 0, 286, 0);
            label1.Size = new Size(775, 27);
            label1.TabIndex = 2;
            label1.Text = "Item Accessibility Status";
            label1.Click += label1_Click;
            // 
            // Search
            // 
            Search.Location = new Point(564, 48);
            Search.Margin = new Padding(4, 5, 4, 5);
            Search.Name = "Search";
            Search.Size = new Size(217, 31);
            Search.TabIndex = 3;
            // 
            // btn_createItem
            // 
            btn_createItem.Location = new Point(17, 360);
            btn_createItem.Margin = new Padding(4, 5, 4, 5);
            btn_createItem.Name = "btn_createItem";
            btn_createItem.Size = new Size(154, 38);
            btn_createItem.TabIndex = 4;
            btn_createItem.Text = "Create Item";
            btn_createItem.UseVisualStyleBackColor = true;
            btn_createItem.Click += button1_Click_2;
            // 
            // btn_modifyItem
            // 
            btn_modifyItem.Location = new Point(221, 360);
            btn_modifyItem.Margin = new Padding(4, 5, 4, 5);
            btn_modifyItem.Name = "btn_modifyItem";
            btn_modifyItem.Size = new Size(154, 38);
            btn_modifyItem.TabIndex = 5;
            btn_modifyItem.Text = "Modify Item";
            btn_modifyItem.UseVisualStyleBackColor = true;
            // 
            // btn_viewItem
            // 
            btn_viewItem.Location = new Point(426, 360);
            btn_viewItem.Margin = new Padding(4, 5, 4, 5);
            btn_viewItem.Name = "btn_viewItem";
            btn_viewItem.Size = new Size(154, 38);
            btn_viewItem.TabIndex = 6;
            btn_viewItem.Text = "View Item Details";
            btn_viewItem.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(629, 360);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(154, 38);
            button4.TabIndex = 7;
            button4.Text = "Main Menu";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(btn_viewItem);
            Controls.Add(btn_modifyItem);
            Controls.Add(btn_createItem);
            Controls.Add(Search);
            Controls.Add(label1);
            Controls.Add(SignInBtn);
            Controls.Add(lbx_itemDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx_itemDisplay;
        private Button SignInBtn;
        private Label label1;
        private TextBox Search;
        private Button btn_createItem;
        private Button btn_modifyItem;
        private Button btn_viewItem;
        private Button button4;
    }
}
