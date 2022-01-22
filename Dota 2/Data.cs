using System.Collections.ObjectModel;

namespace Dota_2
{
    static class Data
    {
        public static ObservableCollection<Перс> Персы = new ObservableCollection<Перс>();
        public static ObservableCollection<Классы> BLD = new ObservableCollection<Классы>();
        public static ObservableCollection<Main> Main = new ObservableCollection<Main>();
        public static ObservableCollection<Сложность> Difficulty = new ObservableCollection<Сложность>();
        public static ObservableCollection<Tip> Tip = new ObservableCollection<Tip>();
        public static ObservableCollection<KP> KP = new ObservableCollection<KP>();

    }
}
