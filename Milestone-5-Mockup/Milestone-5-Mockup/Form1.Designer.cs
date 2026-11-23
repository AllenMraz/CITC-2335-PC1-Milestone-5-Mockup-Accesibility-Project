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
            SuspendLayout();
            // 
            // lbx_itemDisplay
            // 
            lbx_itemDisplay.FormattingEnabled = true;
            lbx_itemDisplay.Location = new Point(105, 92);
            lbx_itemDisplay.Name = "lbx_itemDisplay";
            lbx_itemDisplay.Size = new Size(556, 179);
            lbx_itemDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbx_itemDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbx_itemDisplay;
    }
}
