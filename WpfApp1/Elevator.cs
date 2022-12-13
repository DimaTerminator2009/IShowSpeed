using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WpfApp1
{
    public class Elevator
    {

        public enum ElevatorState { Move, Stop}
        public ElevatorState state = ElevatorState.Stop;
        int Level;
        public int CurrentLevel = 0;
        DispatcherTimer timer;
        Label lbLevel;
        public Elevator()
        {
           
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
           
        }

        public void MoveTo(int level, int currentLevel, Label label)
        {
            Level = level; // 3
            CurrentLevel = currentLevel; // 0
            lbLevel = label;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (CurrentLevel < Level)
            {
     
          
                CurrentLevel++;
                lbLevel.Content = CurrentLevel;
            }
            else if (CurrentLevel > Level)
            {
        
                CurrentLevel--;
                lbLevel.Content = CurrentLevel;
            }
            else
            state = ElevatorState.Stop;
        }
    
    }

}
