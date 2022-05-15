namespace Weatherapplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TBcity = new System.Windows.Forms.TextBox();
            this.bnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labWindspeed = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(619, 156);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.MinimumSize = new System.Drawing.Size(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "City: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBcity
            // 
            this.TBcity.Location = new System.Drawing.Point(546, 195);
            this.TBcity.MaximumSize = new System.Drawing.Size(200, 50);
            this.TBcity.Multiline = true;
            this.TBcity.Name = "TBcity";
            this.TBcity.Size = new System.Drawing.Size(200, 28);
            this.TBcity.TabIndex = 1;
            this.TBcity.Tag = "SEARCH";
            this.TBcity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bnSearch
            // 
            this.bnSearch.BackColor = System.Drawing.Color.Transparent;
            this.bnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.bnSearch.Location = new System.Drawing.Point(803, 186);
            this.bnSearch.Name = "bnSearch";
            this.bnSearch.Size = new System.Drawing.Size(75, 37);
            this.bnSearch.TabIndex = 2;
            this.bnSearch.Text = "Search";
            this.bnSearch.UseVisualStyleBackColor = false;
            this.bnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.Transparent;
            this.labCondition.Location = new System.Drawing.Point(56, 146);
            this.labCondition.MaximumSize = new System.Drawing.Size(100, 100);
            this.labCondition.MinimumSize = new System.Drawing.Size(10, 10);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(84, 19);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Condition";
            this.labCondition.Click += new System.EventHandler(this.label2_Click);
            // 
            // labDetail
            // 
            this.labDetail.AutoSize = true;
            this.labDetail.BackColor = System.Drawing.Color.Transparent;
            this.labDetail.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetail.ForeColor = System.Drawing.Color.Transparent;
            this.labDetail.Location = new System.Drawing.Point(193, 147);
            this.labDetail.MaximumSize = new System.Drawing.Size(100, 100);
            this.labDetail.MinimumSize = new System.Drawing.Size(10, 10);
            this.labDetail.Name = "labDetail";
            this.labDetail.Size = new System.Drawing.Size(68, 19);
            this.labDetail.TabIndex = 4;
            this.labDetail.Text = "Details:";
            this.labDetail.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(476, 350);
            this.label4.MaximumSize = new System.Drawing.Size(100, 100);
            this.label4.MinimumSize = new System.Drawing.Size(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunrise";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(193, 350);
            this.label5.MaximumSize = new System.Drawing.Size(100, 100);
            this.label5.MinimumSize = new System.Drawing.Size(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "WindSpeed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(210, 397);
            this.label6.MaximumSize = new System.Drawing.Size(100, 100);
            this.label6.MinimumSize = new System.Drawing.Size(10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pressure:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(478, 397);
            this.label7.MaximumSize = new System.Drawing.Size(100, 100);
            this.label7.MinimumSize = new System.Drawing.Size(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sunset:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // labWindspeed
            // 
            this.labWindspeed.AutoSize = true;
            this.labWindspeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindspeed.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindspeed.ForeColor = System.Drawing.Color.Transparent;
            this.labWindspeed.Location = new System.Drawing.Point(340, 350);
            this.labWindspeed.MaximumSize = new System.Drawing.Size(100, 100);
            this.labWindspeed.MinimumSize = new System.Drawing.Size(10, 10);
            this.labWindspeed.Name = "labWindspeed";
            this.labWindspeed.Size = new System.Drawing.Size(37, 19);
            this.labWindspeed.TabIndex = 9;
            this.labWindspeed.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.Transparent;
            this.labPressure.Location = new System.Drawing.Point(340, 397);
            this.labPressure.MaximumSize = new System.Drawing.Size(100, 100);
            this.labPressure.MinimumSize = new System.Drawing.Size(10, 10);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(37, 19);
            this.labPressure.TabIndex = 10;
            this.labPressure.Text = "N/A";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.Transparent;
            this.labSunrise.Location = new System.Drawing.Point(581, 350);
            this.labSunrise.MaximumSize = new System.Drawing.Size(100, 100);
            this.labSunrise.MinimumSize = new System.Drawing.Size(10, 10);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(37, 19);
            this.labSunrise.TabIndex = 11;
            this.labSunrise.Text = "N/A";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.Transparent;
            this.labSunset.Location = new System.Drawing.Point(581, 397);
            this.labSunset.MaximumSize = new System.Drawing.Size(100, 100);
            this.labSunset.MinimumSize = new System.Drawing.Size(10, 10);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(37, 19);
            this.labSunset.TabIndex = 12;
            this.labSunset.Text = "N/A";
            this.labSunset.Click += new System.EventHandler(this.labSunset_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(60, 185);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(231, 99);
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(37, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(642, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sunshine is delicious, rain is refreshing, wind braces us up, snow is exhilaratin" +
    "g;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(654, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = " there is really no such thing as bad weather, only different kinds of good weath" +
    "er";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(607, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "WEATHER_UPDATE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 501);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWindspeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDetail);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.bnSearch);
            this.Controls.Add(this.TBcity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBcity;
        private System.Windows.Forms.Button bnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labWindspeed;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}

