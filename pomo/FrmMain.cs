using System;
using System.Drawing;
using System.Windows.Forms;
using pomo.Properties;

namespace pomo
{
    public partial class FrmMain : Form
    {
        private static readonly Timer PomoTimer = new Timer();

        private int _timeKeep;
        private int _numPomo;
        private int _nextBreak;
        private bool _break = true;

        private readonly Bitmap _pomoIcon = Resources.Tomato.ToBitmap();
        private readonly Image _disabledPomo;

        private readonly Settings _settings;

        /// <summary>
        /// Initialization of the application and initial state of settings.
        /// </summary>
        public FrmMain()
        {
            // Timer elapses every second
            PomoTimer.Interval = 1000;
            
            // Set timer to event handler
            PomoTimer.Tick += TimeEventProcessor;

            InitializeComponent();

            // Force settings form to top
            _settings = new Settings();
            _settings.ShowDialog();
            
            // Set default PomoTimer
            _nextBreak = _settings.PomoTimer * 60;

            // Set timer label to 0:00
            lblTimer.Text = @"0:00"; 

            // Created DisabledPomo
            _disabledPomo = ToolStripRenderer.CreateDisabledImage(_pomoIcon);
           
            // Set PomoIcons to Disabled
            UpdatePomoIcon();
        }


        /// <summary>
        /// Handles minimizing the main form to the tray and enabling tray notifications
        /// </summary>
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) return;
            Hide();
            notifyIcon.Visible = true;
        }

        /// <summary>
        /// Handles bringing the main form back from minimized state through doubleclicking the tray icon
        /// </summary>
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }


        /// <summary>
        /// Handles actions at each tick of the timer by incrementing the count, updating the time label, 
        /// and checking to see if the timer is complete.
        /// </summary>
        private void TimeEventProcessor(object obj, EventArgs args)
        {
            // Increment by 1 second
            _timeKeep += 1;

            // Update timer label
            UpdateTimerLabel();

            // Check if Complete
            PomoCheck();
        }

        /// <summary>
        /// Checks if the timer is done, if so, take action based on if it's break time.
        /// </summary>
        private void PomoCheck()
        {
            // Check if timer is done
            if (_timeKeep != _nextBreak) return;
            
            // Stop timer and reset timer
            PomoTimer.Stop();
            _timeKeep = 0;
            UpdateTimerLabel();
            PomoTimer.Start();


            // If we are supposed to go on break, see how long it should be
            if (_break)
            {
                // Increment number of pomodoros completed
                _numPomo += 1;

                lblTimer.ForeColor = Color.Red;
                // If less than 4, go on a short break, otherwise go on a long break
                if (_numPomo < 4)
                {
                    _nextBreak = _settings.ShortBreak * 60;
                }
                else
                {
                    _nextBreak = _settings.LongBreak * 60;
                    _numPomo = 0; // We set NumPomo back to 0 here to clear the pomo icons
                }
                _break = false;
                
            }
            else
            {
                lblTimer.ForeColor = Color.Black;
                
                // Start a new pomo
                _nextBreak = _settings.PomoTimer * 60;
                _break = true;
            }

            // Update Icons
            UpdatePomoIcon();

            // Tell the user the timer is up
            if (_settings.AlertMe)
                Alert();
        }

        /// <summary>
        /// Alerts the user to the timer being done
        /// </summary>
        private void Alert()
        {

            var text = !_break ? "Take a break!" : "Break's over! Get back to work.";
            var title = @"Ding!";

            // Handling of notification location based on the minimized state of the form
            if (WindowState == FormWindowState.Normal)
            {
                MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.BalloonTipText = text;
                notifyIcon.BalloonTipTitle = title;
                notifyIcon.ShowBalloonTip(3000);
            }
           
        }

        /// <summary>
        /// Updates the icons resembling the number of Pomorodos completed in the set
        /// </summary>
        private void UpdatePomoIcon()
        {
            switch (_numPomo)
            {
                case 0:
                    picPomo1.Image = _disabledPomo;
                    picPomo2.Image = _disabledPomo;
                    picPomo3.Image = _disabledPomo;
                    picPomo4.Image = _disabledPomo;
                    break;
                case 1:
                    picPomo1.Image = _pomoIcon;
                    break;
                case 2:
                    picPomo2.Image = _pomoIcon;
                    break;
                case 3:
                    picPomo3.Image = _pomoIcon;
                    break;
                case 4:
                    picPomo4.Image = _pomoIcon;
                    break;
            }
        }

        /// <summary>
        /// Called primarily by <see cref="TimeEventProcessor"/> (but also others) to update the time display on the main form.
        /// </summary>
        private void UpdateTimerLabel()
        {
            // Math to get mins / seconds
            var minutes = _timeKeep / 60;
            var seconds = _timeKeep % 60;

            // String representation of the timer
            var timerString = seconds < 10 ? $"{minutes}:0{seconds}" : $"{minutes}:{seconds}";
            lblTimer.Text = timerString;
        }

        /// <summary>
        /// Starts or resumes the pomodoro timer 
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            PomoTimer.Start();
            btnReset.Enabled = false;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        /// <summary>
        /// Stops the timer. This also acts as a pause.
        /// </summary>
        private void btnStop_Click(object sender, EventArgs e)
        {
            PomoTimer.Stop();
            btnReset.Enabled = true;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        /// <summary>
        /// Resets the timer and form variables to their initial state
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Time Keeping
            _timeKeep = 0;
            UpdateTimerLabel();

            // If reset in the middle of a break, set label to black
            lblTimer.ForeColor = Color.Black;

            // Num Pomo
            _numPomo = 0;
            UpdatePomoIcon();        
        }


    }
}
