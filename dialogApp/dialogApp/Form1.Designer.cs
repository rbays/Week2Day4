namespace dialogApp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textOutputBox = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBox = new System.Windows.Forms.GroupBox();
            this.textColorButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.closeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.buttonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.2434F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.7566F));
            this.tableLayoutPanel1.Controls.Add(this.textOutputBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.69444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.30556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textOutputBox
            // 
            this.textOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textOutputBox.Location = new System.Drawing.Point(263, 10);
            this.textOutputBox.Margin = new System.Windows.Forms.Padding(10);
            this.textOutputBox.Name = "textOutputBox";
            this.textOutputBox.Size = new System.Drawing.Size(409, 271);
            this.textOutputBox.TabIndex = 0;
            this.textOutputBox.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 294);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 279);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Second Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBox
            // 
            this.buttonBox.Controls.Add(this.textColorButton);
            this.buttonBox.Controls.Add(this.backgroundColorButton);
            this.buttonBox.Controls.Add(this.OpenFileButton);
            this.buttonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBox.Location = new System.Drawing.Point(3, 3);
            this.buttonBox.Name = "buttonBox";
            this.buttonBox.Size = new System.Drawing.Size(247, 285);
            this.buttonBox.TabIndex = 4;
            this.buttonBox.TabStop = false;
            // 
            // textColorButton
            // 
            this.textColorButton.Location = new System.Drawing.Point(60, 184);
            this.textColorButton.Margin = new System.Windows.Forms.Padding(10);
            this.textColorButton.Name = "textColorButton";
            this.textColorButton.Size = new System.Drawing.Size(120, 60);
            this.textColorButton.TabIndex = 3;
            this.textColorButton.Text = "Text Colour";
            this.textColorButton.UseVisualStyleBackColor = true;
            this.textColorButton.Click += new System.EventHandler(this.textColorButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backgroundColorButton.Location = new System.Drawing.Point(60, 104);
            this.backgroundColorButton.Margin = new System.Windows.Forms.Padding(10);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(120, 60);
            this.backgroundColorButton.TabIndex = 2;
            this.backgroundColorButton.Text = "Background colour";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenFileButton.Location = new System.Drawing.Point(60, 24);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(10);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(120, 60);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open Text File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Plain Text files (*.txt)|*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(3, 32);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "close all";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.buttonBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox textOutputBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox buttonBox;
        private System.Windows.Forms.Button textColorButton;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeButton;
    }
}

