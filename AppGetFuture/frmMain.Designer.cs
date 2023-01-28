namespace AppGetFuture
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ucCard1 = new AppGetFuture.ucCard();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 2;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ucCard1
            // 
            this.ucCard1.AppCreatorColor = System.Drawing.SystemColors.ControlDark;
            this.ucCard1.AppCreatorFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ucCard1.AppDescription = "NULL";
            this.ucCard1.AppDescriptionColor = System.Drawing.SystemColors.ControlDark;
            this.ucCard1.AppDescriptionFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ucCard1.AppDeveloper = "NULL";
            this.ucCard1.AppIcon = ((System.Drawing.Image)(resources.GetObject("ucCard1.AppIcon")));
            this.ucCard1.AppImage = ((System.Drawing.Image)(resources.GetObject("ucCard1.AppImage")));
            this.ucCard1.AppName = "NULL";
            this.ucCard1.AppNameColor = System.Drawing.SystemColors.ControlText;
            this.ucCard1.AppNameFont = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucCard1.AppRating = 0F;
            this.ucCard1.AppRatingColor = System.Drawing.SystemColors.ControlDark;
            this.ucCard1.AppRatingFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ucCard1.BackColor = System.Drawing.SystemColors.Control;
            this.ucCard1.CardBackColor = System.Drawing.SystemColors.Control;
            this.ucCard1.DeveloperVerified = false;
            this.ucCard1.Location = new System.Drawing.Point(12, 12);
            this.ucCard1.Name = "ucCard1";
            this.ucCard1.pbBackcolors = System.Drawing.SystemColors.Control;
            this.ucCard1.Size = new System.Drawing.Size(466, 425);
            this.ucCard1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 583);
            this.Controls.Add(this.ucCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private ucCard ucCard1;
    }
}