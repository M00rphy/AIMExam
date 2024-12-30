using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AIMExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Sample data for binding
            var sampleData = new List<DataGridItem>
        {
            new DataGridItem { Step = 1, Length = 100, Rotation = 45, Angle = 90, Radius = 50, Speed = 10, Flags = "A", IO = "Input", Notes = "Example 1" },
            new DataGridItem { Step = 2, Length = 150, Rotation = 30, Angle = 60, Radius = 40, Speed = 15, Flags = "B", IO = "Output", Notes = "Example 2" }
        };

            this.DataContext = sampleData;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var editLRArSegment = new editLRArSegment();
            editLRArSegment.Show();
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