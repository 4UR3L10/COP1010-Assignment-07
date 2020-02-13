namespace University_Software
{
    partial class MainMenu
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
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.UpdateStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(150, 38);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(171, 50);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // UpdateStudentButton
            // 
            this.UpdateStudentButton.Location = new System.Drawing.Point(150, 106);
            this.UpdateStudentButton.Name = "UpdateStudentButton";
            this.UpdateStudentButton.Size = new System.Drawing.Size(171, 54);
            this.UpdateStudentButton.TabIndex = 1;
            this.UpdateStudentButton.Text = "Update Student";
            this.UpdateStudentButton.UseVisualStyleBackColor = true;
            this.UpdateStudentButton.Click += new System.EventHandler(this.UpdateStudentButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(150, 180);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(171, 54);
            this.DeleteStudentButton.TabIndex = 2;
            this.DeleteStudentButton.Text = "Delete Student";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.UpdateStudentButton);
            this.Controls.Add(this.AddStudentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button UpdateStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
    }
}

