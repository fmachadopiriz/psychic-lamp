using System;

namespace Library
{
    public class Lamp
    {
        private bool isOn;

        public void TurnOn()
        {
            this.isOn = true;
        }

        public void TurnOff()
        {
            this.isOn = false;
        }

        public bool IsOn
        {
            get
            {
                return this.isOn;
            }
        }
    }
}
