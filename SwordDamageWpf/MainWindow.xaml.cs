using System;
using System.Diagnostics;
using System.Windows;
using SwordDamage_ConsoleApp;

namespace SwordDamageWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Random random = new Random();
        private SwordDamage swordDamage;
        
        public MainWindow()
        {
            InitializeComponent();
            int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            swordDamage = new SwordDamage(roll);
            DisplayDamage();
        }

        private void RollDice()
        {
            swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            swordDamage.Flaming = flaming.IsChecked.Value;
            swordDamage.Magic = magic.IsChecked.Value;
            DisplayDamage();
        }

        void DisplayDamage()
        {
            damage.Text = $"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }

        private void Flaming_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = true;
            DisplayDamage();
        }

        private void Flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = false;
            DisplayDamage();
        }

        private void Magic_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = true;
            DisplayDamage();
        }

        private void Magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = false;
            DisplayDamage();
        }
    }
}