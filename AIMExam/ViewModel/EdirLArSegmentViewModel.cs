using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace AIMExam
{
    public class EditLRArSegmentViewModel : INotifyPropertyChanged
    {
        private decimal _length;
        private decimal _rotation;
        private decimal _angle;
        private decimal _radius;

        public decimal Length
        {
            get => _length;
            set
            {
                if (ValidateNumericInput(value.ToString()))
                {
                    _length = value;
                    OnPropertyChanged();
                }
                else
                {
                    MessageBox.Show("Invalid numeric value for Length.");
                }
            }
        }

        public decimal Rotation
        {
            get => _rotation;
            set
            {
                if (ValidateNumericInput(value.ToString()))
                {
                    _rotation = value;
                    OnPropertyChanged();
                }
                else
                {
                    MessageBox.Show("Invalid numeric value for Rotation.");
                }
            }
        }

        public decimal Angle
        {
            get => _angle;
            set
            {
                if (ValidateNumericInput(value.ToString()))
                {
                    _angle = value;
                    OnPropertyChanged();
                }
                else
                {
                    MessageBox.Show("Invalid numeric value for Angle.");
                }
            }
        }

        public decimal Radius
        {
            get => _radius;
            set
            {
                if (ValidateNumericInput(value.ToString()))
                {
                    _radius = value;
                    OnPropertyChanged();
                }
                else
                {
                    MessageBox.Show("Invalid numeric value for Radius.");
                }
            }
        }

        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        public EditLRArSegmentViewModel()
        {
            SaveCommand = new RelayCommand(param => Save());
            CancelCommand = new RelayCommand(param => Cancel());
        }

        private void Save()
        {
            MessageBox.Show("Values saved successfully!");
            Application.Current.Windows[Application.Current.Windows.Count - 1].Close();
        }

        private void Cancel()
        {
            Application.Current.Windows[Application.Current.Windows.Count - 1].Close();
        }

        private bool ValidateNumericInput(string input)
        {
            return decimal.TryParse(input, out _);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
