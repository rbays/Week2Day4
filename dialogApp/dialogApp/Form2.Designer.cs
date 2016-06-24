namespace dialogApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.form2ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form2ReturnButton
            // 
            resources.ApplyResources(this.form2ReturnButton, "form2ReturnButton");
            this.form2ReturnButton.Name = "form2ReturnButton";
            this.form2ReturnButton.UseVisualStyleBackColor = true;
            this.form2ReturnButton.Click += new System.EventHandler(this.form2ReturnButton_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.form2ReturnButton);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button form2ReturnButton;
    }
}