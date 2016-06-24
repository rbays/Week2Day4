namespace LibraryAppForms
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioBox = new System.Windows.Forms.GroupBox();
            this.blurbLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.illustratorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.userSearchGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.adminBoxGroup = new System.Windows.Forms.GroupBox();
            this.blurbBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.illustratorBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminButtonGroup = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.userButtonGroup = new System.Windows.Forms.GroupBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.authorRadio = new System.Windows.Forms.RadioButton();
            this.titleRadio = new System.Windows.Forms.RadioButton();
            this.illustratorRadio = new System.Windows.Forms.RadioButton();
            this.genreRadio = new System.Windows.Forms.RadioButton();
            this.resultsNumLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.radioBox.SuspendLayout();
            this.userSearchGroup.SuspendLayout();
            this.adminBoxGroup.SuspendLayout();
            this.adminButtonGroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.userButtonGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(82, 6);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(6);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(69, 13);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "User/Admin?";
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.Location = new System.Drawing.Point(6, 6);
            this.loginUsernameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(148, 20);
            this.loginUsernameTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(163, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(148, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.userSearchGroup, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.adminBoxGroup, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.adminButtonGroup, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userButtonGroup, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 482);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox7
            // 
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(492, 266);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(322, 213);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            // 
            // radioBox
            // 
            this.radioBox.BackColor = System.Drawing.Color.Transparent;
            this.radioBox.Controls.Add(this.resultsNumLabel);
            this.radioBox.Controls.Add(this.blurbLabel);
            this.radioBox.Controls.Add(this.genreLabel);
            this.radioBox.Controls.Add(this.illustratorLabel);
            this.radioBox.Controls.Add(this.titleLabel);
            this.radioBox.Controls.Add(this.authorLabel);
            this.radioBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBox.Location = new System.Drawing.Point(492, 48);
            this.radioBox.Name = "radioBox";
            this.radioBox.Size = new System.Drawing.Size(322, 212);
            this.radioBox.TabIndex = 9;
            this.radioBox.TabStop = false;
            this.radioBox.Visible = false;
            // 
            // blurbLabel
            // 
            this.blurbLabel.AutoSize = true;
            this.blurbLabel.Location = new System.Drawing.Point(51, 148);
            this.blurbLabel.Name = "blurbLabel";
            this.blurbLabel.Size = new System.Drawing.Size(35, 13);
            this.blurbLabel.TabIndex = 9;
            this.blurbLabel.Text = "Blurb*";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(51, 122);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 8;
            this.genreLabel.Text = "Genre";
            // 
            // illustratorLabel
            // 
            this.illustratorLabel.AutoSize = true;
            this.illustratorLabel.Location = new System.Drawing.Point(51, 96);
            this.illustratorLabel.Name = "illustratorLabel";
            this.illustratorLabel.Size = new System.Drawing.Size(49, 13);
            this.illustratorLabel.TabIndex = 7;
            this.illustratorLabel.Text = "Illustrator";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(51, 70);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(31, 13);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Title*";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(51, 44);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(42, 13);
            this.authorLabel.TabIndex = 5;
            this.authorLabel.Text = "Author*";
            // 
            // groupBox5
            // 
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(492, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 39);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // userSearchGroup
            // 
            this.userSearchGroup.Controls.Add(this.groupBox1);
            this.userSearchGroup.Controls.Add(this.label1);
            this.userSearchGroup.Controls.Add(this.searchBox);
            this.userSearchGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSearchGroup.Location = new System.Drawing.Point(166, 48);
            this.userSearchGroup.Name = "userSearchGroup";
            this.userSearchGroup.Size = new System.Drawing.Size(320, 212);
            this.userSearchGroup.TabIndex = 7;
            this.userSearchGroup.TabStop = false;
            this.userSearchGroup.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by";
            // 
            // searchBox
            // 
            this.searchBox.AllowDrop = true;
            this.searchBox.Location = new System.Drawing.Point(141, 89);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 0;
            // 
            // adminBoxGroup
            // 
            this.adminBoxGroup.Controls.Add(this.blurbBox);
            this.adminBoxGroup.Controls.Add(this.genreBox);
            this.adminBoxGroup.Controls.Add(this.illustratorBox);
            this.adminBoxGroup.Controls.Add(this.titleBox);
            this.adminBoxGroup.Controls.Add(this.authorBox);
            this.adminBoxGroup.Controls.Add(this.label6);
            this.adminBoxGroup.Controls.Add(this.label5);
            this.adminBoxGroup.Controls.Add(this.label4);
            this.adminBoxGroup.Controls.Add(this.label3);
            this.adminBoxGroup.Controls.Add(this.label2);
            this.adminBoxGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminBoxGroup.Location = new System.Drawing.Point(166, 266);
            this.adminBoxGroup.Name = "adminBoxGroup";
            this.adminBoxGroup.Size = new System.Drawing.Size(320, 213);
            this.adminBoxGroup.TabIndex = 6;
            this.adminBoxGroup.TabStop = false;
            this.adminBoxGroup.Visible = false;
            // 
            // blurbBox
            // 
            this.blurbBox.Location = new System.Drawing.Point(120, 136);
            this.blurbBox.Name = "blurbBox";
            this.blurbBox.Size = new System.Drawing.Size(100, 20);
            this.blurbBox.TabIndex = 9;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(120, 110);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(100, 20);
            this.genreBox.TabIndex = 8;
            // 
            // illustratorBox
            // 
            this.illustratorBox.Location = new System.Drawing.Point(120, 84);
            this.illustratorBox.Name = "illustratorBox";
            this.illustratorBox.Size = new System.Drawing.Size(100, 20);
            this.illustratorBox.TabIndex = 7;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(120, 58);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 20);
            this.titleBox.TabIndex = 6;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(120, 32);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(100, 20);
            this.authorBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Blurb*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Illustrator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author*";
            // 
            // adminButtonGroup
            // 
            this.adminButtonGroup.Controls.Add(this.deleteButton);
            this.adminButtonGroup.Controls.Add(this.addButton);
            this.adminButtonGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminButtonGroup.Location = new System.Drawing.Point(3, 266);
            this.adminButtonGroup.Name = "adminButtonGroup";
            this.adminButtonGroup.Size = new System.Drawing.Size(157, 213);
            this.adminButtonGroup.TabIndex = 5;
            this.adminButtonGroup.TabStop = false;
            this.adminButtonGroup.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(3, 90);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete Book";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(4, 55);
            this.addButton.Margin = new System.Windows.Forms.Padding(6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Book";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.loginUsernameTextBox);
            this.flowLayoutPanel1.Controls.Add(this.loginButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(166, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 39);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.UserLabel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(157, 39);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // userButtonGroup
            // 
            this.userButtonGroup.Controls.Add(this.button1);
            this.userButtonGroup.Controls.Add(this.returnButton);
            this.userButtonGroup.Controls.Add(this.borrowButton);
            this.userButtonGroup.Controls.Add(this.searchButton);
            this.userButtonGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userButtonGroup.Location = new System.Drawing.Point(3, 48);
            this.userButtonGroup.Name = "userButtonGroup";
            this.userButtonGroup.Size = new System.Drawing.Size(157, 212);
            this.userButtonGroup.TabIndex = 4;
            this.userButtonGroup.TabStop = false;
            this.userButtonGroup.Visible = false;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(3, 166);
            this.returnButton.Margin = new System.Windows.Forms.Padding(7);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(150, 23);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return Book";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(3, 129);
            this.borrowButton.Margin = new System.Windows.Forms.Padding(7);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(150, 23);
            this.borrowButton.TabIndex = 5;
            this.borrowButton.Text = "Borrow Book";
            this.borrowButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(3, 11);
            this.searchButton.Margin = new System.Windows.Forms.Padding(7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show next book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // authorRadio
            // 
            this.authorRadio.AutoSize = true;
            this.authorRadio.Location = new System.Drawing.Point(29, 13);
            this.authorRadio.Name = "authorRadio";
            this.authorRadio.Size = new System.Drawing.Size(56, 17);
            this.authorRadio.TabIndex = 15;
            this.authorRadio.TabStop = true;
            this.authorRadio.Text = "Author";
            this.authorRadio.UseVisualStyleBackColor = true;
            // 
            // titleRadio
            // 
            this.titleRadio.AutoSize = true;
            this.titleRadio.Location = new System.Drawing.Point(29, 36);
            this.titleRadio.Name = "titleRadio";
            this.titleRadio.Size = new System.Drawing.Size(45, 17);
            this.titleRadio.TabIndex = 16;
            this.titleRadio.TabStop = true;
            this.titleRadio.Text = "Title";
            this.titleRadio.UseVisualStyleBackColor = true;
            // 
            // illustratorRadio
            // 
            this.illustratorRadio.AutoSize = true;
            this.illustratorRadio.Location = new System.Drawing.Point(29, 59);
            this.illustratorRadio.Name = "illustratorRadio";
            this.illustratorRadio.Size = new System.Drawing.Size(67, 17);
            this.illustratorRadio.TabIndex = 17;
            this.illustratorRadio.TabStop = true;
            this.illustratorRadio.Text = "Illustrator";
            this.illustratorRadio.UseVisualStyleBackColor = true;
            // 
            // genreRadio
            // 
            this.genreRadio.AutoSize = true;
            this.genreRadio.Location = new System.Drawing.Point(29, 82);
            this.genreRadio.Name = "genreRadio";
            this.genreRadio.Size = new System.Drawing.Size(54, 17);
            this.genreRadio.TabIndex = 18;
            this.genreRadio.TabStop = true;
            this.genreRadio.Text = "Genre";
            this.genreRadio.UseVisualStyleBackColor = true;
            // 
            // resultsNumLabel
            // 
            this.resultsNumLabel.AutoSize = true;
            this.resultsNumLabel.Location = new System.Drawing.Point(54, 20);
            this.resultsNumLabel.Name = "resultsNumLabel";
            this.resultsNumLabel.Size = new System.Drawing.Size(46, 13);
            this.resultsNumLabel.TabIndex = 10;
            this.resultsNumLabel.Text = "5 results";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.authorRadio);
            this.groupBox1.Controls.Add(this.genreRadio);
            this.groupBox1.Controls.Add(this.titleRadio);
            this.groupBox1.Controls.Add(this.illustratorRadio);
            this.groupBox1.Location = new System.Drawing.Point(6, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 116);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 482);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.radioBox.ResumeLayout(false);
            this.radioBox.PerformLayout();
            this.userSearchGroup.ResumeLayout(false);
            this.userSearchGroup.PerformLayout();
            this.adminBoxGroup.ResumeLayout(false);
            this.adminBoxGroup.PerformLayout();
            this.adminButtonGroup.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.userButtonGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox radioBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox userSearchGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.GroupBox adminBoxGroup;
        private System.Windows.Forms.GroupBox adminButtonGroup;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox userButtonGroup;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label blurbLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label illustratorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox blurbBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox illustratorBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton genreRadio;
        private System.Windows.Forms.RadioButton illustratorRadio;
        private System.Windows.Forms.RadioButton titleRadio;
        private System.Windows.Forms.RadioButton authorRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultsNumLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

