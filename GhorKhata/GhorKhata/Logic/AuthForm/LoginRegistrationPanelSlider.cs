using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhorKhata.Logic.AuthForm
{
    internal class LoginRegistrationSlider
    {
        private System.Windows.Forms.Timer loginRegTimer;
        private Panel loginPanel;
        private Panel registrationPanel;
        private int Speed = 40;
        private bool SlidingLeft = false;
        private bool Sliding = false;

        public void StartSlidingLeft()
        {
            Sliding = true;
            SlidingLeft = true;
            registrationPanel.Top = loginPanel.Top;
            registrationPanel.Visible = true;
            loginRegTimer.Start();
        }

        public void StartSlidingRight()
        {
            Sliding = true;
            SlidingLeft = false;
            loginRegTimer.Start();
        }

        public void StopSliding()
        {
            Sliding = false;
            loginRegTimer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (SlidingLeft)
            {
                loginPanel.Left -= Speed;
                registrationPanel.Left -= Speed;

                int centerX = (loginPanel.Parent.ClientSize.Width - registrationPanel.Width) / 2;

                if (registrationPanel.Left <= centerX)
                {
                    StopSliding();
                    registrationPanel.Left = centerX;
                }
            }
            else
            {
                loginPanel.Left += Speed;
                registrationPanel.Left += Speed;

                int centerX = (loginPanel.Parent.ClientSize.Width - loginPanel.Width) / 2;

                if (loginPanel.Left >= centerX)
                {
                    StopSliding();
                    loginPanel.Left = centerX;
                    registrationPanel.Visible = false;
                }
            }
        }

        public void Dispose()
        {
            loginRegTimer.Tick -= Timer_Tick;
        }

        public LoginRegistrationSlider(Panel login, Panel registration, System.Windows.Forms.Timer timer, int speed)
        {
            loginPanel = login;
            registrationPanel = registration;
            loginRegTimer = timer;
            Speed = speed;

            loginRegTimer.Tick += Timer_Tick;
        }

    }
}