using System.ComponentModel;
using System.Windows.Forms;

namespace pomo
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btnSetOkay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setLongBreak = new System.Windows.Forms.NumericUpDown();
            this.setShortBreak = new System.Windows.Forms.NumericUpDown();
            this.setPomoTime = new System.Windows.Forms.NumericUpDown();
            this.chkAlertMe = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picPomoLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setLongBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setShortBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPomoTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPomoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetOkay
            // 
            this.btnSetOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSetOkay.Location = new System.Drawing.Point(100, 173);
            this.btnSetOkay.Name = "btnSetOkay";
            this.btnSetOkay.Size = new System.Drawing.Size(75, 23);
            this.btnSetOkay.TabIndex = 5;
            this.btnSetOkay.Text = "Okay";
            this.btnSetOkay.UseVisualStyleBackColor = true;
            this.btnSetOkay.Click += new System.EventHandler(this.btnSetOkay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setLongBreak);
            this.groupBox1.Controls.Add(this.setShortBreak);
            this.groupBox1.Controls.Add(this.setPomoTime);
            this.groupBox1.Controls.Add(this.chkAlertMe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // setLongBreak
            // 
            this.setLongBreak.Location = new System.Drawing.Point(110, 74);
            this.setLongBreak.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.setLongBreak.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setLongBreak.Name = "setLongBreak";
            this.setLongBreak.Size = new System.Drawing.Size(37, 20);
            this.setLongBreak.TabIndex = 3;
            this.setLongBreak.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // setShortBreak
            // 
            this.setShortBreak.Location = new System.Drawing.Point(110, 49);
            this.setShortBreak.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.setShortBreak.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setShortBreak.Name = "setShortBreak";
            this.setShortBreak.Size = new System.Drawing.Size(37, 20);
            this.setShortBreak.TabIndex = 2;
            this.setShortBreak.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // setPomoTime
            // 
            this.setPomoTime.Location = new System.Drawing.Point(110, 24);
            this.setPomoTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.setPomoTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setPomoTime.Name = "setPomoTime";
            this.setPomoTime.Size = new System.Drawing.Size(37, 20);
            this.setPomoTime.TabIndex = 1;
            this.setPomoTime.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // chkAlertMe
            // 
            this.chkAlertMe.AutoSize = true;
            this.chkAlertMe.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAlertMe.Checked = true;
            this.chkAlertMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlertMe.Location = new System.Drawing.Point(6, 100);
            this.chkAlertMe.Name = "chkAlertMe";
            this.chkAlertMe.Size = new System.Drawing.Size(122, 17);
            this.chkAlertMe.TabIndex = 4;
            this.chkAlertMe.Text = "Alert me if timer is up";
            this.chkAlertMe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Long Break Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Short Break Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pomodoro Length";
            // 
            // picPomoLogo
            // 
            this.picPomoLogo.Location = new System.Drawing.Point(27, 8);
            this.picPomoLogo.Name = "picPomoLogo";
            this.picPomoLogo.Size = new System.Drawing.Size(32, 32);
            this.picPomoLogo.TabIndex = 6;
            this.picPomoLogo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pomo";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 173);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.btnSetOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 206);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picPomoLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSetOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setLongBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setShortBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPomoTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPomoLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSetOkay;
        private GroupBox groupBox1;
        private NumericUpDown setLongBreak;
        private NumericUpDown setShortBreak;
        private NumericUpDown setPomoTime;
        private CheckBox chkAlertMe;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox picPomoLogo;
        private Label label4;
        private Button btnExit;
    }
}