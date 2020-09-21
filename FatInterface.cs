public interface Door  
    {
        void Lock();
        void UnLock();
        bool IsDoorOpen();
        void TimeOutCallback();
    }
    class Timer
    {
        public void Register(int timeInterval,Door  client) {

           if(client is TimedDoor)
            {
                client.TimeOutCallback();
            }
       }
    }
   
    class TimedDoor : Door
    {
        bool isDoorOpen;
        public bool IsDoorOpen()
        {
            throw new NotImplementedException();
        }

        public void Lock()
        {
            isDoorOpen = false;
        }

        public void TimeOutCallback()
        {
            Lock();
        }

        public void UnLock()
        {
            isDoorOpen = true;
        }
    }

    public class WoodenDoor : Door
    {
        public bool IsDoorOpen()
        {
            throw new NotImplementedException();
        }

        public void Lock()
        {
            throw new NotImplementedException();
        }

        public void TimeOutCallback()
        {
            throw new NotImplementedException();
        }

        public void UnLock()
        {
            throw new NotImplementedException();
        }
    }
    class ISP
    {
        static void Main()
        {
            TimedDoor _td = new TimedDoor();
            WoodenDoor _woodenDoor = new WoodenDoor();

            Timer _timer = new Timer();
            _timer.Register(1000, _td);
            _timer.Register(1000, _woodenDoor);
        }
    }
}
