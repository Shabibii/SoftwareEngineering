﻿namespace Software_Engineering_Assignment.Pages
{
    partial class MainPage
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
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.register1 = new Software_Engineering_Assignment.RegisterControl();
            this.bayControl2 = new Software_Engineering_Assignment.BayPreviewControl();
            this.bayControl1 = new Software_Engineering_Assignment.BayPreviewControl();
            this.SuspendLayout();
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(15, 16);
            this.dateTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(463, 31);
            this.dateTimeLabel.TabIndex = 3;
            this.dateTimeLabel.Text = "Saturday, 26 Oct 2019 (09:21:55 PM)";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.White;
            this.register1.Location = new System.Drawing.Point(724, 60);
            this.register1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.register1.MaximumSize = new System.Drawing.Size(633, 686);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(619, 662);
            this.register1.TabIndex = 2;
            // 
            // bayControl2
            // 
            this.bayControl2.BackColor = System.Drawing.Color.White;
            this.bayControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bayControl2.Location = new System.Drawing.Point(9, 396);
            this.bayControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bayControl2.Name = "bayControl2";
            this.bayControl2.Size = new System.Drawing.Size(662, 326);
            this.bayControl2.TabIndex = 1;
            this.bayControl2.Click += new System.EventHandler(this.BayControl2_Click);
            // 
            // bayControl1
            // 
            this.bayControl1.BackColor = System.Drawing.Color.White;
            this.bayControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bayControl1.Location = new System.Drawing.Point(9, 60);
            this.bayControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bayControl1.Name = "bayControl1";
            this.bayControl1.Size = new System.Drawing.Size(662, 326);
            this.bayControl1.TabIndex = 0;
            this.bayControl1.Load += new System.EventHandler(this.BayControl1_Load);
            this.bayControl1.Click += new System.EventHandler(this.BayControl1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.bayControl2);
            this.Controls.Add(this.bayControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1347, 732);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BayPreviewControl bayControl1;
        private BayPreviewControl bayControl2;
        private RegisterControl register1;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Timer timer;
    }
}

