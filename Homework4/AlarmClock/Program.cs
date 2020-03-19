using System;
using System.Threading;
namespace AlarmClock
{
    public delegate void TickHandler(DateTime time);
    public delegate void AlarmHandler(ClockTime clock);
    public class ClockTime
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
    }
    public class Tick {
        public event TickHandler OnTick;
        public void Ticking(DateTime currentTime)
        {
            OnTick(currentTime);
        }

    }
    public class AlarmClock
    {
        public event AlarmHandler OnAlarm;
        public void Alarming(int hour, int minute)
        {
            ClockTime clock = new ClockTime
            {
                Hour = hour,
                Minute = minute
            };
            OnAlarm(clock);
        }
    }
    public class Form
    {
        public AlarmClock alarm1 = new AlarmClock();
        public Tick tick1 = new Tick();
        public Form()
        {
            tick1.OnTick += new TickHandler(Tick_OnTick);
            alarm1.OnAlarm += new AlarmHandler(AlramClock_OnAlarm);
        }
        void Tick_OnTick(DateTime time)//每隔一秒Tick一下 输出当前时分秒
        {
            Thread.Sleep(1000);
            Console.WriteLine(DateTime.Now.ToString("T"));
        }
        void AlramClock_OnAlarm(ClockTime clock)//响闹钟
        {
            Console.WriteLine("闹钟响了！\a");
            Console.WriteLine("时间为:" + clock.Hour + "点" + clock.Minute+"分");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请设置闹钟");
            Console.WriteLine("设置小时:");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("设置分钟:");
            int minute = int.Parse(Console.ReadLine());
            bool ticking = true;
            Form form1 = new Form();
            while(ticking)
            {
                form1.tick1.Ticking(DateTime.Now);//开始Tick
                if (hour == DateTime.Now.Hour || minute == DateTime.Now.Minute)//当前时分符合闹钟设置的时间，发出alarm然后停止Tick
                {
                    form1.alarm1.Alarming(hour, minute);
                    ticking = false;//停止Tick
                }
            }
            Console.ReadLine();
        }
    }
}
