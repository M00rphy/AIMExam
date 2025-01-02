using System.Collections.ObjectModel;
using System.Windows;

namespace AIMExam
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<DataGridItem> DataGridItems { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the ObservableCollection with sample data
            DataGridItems = new ObservableCollection<DataGridItem>
            {
                new DataGridItem { Step = 1, Length = 100, Rotation = 45, Angle = 90, Radius = 50, Speed = 10, Flags = "A", IO = "Input", Notes = "Example 1" },
                new DataGridItem { Step = 2, Length = 150, Rotation = 30, Angle = 60, Radius = 40, Speed = 15, Flags = "B", IO = "Output", Notes = "Example 2" }
            };

            // Bind DataGridItems to the DataContext
            this.DataContext = this;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            var editLRArSegmentWindow = new editLRArSegment(DataGridItems);
            editLRArSegmentWindow.ShowDialog();
        }
    }

    public class DataGridItem
    {
        public int Step { get; set; }
        public int Length { get; set; }
        public int Rotation { get; set; }
        public int Angle { get; set; }
        public int Radius { get; set; }
        public int Speed { get; set; }
        public string Flags { get; set; }
        public string IO { get; set; }
        public string Notes { get; set; }
    }
}
