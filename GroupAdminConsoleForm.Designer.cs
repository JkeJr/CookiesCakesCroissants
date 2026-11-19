namespace CookiesCakesCroissants
{
    partial class GroupAdminConsoleForm
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
            btnPayes = new Button();
            SuspendLayout();
            // 
            // btnPayes
            // 
            btnPayes.Location = new Point(12, 158);
            btnPayes.Name = "btnPayes";
            btnPayes.Size = new Size(229, 158);
            btnPayes.TabIndex = 0;
            btnPayes.Text = "Scones N Sweets";
            btnPayes.UseVisualStyleBackColor = true;
            btnPayes.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPayes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPayes;
    }
}
