
using System.Windows;

namespace PickACardUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string[] pickedCards = CardsPicker.PickSomeCards((int)numberOfCards.Value);
            listOfCards.Items.Clear();
            foreach (string card in pickedCards) 
            {
                listOfCards.Items.Add(card);
            }
        }
    }
}
