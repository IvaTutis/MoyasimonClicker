namespace MoyasimonClicker
{
    partial class PetriDishControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.howmanyLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.BacteriaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BacteriaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.nameLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(258, 41);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // howmanyLabel
            // 
            this.howmanyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.howmanyLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.howmanyLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howmanyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.howmanyLabel.Location = new System.Drawing.Point(0, 32);
            this.howmanyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.howmanyLabel.Name = "howmanyLabel";
            this.howmanyLabel.Size = new System.Drawing.Size(261, 36);
            this.howmanyLabel.TabIndex = 1;
            this.howmanyLabel.Text = "Amount";
            this.howmanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.priceLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceLabel.Location = new System.Drawing.Point(1, 68);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(257, 35);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buyButton
            // 
            this.buyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buyButton.BackColor = System.Drawing.Color.Crimson;
            this.buyButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buyButton.Image = global::MoyasimonClicker.Properties.Resources.Background;
            this.buyButton.Location = new System.Drawing.Point(0, 98);
            this.buyButton.Margin = new System.Windows.Forms.Padding(2);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(258, 102);
            this.buyButton.TabIndex = 3;
            this.buyButton.Text = "Buy Now!";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyClicked);
            // 
            // BacteriaPictureBox
            // 
            this.BacteriaPictureBox.BackColor = System.Drawing.Color.MintCream;
            this.BacteriaPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.BacteriaPictureBox.Location = new System.Drawing.Point(255, 0);
            this.BacteriaPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.BacteriaPictureBox.Name = "BacteriaPictureBox";
            this.BacteriaPictureBox.Size = new System.Drawing.Size(192, 200);
            this.BacteriaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BacteriaPictureBox.TabIndex = 4;
            this.BacteriaPictureBox.TabStop = false;
            this.BacteriaPictureBox.Click += new System.EventHandler(this.BacteriaPictureBox_Click);
            // 
            // PetriDishControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.BacteriaPictureBox);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.howmanyLabel);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(3750, 200);
            this.MinimumSize = new System.Drawing.Size(0, 200);
            this.Name = "PetriDishControl";
            this.Size = new System.Drawing.Size(447, 200);
            ((System.ComponentModel.ISupportInitialize)(this.BacteriaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label howmanyLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.PictureBox BacteriaPictureBox;
    }
}
