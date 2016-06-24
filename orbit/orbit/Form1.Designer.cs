namespace orbit
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
            this.components = new System.ComponentModel.Container();
            this.sunLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.planetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.velocityX = new System.Windows.Forms.Label();
            this.velocityY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accelerationX = new System.Windows.Forms.Label();
            this.accelerationY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.distanceXLabel = new System.Windows.Forms.Label();
            this.distanceYLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sunLabel
            // 
            this.sunLabel.AutoSize = true;
            this.sunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunLabel.ForeColor = System.Drawing.Color.Yellow;
            this.sunLabel.Location = new System.Drawing.Point(424, 279);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(62, 31);
            this.sunLabel.TabIndex = 0;
            this.sunLabel.Text = "Sun";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Orbit!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // planetLabel
            // 
            this.planetLabel.AutoSize = true;
            this.planetLabel.ForeColor = System.Drawing.Color.Lime;
            this.planetLabel.Location = new System.Drawing.Point(491, 219);
            this.planetLabel.Name = "planetLabel";
            this.planetLabel.Size = new System.Drawing.Size(37, 13);
            this.planetLabel.TabIndex = 2;
            this.planetLabel.Text = "Planet";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // velocityX
            // 
            this.velocityX.AutoSize = true;
            this.velocityX.Location = new System.Drawing.Point(825, 67);
            this.velocityX.Name = "velocityX";
            this.velocityX.Size = new System.Drawing.Size(35, 13);
            this.velocityX.TabIndex = 3;
            this.velocityX.Text = "label1";
            // 
            // velocityY
            // 
            this.velocityY.AutoSize = true;
            this.velocityY.Location = new System.Drawing.Point(828, 96);
            this.velocityY.Name = "velocityY";
            this.velocityY.Size = new System.Drawing.Size(35, 13);
            this.velocityY.TabIndex = 4;
            this.velocityY.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "velocities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "accelerations";
            // 
            // accelerationX
            // 
            this.accelerationX.AutoSize = true;
            this.accelerationX.Location = new System.Drawing.Point(723, 67);
            this.accelerationX.Name = "accelerationX";
            this.accelerationX.Size = new System.Drawing.Size(35, 13);
            this.accelerationX.TabIndex = 7;
            this.accelerationX.Text = "label3";
            // 
            // accelerationY
            // 
            this.accelerationY.AutoSize = true;
            this.accelerationY.Location = new System.Drawing.Point(723, 96);
            this.accelerationY.Name = "accelerationY";
            this.accelerationY.Size = new System.Drawing.Size(35, 13);
            this.accelerationY.TabIndex = 8;
            this.accelerationY.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(828, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Angle";
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Location = new System.Drawing.Point(828, 229);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(35, 13);
            this.AngleLabel.TabIndex = 10;
            this.AngleLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Distances";
            // 
            // distanceXLabel
            // 
            this.distanceXLabel.AutoSize = true;
            this.distanceXLabel.Location = new System.Drawing.Point(624, 67);
            this.distanceXLabel.Name = "distanceXLabel";
            this.distanceXLabel.Size = new System.Drawing.Size(35, 13);
            this.distanceXLabel.TabIndex = 12;
            this.distanceXLabel.Text = "label5";
            // 
            // distanceYLabel
            // 
            this.distanceYLabel.AutoSize = true;
            this.distanceYLabel.Location = new System.Drawing.Point(624, 96);
            this.distanceYLabel.Name = "distanceYLabel";
            this.distanceYLabel.Size = new System.Drawing.Size(35, 13);
            this.distanceYLabel.TabIndex = 13;
            this.distanceYLabel.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.distanceYLabel);
            this.Controls.Add(this.distanceXLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AngleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accelerationY);
            this.Controls.Add(this.accelerationX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.velocityY);
            this.Controls.Add(this.velocityX);
            this.Controls.Add(this.planetLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sunLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sunLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label planetLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label velocityX;
        private System.Windows.Forms.Label velocityY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accelerationX;
        private System.Windows.Forms.Label accelerationY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label distanceXLabel;
        private System.Windows.Forms.Label distanceYLabel;
    }
}

