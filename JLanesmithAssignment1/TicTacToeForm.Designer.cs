namespace JLanesmithAssignment1
{
    partial class TicTacToeForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.picPlayerO = new System.Windows.Forms.PictureBox();
			this.picPlayerX = new System.Windows.Forms.PictureBox();
			this.picBottomRight = new System.Windows.Forms.PictureBox();
			this.picBottomMiddle = new System.Windows.Forms.PictureBox();
			this.picBottomLeft = new System.Windows.Forms.PictureBox();
			this.picMiddleRight = new System.Windows.Forms.PictureBox();
			this.picMiddleMiddle = new System.Windows.Forms.PictureBox();
			this.picMiddleLeft = new System.Windows.Forms.PictureBox();
			this.picTopRight = new System.Windows.Forms.PictureBox();
			this.picTopMiddle = new System.Windows.Forms.PictureBox();
			this.picTopLeft = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottomRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottomMiddle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottomLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMiddleRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMiddleMiddle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMiddleLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopMiddle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopLeft)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cooper Black", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(9, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(495, 91);
			this.label1.TabIndex = 12;
			this.label1.Text = "Tic Tac Toe";
			// 
			// picPlayerO
			// 
			this.picPlayerO.Image = global::JLanesmithAssignment1.Properties.Resources.player_o_icon;
			this.picPlayerO.InitialImage = null;
			this.picPlayerO.Location = new System.Drawing.Point(563, 179);
			this.picPlayerO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picPlayerO.Name = "picPlayerO";
			this.picPlayerO.Size = new System.Drawing.Size(240, 260);
			this.picPlayerO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPlayerO.TabIndex = 11;
			this.picPlayerO.TabStop = false;
			// 
			// picPlayerX
			// 
			this.picPlayerX.Image = global::JLanesmithAssignment1.Properties.Resources.player_x_icon;
			this.picPlayerX.Location = new System.Drawing.Point(13, 179);
			this.picPlayerX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picPlayerX.Name = "picPlayerX";
			this.picPlayerX.Size = new System.Drawing.Size(240, 260);
			this.picPlayerX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPlayerX.TabIndex = 10;
			this.picPlayerX.TabStop = false;
			// 
			// picBottomRight
			// 
			this.picBottomRight.BackColor = System.Drawing.Color.Ivory;
			this.picBottomRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picBottomRight.Location = new System.Drawing.Point(461, 358);
			this.picBottomRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picBottomRight.Name = "picBottomRight";
			this.picBottomRight.Size = new System.Drawing.Size(98, 106);
			this.picBottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBottomRight.TabIndex = 8;
			this.picBottomRight.TabStop = false;
			this.picBottomRight.Click += new System.EventHandler(this.BoardSquare_Click);
			// 
			// picBottomMiddle
			// 
			this.picBottomMiddle.BackColor = System.Drawing.Color.Ivory;
			this.picBottomMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picBottomMiddle.Location = new System.Drawing.Point(359, 358);
			this.picBottomMiddle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picBottomMiddle.Name = "picBottomMiddle";
			this.picBottomMiddle.Size = new System.Drawing.Size(98, 106);
			this.picBottomMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBottomMiddle.TabIndex = 7;
			this.picBottomMiddle.TabStop = false;
			this.picBottomMiddle.Click += new System.EventHandler(this.BoardSquare_Click);
			// 
			// picBottomLeft
			// 
			this.picBottomLeft.BackColor = System.Drawing.Color.Ivory;
			this.picBottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picBottomLeft.Location = new System.Drawing.Point(257, 358);
			this.picBottomLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picBottomLeft.Name = "picBottomLeft";
			this.picBottomLeft.Size = new System.Drawing.Size(98, 106);
			this.picBottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBottomLeft.TabIndex = 6;
			this.picBottomLeft.TabStop = false;
			this.picBottomLeft.Click += new System.EventHandler(this.BoardSquare_Click);
			// 
			// picMiddleRight
			// 
			this.picMiddleRight.BackColor = System.Drawing.Color.Ivory;
			this.picMiddleRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picMiddleRight.Location = new System.Drawing.Point(461, 247);
			this.picMiddleRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picMiddleRight.Name = "picMiddleRight";
			this.picMiddleRight.Size = new System.Drawing.Size(98, 106);
			this.picMiddleRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMiddleRight.TabIndex = 5;
			this.picMiddleRight.TabStop = false;
			this.picMiddleRight.Click += new System.EventHandler(this.BoardSquare_Click);
			// 
			// picMiddleMiddle
			// 
			this.picMiddleMiddle.BackColor = System.Drawing.Color.Ivory;
			this.picMiddleMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picMiddleMiddle.Location = new System.Drawing.Point(359, 247);
			this.picMiddleMiddle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picMiddleMiddle.Name = "picMiddleMiddle";
			this.picMiddleMiddle.Size = new System.Drawing.Size(98, 106);
			this.picMiddleMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMiddleMiddle.TabIndex = 4;
			this.picMiddleMiddle.TabStop = false;
			this.picMiddleMiddle.Click += new System.EventHandler(this.BoardSquare_Click);
			// 
			// picMiddleLeft
			// 
			this.picMiddleLeft.BackColor = System.Drawing.Color.Ivory;
			this.picMiddleLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picMiddleLeft.Location = new System.Drawing.Point(257, 247);
			this.picMiddleLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picMiddleLeft.Name = "picMiddleLeft";
			this.picMiddleLeft.Size = new System.Drawing.Size(98, 106);
			this.picMiddleLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMiddleLeft.TabIndex = 3;
			this.picMiddleLeft.TabStop = false;
			this.picMiddleLeft.Click += new System.EventHandler(this.BoardSquare_Click);
			// 
			// picTopRight
			// 
			this.picTopRight.BackColor = System.Drawing.Color.Ivory;
			this.picTopRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picTopRight.Location = new System.Drawing.Point(461, 136);
			this.picTopRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picTopRight.Name = "picTopRight";
			this.picTopRight.Size = new System.Drawing.Size(98, 106);
			this.picTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picTopRight.TabIndex = 2;
			this.picTopRight.TabStop = false;
			this.picTopRight.Click += new System.EventHandler(this.BoardSquare_Click);
			// 
			// picTopMiddle
			// 
			this.picTopMiddle.BackColor = System.Drawing.Color.Ivory;
			this.picTopMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picTopMiddle.Location = new System.Drawing.Point(359, 136);
			this.picTopMiddle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picTopMiddle.Name = "picTopMiddle";
			this.picTopMiddle.Size = new System.Drawing.Size(98, 106);
			this.picTopMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picTopMiddle.TabIndex = 1;
			this.picTopMiddle.TabStop = false;
			this.picTopMiddle.Click += new System.EventHandler(this.BoardSquare_Click);
			// 
			// picTopLeft
			// 
			this.picTopLeft.BackColor = System.Drawing.Color.Ivory;
			this.picTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picTopLeft.Location = new System.Drawing.Point(257, 136);
			this.picTopLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picTopLeft.Name = "picTopLeft";
			this.picTopLeft.Size = new System.Drawing.Size(98, 106);
			this.picTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picTopLeft.TabIndex = 0;
			this.picTopLeft.TabStop = false;
			this.picTopLeft.Click += new System.EventHandler(this.BoardSquare_Click);
			// 
			// TicTacToeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(815, 583);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picPlayerO);
			this.Controls.Add(this.picPlayerX);
			this.Controls.Add(this.picBottomRight);
			this.Controls.Add(this.picBottomMiddle);
			this.Controls.Add(this.picBottomLeft);
			this.Controls.Add(this.picMiddleRight);
			this.Controls.Add(this.picMiddleMiddle);
			this.Controls.Add(this.picMiddleLeft);
			this.Controls.Add(this.picTopRight);
			this.Controls.Add(this.picTopMiddle);
			this.Controls.Add(this.picTopLeft);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "TicTacToeForm";
			this.Text = "Tic Tac Toe";
			this.Load += new System.EventHandler(this.TicTacToeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.picPlayerO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottomRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottomMiddle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottomLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMiddleRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMiddleMiddle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMiddleLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopMiddle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopLeft)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTopLeft;
        private System.Windows.Forms.PictureBox picTopMiddle;
        private System.Windows.Forms.PictureBox picTopRight;
        private System.Windows.Forms.PictureBox picMiddleLeft;
        private System.Windows.Forms.PictureBox picMiddleMiddle;
        private System.Windows.Forms.PictureBox picMiddleRight;
        private System.Windows.Forms.PictureBox picBottomLeft;
        private System.Windows.Forms.PictureBox picBottomMiddle;
        private System.Windows.Forms.PictureBox picBottomRight;
		private System.Windows.Forms.PictureBox picPlayerX;
		private System.Windows.Forms.PictureBox picPlayerO;
		private System.Windows.Forms.Label label1;
	}
}

