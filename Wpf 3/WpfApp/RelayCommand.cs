using System;
using System.Windows.Input;

namespace WpfApp;

public class RelayCommand : ICommand
{
    private readonly Action<object?> _action;
    private readonly Func<object?, bool> _canExecute;
    public RelayCommand(Action<object?> action, Func<object?, bool> canExecute)
    {
        _action = action;
        _canExecute = canExecute;
    }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter) => _canExecute(parameter);

    public void Execute(object? parameter) => _action(parameter);
}