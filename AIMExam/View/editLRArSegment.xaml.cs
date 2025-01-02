using System.Collections.ObjectModel;
using System.Windows;

namespace AIMExam
{
    public partial class editLRArSegment : Window
    {
        private ObservableCollection<DataGridItem> _dataGridItems;

        public editLRArSegment(ObservableCollection<DataGridItem> dataGridItems)
        {
            InitializeComponent();
            _dataGridItems = dataGridItems;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Validate and parse input values
            if (decimal.TryParse(length.Text, out var parsedLength) &&
                decimal.TryParse(rotation.Text, out var parsedRotation) &&
                decimal.TryParse(angle.Text, out var parsedAngle) &&
                decimal.TryParse(radius.Text, out var parsedRadius))
            {
                // Add new item to the collection
                _dataGridItems.Add(new DataGridItem
                {
                    Step = _dataGridItems.Count + 1, // Automatically increment the step
                    Length = (int)parsedLength,
                    Rotation = (int)parsedRotation,
                    Angle = (int)parsedAngle,
                    Radius = (int)parsedRadius,
                    Speed = 0, // Default values for other fields
                    Flags = string.Empty,
                    IO = string.Empty,
                    Notes = string.Empty
                });

                // Close the dialog
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
