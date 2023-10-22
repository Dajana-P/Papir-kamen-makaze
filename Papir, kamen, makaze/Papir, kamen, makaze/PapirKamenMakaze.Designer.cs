
namespace Papir__kamen__makaze
{
    partial class PapirKamenMakaze
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PapirKamenMakaze));
			this.pBLeft = new System.Windows.Forms.PictureBox();
			this.pBRight = new System.Windows.Forms.PictureBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblWinner = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pBLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBRight)).BeginInit();
			this.SuspendLayout();
			// 
			// pBLeft
			// 
			this.pBLeft.Image = global::Papir__kamen__makaze.Properties.Resources.img;
			this.pBLeft.Location = new System.Drawing.Point(62, 67);
			this.pBLeft.Name = "pBLeft";
			this.pBLeft.Size = new System.Drawing.Size(211, 282);
			this.pBLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pBLeft.TabIndex = 2;
			this.pBLeft.TabStop = false;
			// 
			// pBRight
			// 
			this.pBRight.Image = global::Papir__kamen__makaze.Properties.Resources.img;
			this.pBRight.Location = new System.Drawing.Point(522, 67);
			this.pBRight.Name = "pBRight";
			this.pBRight.Size = new System.Drawing.Size(209, 282);
			this.pBRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pBRight.TabIndex = 1;
			this.pBRight.TabStop = false;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(341, 169);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(113, 71);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblWinner
			// 
			this.lblWinner.AutoSize = true;
			this.lblWinner.Location = new System.Drawing.Point(341, 364);
			this.lblWinner.Name = "lblWinner";
			this.lblWinner.Size = new System.Drawing.Size(33, 13);
			this.lblWinner.TabIndex = 4;
			this.lblWinner.Text = "Label";
			// 
			// PapirKamenMakaze
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MistyRose;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblWinner);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.pBLeft);
			this.Controls.Add(this.pBRight);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PapirKamenMakaze";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Papir, kamen, makaze";
			this.Load += new System.EventHandler(this.PapirKamenMakaze_Load);
			((System.ComponentModel.ISupportInitialize)(this.pBLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBRight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pBRight;
        private System.Windows.Forms.PictureBox pBLeft;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblWinner;
    }
}

