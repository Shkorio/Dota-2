using Dota_2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Dota_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Перс selectedFood;

        public ObservableCollection<Перс> Персы
        {
            get => Data.Персы;
        }
        public ObservableCollection<Классы> Классы
        {
            get => Data.BLD;
        }
        public ObservableCollection<Сложность> Сложность
        {
            get => Data.Difficulty;
        }
       








        public Перс SelectedFood
        {
            get => selectedFood;
            set
            {
                selectedFood = value;
                Signal();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

       

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void AddFood(object sender, RoutedEventArgs e)
        {
          Персы.Add(new Перс
            {
                Nazv = "         *Перс*",
            });
        }

        private void DeleteFood(object sender, RoutedEventArgs e)
        {
            if (SelectedFood == null)
                return;
            if (MessageBox.Show("Вы действительно хотите удалить выбранного персонажа?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Персы.Remove(SelectedFood);
                SelectedFood = null;
            }
        }

        private void OpenBLD(object sender, RoutedEventArgs e)
        {
            BLDWin win = new BLDWin();
            win.ShowDialog();
        }
        private void OpenDifficulty(object sender, RoutedEventArgs e)
        {
            DifficultyWin win = new DifficultyWin();
            win.ShowDialog();
        }
        private void OpenTip(object sender, RoutedEventArgs e)
        {
            TipWin win = new TipWin();
            win.ShowDialog();
        }
        private void OpenKP(object sender, RoutedEventArgs e)
        {
            KPWin win = new KPWin();
            win.ShowDialog();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
        }
        
    

