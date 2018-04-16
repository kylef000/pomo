using System;
using System.Drawing;
using System.Windows.Forms;
using pomo.Properties;

namespace pomo
{
    public partial class Settings : Form
    {
        public int PomoTimer { private set; get; }
        public int ShortBreak { private set; get; }
        public int LongBreak { private set; get; }
        public bool AlertMe { private set; get; }

        private readonly Bitmap _pomoIcon = Resources.Tomato.ToBitmap();

        /// <summary>
        /// Settings form constructor
        /// </summary>
        public Settings()
        {
            InitializeComponent();
            picPomoLogo.Image = _pomoIcon;
        }

        /// <summary>
        /// Passes the settings chosen to the class properties and closes the form
        /// </summary>
        private void btnSetOkay_Click(object sender, EventArgs e)
        {

            PomoTimer = (int) setPomoTime.Value;
            ShortBreak = (int) setShortBreak.Value;
            LongBreak = (int) setLongBreak.Value;
            AlertMe = chkAlertMe.Checked;

            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
