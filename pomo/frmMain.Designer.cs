using System.ComponentModel;
using System.Windows.Forms;

namespace pomo
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.picPomo1 = new System.Windows.Forms.PictureBox();
            this.picPomo2 = new System.Windows.Forms.PictureBox();
            this.picPomo3 = new System.Windows.Forms.PictureBox();
            this.picPomo4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPomo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPomo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPomo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPomo4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(27, 15);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(91, 42);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "0:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(44, 20);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(9, 39);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 20);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(9, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 20);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picPomo1
            // 
            this.picPomo1.Location = new System.Drawing.Point(10, 60);
            this.picPomo1.Name = "picPomo1";
            this.picPomo1.Size = new System.Drawing.Size(32, 32);
            this.picPomo1.TabIndex = 11;
            this.picPomo1.TabStop = false;
            // 
            // picPomo2
            // 
            this.picPomo2.Location = new System.Drawing.Point(48, 60);
            this.picPomo2.Name = "picPomo2";
            this.picPomo2.Size = new System.Drawing.Size(32, 32);
            this.picPomo2.TabIndex = 12;
            this.picPomo2.TabStop = false;
            // 
            // picPomo3
            // 
            this.picPomo3.Location = new System.Drawing.Point(86, 60);
            this.picPomo3.Name = "picPomo3";
            this.picPomo3.Size = new System.Drawing.Size(32, 32);
            this.picPomo3.TabIndex = 13;
            this.picPomo3.TabStop = false;
            // 
            // picPomo4
            // 
            this.picPomo4.Location = new System.Drawing.Point(124, 60);
            this.picPomo4.Name = "picPomo4";
            this.picPomo4.Size = new System.Drawing.Size(32, 32);
            this.picPomo4.TabIndex = 14;
            this.picPomo4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Location = new System.Drawing.Point(162, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(60, 90);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Pomo";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 102);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picPomo4);
            this.Controls.Add(this.picPomo3);
            this.Controls.Add(this.picPomo2);
            this.Controls.Add(this.picPomo1);
            this.Controls.Add(this.lblTimer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomo";
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picPomo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPomo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPomo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPomo4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTimer;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private PictureBox picPomo1;
        private PictureBox picPomo2;
        private PictureBox picPomo3;
        private PictureBox picPomo4;
        private GroupBox groupBox1;
        private NotifyIcon notifyIcon;
    }
}

