using BeehiveManagementSystem.bees;
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

namespace BeehiveManagementSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Queen queen;
        public MainWindow()
        {
            InitializeComponent();
            SetComboBoxItemFromEnum();

            queen = new Queen();
            statusReport.Text = queen.StatusReport;
        }

        private void SetComboBoxItemFromEnum()
        {
            foreach (BeeType item in Enum.GetValues(typeof(BeeType)))
            {
                jobSelector.Items.Add(item);
            }
        }

        private void Button_Click_WorkNextShift(object sender, RoutedEventArgs e)
        {
            queen.WorkTheNextShift();
            statusReport.Text = queen.StatusReport;
        }

        private void Button_Click_AssignJob(object sender, RoutedEventArgs e)
        {
            BeeType type = (BeeType)Enum.Parse(typeof(BeeType), jobSelector.SelectedItem.ToString());
            
            queen.AssignBee(type);
            statusReport.Text = queen.StatusReport;
        }
    }
}
