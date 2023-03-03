namespace Motorcykel
{
    internal class Motorcycle
    {
        //Fields
        private bool started;
        private int rpm;
        private int gear;
        private string name;

        public string Name { get { return name; } set { name = value; } }

        public int Rpm
        {
            get { return rpm; }
            set {
                if (started)
                {
                    this.rpm = rpm;
                }
                if (rpm > 8000)
                {
                    this.rpm = 8000;
                }
                if (rpm < 1000)
                {
                    started = false;
                }
            }
        }

        public Motorcycle()
        {
            name = "";
            started = false;
            rpm = 0;
            gear = 0;

        }

        public Motorcycle(string name, bool started)
        {

            rpm = started ? 1000 : 0;
            gear = 0;
            Name = name;
            this.started = started;



            //if(started)
            //{
            //    rpm = 1000;
            //}
            //else
            //{
            //    rpm = 0;
                
            //}
            //gear = 0;
            //Name = name;
            //this.started = started;
        }



        //public void SetRpm(int rpm) 
        //{ 
        //    if (started)
        //    {
        //        this.rpm = rpm;
        //    }
        //    if(rpm > 8000)
        //    {
        //        this.rpm = 8000;
        //    }
        //    if(rpm < 1000)
        //    {
        //        started = false;
        //    }
            
        //}
        int GetRpm() { return rpm; }

        public bool IsStarted() { return started; }
        public void Start()
        {
            if(!started)
            {
                started = true;
                rpm = 1000;
                gear = 0;
            }
        }
        public void Stop()
        {
            if(!started) return;
            rpm = 0;
            gear = 0;
        }

        public int GetSpeed()
        {
            return rpm * gear / 200;
        }

        public void ShiftGearsUp()
        {
            if (started && gear < 5) gear++;
        }

        public void ShiftGearsDown()
        {
            if (started && gear > 1) gear--;
        }

        public int GetGear()
        {
            return gear;
        }


        public override string ToString()
        {
            return $"Name: {Name} Gear: {GetGear()}\nSpeed: {GetSpeed()}\nRpm; {GetRpm()}\nStarted: {IsStarted()}";
        }
    }
}
