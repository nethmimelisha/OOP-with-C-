namespace RR_Enterprises
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.logo = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btncontinue = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BaseColor = System.Drawing.Color.White;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(555, -48);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(310, 272);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 189;
            this.logo.TabStop = false;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.Location = new System.Drawing.Point(24, 409);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(193, 20);
            this.gunaLabel11.TabIndex = 194;
            this.gunaLabel11.Text = "Developed By : Group 15";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Teal;
            this.gunaLabel1.Location = new System.Drawing.Point(21, 342);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(345, 37);
            this.gunaLabel1.TabIndex = 193;
            this.gunaLabel1.Text = "Data Management System";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.DarkGreen;
            this.gunaLabel5.Location = new System.Drawing.Point(21, 301);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(217, 40);
            this.gunaLabel5.TabIndex = 192;
            this.gunaLabel5.Text = "RR Enterprises";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncontinue
            // 
            this.btncontinue.AnimationHoverSpeed = 0.07F;
            this.btncontinue.AnimationSpeed = 0.03F;
            this.btncontinue.BackColor = System.Drawing.Color.Transparent;
            this.btncontinue.BaseColor1 = System.Drawing.Color.Aquamarine;
            this.btncontinue.BaseColor2 = System.Drawing.Color.LightSeaGreen;
            this.btncontinue.BorderColor = System.Drawing.Color.White;
            this.btncontinue.BorderSize = 2;
            this.btncontinue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncontinue.FocusedColor = System.Drawing.Color.Empty;
            this.btncontinue.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinue.ForeColor = System.Drawing.Color.White;
            this.btncontinue.Image = null;
            this.btncontinue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncontinue.ImageSize = new System.Drawing.Size(20, 20);
            this.btncontinue.Location = new System.Drawing.Point(564, 396);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.OnHoverBaseColor1 = System.Drawing.Color.LightSeaGreen;
            this.btncontinue.OnHoverBaseColor2 = System.Drawing.Color.Aquamarine;
            this.btncontinue.OnHoverBorderColor = System.Drawing.Color.White;
            this.btncontinue.OnHoverForeColor = System.Drawing.Color.White;
            this.btncontinue.OnHoverImage = null;
            this.btncontinue.OnPressedColor = System.Drawing.Color.White;
            this.btncontinue.Radius = 10;
            this.btncontinue.Size = new System.Drawing.Size(224, 42);
            this.btncontinue.TabIndex = 200;
            this.btncontinue.Text = "Continue....";
            this.btncontinue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncontinue.Click += new System.EventHandler(this.btncontinue_Click);
            // 
            // Intro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncontinue);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI.WinForms.GunaPictureBox logo;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaGradientButton btncontinue;
    }
}