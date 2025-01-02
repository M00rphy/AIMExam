using AIMExam;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class MainViewModel : INotifyPropertyChanged
{
    private ObservableCollection<DataGridItem> _items;
    public ObservableCollection<DataGridItem> Items
    {
        get => _items;
        set
        {
            _items = value;
            OnPropertyChanged();
        }
    }

    public ICommand AddItemCommand { get; }

    public MainViewModel()
    {
        Items = new ObservableCollection<DataGridItem>
        {
            new DataGridItem { Step = 1, Length = 100, Rotation = 45, Angle = 90, Radius = 50, Speed = 10, Flags = "A", IO = "Input", Notes = "Example 1" },
            new DataGridItem { Step = 2, Length = 150, Rotation = 30, Angle = 60, Radius = 40, Speed = 15, Flags = "B", IO = "Output", Notes = "Example 2" }
        };

        AddItemCommand = new RelayCommand(AddItem);
    }

    private void AddItem()
    {
        var newItem = new DataGridItem
        {
            Step = Items.Count + 1,
            Length = 0,
            Rotation = 0,
            Angle = 0,
            Radius = 0,
            Speed = 0,
            Flags = "",
            IO = "",
            Notes = ""
        };
        Items.Add(newItem);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
