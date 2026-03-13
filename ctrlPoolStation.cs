using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPoolClubProject
{
    public partial class ctrlPoolStation : UserControl
    {
        public ctrlPoolStation() => InitializeComponent();

        [Category("Pool Event"), Description("When Game Finish")]
        public event EventHandler<clsUtils.cls8PoolEventArgs> OnGameFinish = null;

        // To Remove The Misc From The Property Grid And Change It To Pool Config - And Add The Description Which Is The Name Of The Property
        [Category("Pool Config"), Description("The Player Name.")]
        public string PlayerName
        {
            get => lblPlayerName.Text;
            set
            {
                lblPlayerName.Text = value.Trim();
                Invalidate();
            }
        }

        // To Remove The Misc From The Property Grid And Change It To Pool Config - And Add The Description Which Is The Name Of The Property
        [Category("Pool Config"), Description("The table Name.")]
        public string TableName
        {
            get => gbTableName.Text;
            set
            {
                gbTableName.Text = value.Trim();
                Invalidate();
            }
        }

        // To Remove The Misc From The Property Grid And Change It To Pool Config - And Add The Description Which Is The Name Of The Property
        [Category("Pool Config"), Description("Hourly Rate.")]
        public double HourlyRate { get; set; } = 10;

        private double _SecondsConsumbed = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_sw.IsRunning)
                return;

            lblTime.Text = _sw.Elapsed.ToString(@"hh\:mm\:ss");
            lblTime.Refresh();

            _SecondsConsumbed++;
        }

        private Stopwatch _sw = new Stopwatch();

        private void _StopTimers()
        {
            timer1.Stop();
            _sw.Stop();
        }

        private void _RefreshTimer()
        {
            lblTime.Text = "00:00:00";
            _sw.Restart();
            _SecondsConsumbed = 0;
        }

        /// <summary>
        /// Sets the visibility of the Start and Stop controls.
        /// </summary>
        /// <param name="IsStopVisable">A value indicating whether the Stop control is visible. Set to <see langword="true"/> to display the Stop
        /// control; otherwise, <see langword="false"/>.</param>
        /// <param name="IsStartVisable">A value indicating whether the Start control is visible. Set to <see langword="true"/> to display the Start
        /// control; otherwise, <see langword="false"/>.</param>
        private void _Start_StopCTRLVisabillty(bool IsStopVisable, bool IsStartVisable)
        {
            btnStop.Visible = IsStopVisable;
            btnStart.Visible = IsStartVisable;
        }

        /// <summary>
        /// Start The Game And Check If It's The First Time To Start The Stopwatch
        /// </summary>
        private void _StartClocks()
        {
            if (_SecondsConsumbed == 0)
                _sw = new Stopwatch();

            timer1.Start();
            _sw.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _StartClocks();
            _Start_StopCTRLVisabillty(true, false);
        }

        private void _LogGameInfo() => clsUtils.RaiseLogToEventViewer($"Table: ({TableName}) Has Finished Playing.\n" +
                                        $"Consumed Time: {_SecondsConsumbed / 3600} Hours\n" +
                                        $"Main Player Name: {PlayerName}.\n" +
                                        $"Finished On {DateTime.Now}.");

        private void _RaiseGameFinishedEvent()
        {
            double totalFees = (_SecondsConsumbed / 3600) * HourlyRate;
            OnGameFinish?.Invoke(this, new clsUtils.cls8PoolEventArgs(lblTime.Text.Trim(), _SecondsConsumbed, HourlyRate, totalFees));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //btnStop.PerformClick();
            btnStop_Click(null, null);
            _LogGameInfo();
            _RaiseGameFinishedEvent();
            _RefreshTimer();
            _ResetGame();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _StopTimers();
            _Start_StopCTRLVisabillty(false, true);
        }

        private void ctrlPoolStation_Load(object sender, EventArgs e) => _RefreshTimer();

        private void _ResetGame()
        {
            PlayerName = "Player 1";
            TableName = "Table 1";
        }
    }
}
