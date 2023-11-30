using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WpfApp;

public class MainViewModel : INotifyPropertyChanged
{
    private int _counter;
    public event PropertyChangedEventHandler? PropertyChanged;

    public int Counter
    {
        get
        {
            return _counter;
        }
        set
        {
            _counter = value;
            OnPropertyChanged();
        }
    }

    public ICommand IncrementCommand => new RelayCommand(o => Increment(), o => true);
    public ICommand DecrementCommand => new RelayCommand(o => Decrement(), o => true);
    public ICommand SquareCommand => new RelayCommand(o => Square(), o => true);

    public void Increment()
    {
        Counter++;
    }

    public void Decrement()
    {
        Counter--;
    }

    public void Square()
    {
        Counter = (int)Math.Pow(Counter, 2);
    }

    protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}