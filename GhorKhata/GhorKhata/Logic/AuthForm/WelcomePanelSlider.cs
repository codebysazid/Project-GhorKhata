using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhorKhata.Logic.AuthForm
{
    internal class WelcomePanelSlider
    {
        private System.Windows.Forms.Timer welcomeTimer;
        private Panel welcomePanel;
        private int Speed;
        private int axisY;
        private bool Sliding = false;

        public WelcomePanelSlider(Panel panel, System.Windows.Forms.Timer timer, int speed )
        {
            welcomePanel = panel;
            welcomeTimer = timer;
            Speed = speed;

            welcomeTimer.Tick += WelcomeTimer_Tick;
        }

        public void StartSliding()
        {
            Sliding = true;
            axisY = welcomePanel.Height;
            welcomeTimer.Start();
        }

        public void StopSliding()
        {

            Sliding = false;
            welcomeTimer.Stop();
        }

        private void WelcomeTimer_Tick(object? sender, EventArgs e)
        {
            welcomePanel.Top -= Speed;

            if (welcomePanel.Top + welcomePanel.Height <= 0)
            {
                StopSliding();
                welcomePanel.Visible = false;
            }
        }
    }

}
