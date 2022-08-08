namespace Weather_WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labcondition = new System.Windows.Forms.Label();
            this.labdetails = new System.Windows.Forms.Label();
            this.labsunrise = new System.Windows.Forms.Label();
            this.labelsunrise = new System.Windows.Forms.Label();
            this.labelsanset = new System.Windows.Forms.Label();
            this.labsunset = new System.Windows.Forms.Label();
            this.labpressure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labspeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picicon = new System.Windows.Forms.PictureBox();
            this.templabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBCity.Location = new System.Drawing.Point(248, 12);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(271, 36);
            this.TBCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(540, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labcondition
            // 
            this.labcondition.AutoSize = true;
            this.labcondition.BackColor = System.Drawing.Color.Transparent;
            this.labcondition.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labcondition.ForeColor = System.Drawing.Color.White;
            this.labcondition.Location = new System.Drawing.Point(17, 80);
            this.labcondition.Name = "labcondition";
            this.labcondition.Size = new System.Drawing.Size(108, 28);
            this.labcondition.TabIndex = 3;
            this.labcondition.Text = "Condition:";
            // 
            // labdetails
            // 
            this.labdetails.AutoSize = true;
            this.labdetails.BackColor = System.Drawing.Color.Transparent;
            this.labdetails.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labdetails.ForeColor = System.Drawing.Color.White;
            this.labdetails.Location = new System.Drawing.Point(17, 133);
            this.labdetails.Name = "labdetails";
            this.labdetails.Size = new System.Drawing.Size(81, 28);
            this.labdetails.TabIndex = 4;
            this.labdetails.Text = "Details:";
            // 
            // labsunrise
            // 
            this.labsunrise.AutoSize = true;
            this.labsunrise.BackColor = System.Drawing.Color.Transparent;
            this.labsunrise.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labsunrise.ForeColor = System.Drawing.Color.White;
            this.labsunrise.Location = new System.Drawing.Point(17, 193);
            this.labsunrise.Name = "labsunrise";
            this.labsunrise.Size = new System.Drawing.Size(86, 28);
            this.labsunrise.TabIndex = 5;
            this.labsunrise.Text = "Sunrise:";
            // 
            // labelsunrise
            // 
            this.labelsunrise.AutoSize = true;
            this.labelsunrise.BackColor = System.Drawing.Color.Transparent;
            this.labelsunrise.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelsunrise.ForeColor = System.Drawing.Color.White;
            this.labelsunrise.Location = new System.Drawing.Point(109, 193);
            this.labelsunrise.Name = "labelsunrise";
            this.labelsunrise.Size = new System.Drawing.Size(48, 28);
            this.labelsunrise.TabIndex = 6;
            this.labelsunrise.Text = "N/A";
            // 
            // labelsanset
            // 
            this.labelsanset.AutoSize = true;
            this.labelsanset.BackColor = System.Drawing.Color.Transparent;
            this.labelsanset.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelsanset.ForeColor = System.Drawing.Color.White;
            this.labelsanset.Location = new System.Drawing.Point(105, 246);
            this.labelsanset.Name = "labelsanset";
            this.labelsanset.Size = new System.Drawing.Size(48, 28);
            this.labelsanset.TabIndex = 8;
            this.labelsanset.Text = "N/A";
            // 
            // labsunset
            // 
            this.labsunset.AutoSize = true;
            this.labsunset.BackColor = System.Drawing.Color.Transparent;
            this.labsunset.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labsunset.ForeColor = System.Drawing.Color.White;
            this.labsunset.Location = new System.Drawing.Point(17, 246);
            this.labsunset.Name = "labsunset";
            this.labsunset.Size = new System.Drawing.Size(81, 28);
            this.labsunset.TabIndex = 7;
            this.labsunset.Text = "Sunset:";
            // 
            // labpressure
            // 
            this.labpressure.AutoSize = true;
            this.labpressure.BackColor = System.Drawing.Color.Transparent;
            this.labpressure.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labpressure.ForeColor = System.Drawing.Color.White;
            this.labpressure.Location = new System.Drawing.Point(121, 354);
            this.labpressure.Name = "labpressure";
            this.labpressure.Size = new System.Drawing.Size(48, 28);
            this.labpressure.TabIndex = 12;
            this.labpressure.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pressure:";
            // 
            // labspeed
            // 
            this.labspeed.AutoSize = true;
            this.labspeed.BackColor = System.Drawing.Color.Transparent;
            this.labspeed.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labspeed.ForeColor = System.Drawing.Color.White;
            this.labspeed.Location = new System.Drawing.Point(159, 302);
            this.labspeed.Name = "labspeed";
            this.labspeed.Size = new System.Drawing.Size(48, 28);
            this.labspeed.TabIndex = 10;
            this.labspeed.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Winds speed:";
            // 
            // picicon
            // 
            this.picicon.BackColor = System.Drawing.Color.Transparent;
            this.picicon.Location = new System.Drawing.Point(663, 1);
            this.picicon.Name = "picicon";
            this.picicon.Size = new System.Drawing.Size(125, 62);
            this.picicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picicon.TabIndex = 13;
            this.picicon.TabStop = false;
            // 
            // templabel
            // 
            this.templabel.AutoSize = true;
            this.templabel.BackColor = System.Drawing.Color.Transparent;
            this.templabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.templabel.ForeColor = System.Drawing.Color.White;
            this.templabel.Location = new System.Drawing.Point(121, 399);
            this.templabel.Name = "templabel";
            this.templabel.Size = new System.Drawing.Size(48, 28);
            this.templabel.TabIndex = 15;
            this.templabel.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Temp:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.templabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picicon);
            this.Controls.Add(this.labpressure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labspeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelsanset);
            this.Controls.Add(this.labsunset);
            this.Controls.Add(this.labelsunrise);
            this.Controls.Add(this.labsunrise);
            this.Controls.Add(this.labdetails);
            this.Controls.Add(this.labcondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Погода";
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TBCity;
        private Button btnSearch;
        private Label labcondition;
        private Label labdetails;
        private Label labsunrise;
        private Label labelsunrise;
        private Label labelsanset;
        private Label labsunset;
        private Label labpressure;
        private Label label3;
        private Label labspeed;
        private Label label5;
        private PictureBox picicon;
        private Label templabel;
        private Label label4;
    }
}