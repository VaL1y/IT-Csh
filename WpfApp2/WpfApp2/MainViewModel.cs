using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfApp2.Models;

namespace WpfApp2
{
    public class MainViewModel : ViewModelBase
    {
        private Figure _selectedFigure;
        public Figure SelectedFigure
        {
            get { return _selectedFigure; }
            set
            {
                if (_selectedFigure != value)
                {
                    _selectedFigure = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Figure> Figures { get; } = new ObservableCollection<Figure>();

        public ICommand DrawCommand { get; }

        public MainViewModel()
        {
            DrawCommand = new RelayCommand(Draw);
        }

        private void Draw()
        {
            // Logic to draw the selected figure
        }

        // INotifyPropertyChanged implementation
    }

    
}
