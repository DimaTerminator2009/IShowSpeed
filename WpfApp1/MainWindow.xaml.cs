using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
  
    public partial class MainWindow : Window
    {
        int level = 0;
        int currentLevel = 0;
        Elevator elevator = new Elevator();
      
        public MainWindow()
        {
           
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            elevator.state = Elevator.ElevatorState.Move;

            level = Convert.ToInt32(tbLevel.Text);
            elevator.MoveTo(level, currentLevel, lbCurrentLevel);
            currentLevel = level;
            //lbCurrentLevel.Content = elevator.CurrentLevel;
          
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            
            if (elevator.state != Elevator.ElevatorState.Move)
            {
                btnStart.IsEnabled = false;
                recDoors.Visibility = Visibility.Visible;
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
           
            if (elevator.state != Elevator.ElevatorState.Move)
            {
                btnStart.IsEnabled = true;
                recDoors.Visibility = Visibility.Collapsed;
            }
        }
    }
}
