using AppGetFuture.Properties;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGetFuture
{
    public partial class ucCard : UserControl
    {
        public string AppName { get; set; } = "NULL";
        public string AppDescription { get; set; } = "NULL";
        public float AppRating { get; set; } = 0;
        public Image AppIcon { get; set; } = Resources.AppError;
        public Image AppImage { get; set; } = Resources.BackgroundError;
        public string AppDeveloper { get; set; } = "NULL";
        public bool DeveloperVerified { get; set; } = false;
        public Color CardBackColor { get; set; } = Color.FromKnownColor(KnownColor.Control);
        public Color AppNameColor { get; set; } = Color.FromKnownColor(KnownColor.ControlText);
        public Color AppDescriptionColor { get; set; } = Color.FromKnownColor(KnownColor.ControlDark);
        public Color AppRatingColor { get; set; } = Color.FromKnownColor(KnownColor.ControlDark);
        public Color AppCreatorColor { get; set; } = Color.FromKnownColor(KnownColor.ControlDark);
        public Font AppNameFont { get; set; } = new Font("Segoe UI Semibold", 26, FontStyle.Bold);
        public Font AppDescriptionFont { get; set; } = new Font("Segoe UI", 11, FontStyle.Italic);
        public Font AppRatingFont { get; set; } = new Font("Segoe UI", 11, FontStyle.Italic);
        public Font AppCreatorFont { get; set; } = new Font("Segoe UI", 11, FontStyle.Italic);
        public Color pbBackcolors { get; set; } = Color.FromKnownColor(KnownColor.Control);
        public ucCard()
        {
            InitializeComponent();
        }
        public void RefreshControl()
        {
            glblAppName.Text = AppName;
            glblAppDescription.Text = AppDescription;
            glblRating.Text = AppRating.ToString();
            glblAppCreator.Text = AppDeveloper;
            gpbAppicon.Image = AppIcon;
            gpbAppImage.Image = AppImage;
            gpbAppImage.FillColor = pbBackcolors;
            gpbAppImage.BackColor = pbBackcolors;
            gpbAppicon.FillColor = pbBackcolors;
            gpbAppicon.BackColor = pbBackcolors;
            glblAppName.ForeColor = AppNameColor;
            glblAppCreator.ForeColor = AppCreatorColor;
            glblAppDescription.ForeColor = AppDescriptionColor;
            glblRating.ForeColor = AppRatingColor;
            glblAppName.Font = AppNameFont;
            glblAppCreator.Font = AppCreatorFont;
            glblAppDescription.Font = AppDescriptionFont;
            glblRating.Font = AppRatingFont;
            this.BackColor = CardBackColor;
            gpbAppImage.BackColor = CardBackColor;
            gpbAppicon.BackColor = CardBackColor;
            gpbAppImage.FillColor = CardBackColor;
            gpbAppicon.FillColor = CardBackColor;
            glblAppName.BackColor = CardBackColor;
            glblAppCreator.BackColor = CardBackColor;
            glblAppDescription.BackColor = CardBackColor;
            glblRating.BackColor = CardBackColor;
            RefreshVerification();
            gpbAppicon.Refresh();
            gpbAppImage.Refresh();
            glblRating.Refresh();
            glblAppName.Refresh();
            glblAppCreator.Refresh();
            glblAppDescription.Refresh();
            this.Refresh();
        }
        
        private void ucCard_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        public void RefreshVerification()
        {
            if (DeveloperVerified == true)
            {
                gcbDevVerified.Checked = true;
            }
            else
            {
                gcbDevVerified.Checked = false;
            }
            gcbDevVerified.Left = glblAppCreator.Left + glblAppCreator.Width + 5;
        }



        private void ucCard_Paint(object sender, PaintEventArgs e)
        {
            RefreshVerification();
        }
    }
}
