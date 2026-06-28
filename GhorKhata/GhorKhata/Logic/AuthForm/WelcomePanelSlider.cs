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
        private int Speed = 40;
        private bool Sliding = false;

        public void StartSliding()
        {
            Sliding = true;
            welcomeTimer.Start();
        }

        public void StopSliding()
        {
            Sliding = false;
            welcomeTimer.Stop();
        }

        public void Dispose()
        {
            welcomeTimer.Tick -= WelcomeTimer_Tick;
        }

        private void WelcomeTimer_Tick(object sender, EventArgs e)
        {
            welcomePanel.Top -= Speed;

            if (welcomePanel.Top + welcomePanel.Height <= 0)
            {
                StopSliding();
                welcomePanel.Visible = false;
            }
        }

        public WelcomePanelSlider(Panel panel, System.Windows.Forms.Timer timer, int speed)
        {
            welcomePanel = panel;
            welcomeTimer = timer;
            Speed = speed;

            welcomeTimer.Tick += WelcomeTimer_Tick;
        }
    }
}
