using System.Collections.ObjectModel;
using System.Windows;

namespace AIMExam
{
    public partial class editLRArSegment : Window
    {
        private ObservableCollection<DataGridItem> _dataGridItems;
        private DataGridItem _dataGridItem;
        private bool _isEditMode;

        // Constructor for adding new item
        public editLRArSegment(ObservableCollection<DataGridItem> dataGridItems)
        {
            InitializeComponent();
            _dataGridItems = dataGridItems;
            _dataGridItem = new DataGridItem();
            this.DataContext = _dataGridItem;
            _isEditMode = false;
        }

        // Constructor for editing existing item
        public editLRArSegment(DataGridItem dataGridItem)
        {
            InitializeComponent();
            _dataGridItem = dataGridItem;
            this.DataContext = _dataGridItem;
            _isEditMode = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked!"); // Debug statement to verify button click

            // Validate and parse input values
            if (int.TryParse(length.Text, out var parsedLength) &&
                int.TryParse(rotation.Text, out var parsedRotation) &&
                int.TryParse(angle.Text, out var parsedAngle) &&
                int.TryParse(radius.Text, out var parsedRadius))
            {
                _dataGridItem.Length = parsedLength;
                _dataGridItem.Rotation = parsedRotation;
                _dataGridItem.Angle = parsedAngle;
                _dataGridItem.Radius = parsedRadius;

                if (!_isEditMode)
                {
                    // Add new item to the collection
                    _dataGridItem.Step = _dataGridItems.Count + 1; // Automatically increment the step
                    _dataGridItems.Add(_dataGridItem);

                    MessageBox.Show("Item added successfully.");
                }
                else
                {
                    MessageBox.Show("Item edited successfully.");
                }

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
