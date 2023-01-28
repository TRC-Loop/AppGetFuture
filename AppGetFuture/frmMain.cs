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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ucCard1.CardBackColor = Color.DarkSlateGray;
            ucCard1.AppName = "ER:LP Roleplay";
            ucCard1.AppDescription = "A roleplay game where you can do whatever you want!";
            ucCard1.AppRating = 4.5f;
            ucCard1.AppDeveloper = "ER:LP Studios";
            ucCard1.DeveloperVerified = true;
            ucCard1.RefreshControl();
            guna2BorderlessForm1.DragForm = true;
        }
    }
}
