
namespace WpfApp1
{
    public class MainViewModel : ViewModelBase
{
    private StackModel<int> stackModel;
    private RelayCommand pushCommand;
    private RelayCommand popCommand;
    private RelayCommand clearCommand;
    private string inputText;

    public MainViewModel()
    {
        stackModel = new StackModel<int>();

        // Инициализация команд
        PushCommand = new RelayCommand(Push, CanPush);
        PopCommand = new RelayCommand(Pop, CanPop);
        ClearCommand = new RelayCommand(Clear, CanClear);
    }

    public int CurrentElement
    {
        get { return stackModel.CurrentElement; }
    }

    public int Count
    {
        get { return stackModel.Count; }
    }

    public bool IsEmpty
    {
        get { return stackModel.IsEmpty; }
    }

    public string InputText
    {
        get { return inputText; }
        set
        {
            inputText = value;
            OnPropertyChanged(nameof(InputText));
            PushCommand.RaiseCanExecuteChanged();
        }
    }

    public RelayCommand PushCommand
    {
        get { return pushCommand; }
        set
        {
            pushCommand = value;
            OnPropertyChanged(nameof(PushCommand));
        }
    }

    public RelayCommand PopCommand
    {
        get { return popCommand; }
        set
        {
            popCommand = value;
            OnPropertyChanged(nameof(PopCommand));
        }
    }

    public RelayCommand ClearCommand
    {
        get { return clearCommand; }
        set
        {
            clearCommand = value;
            OnPropertyChanged(nameof(ClearCommand));
        }
    }

    public void Push(object parameter)
    {
        int value;
        if (int.TryParse(parameter.ToString(), out value))
        {
            stackModel.Push(value);
            OnPropertyChanged(nameof(CurrentElement));
            OnPropertyChanged(nameof(Count));
            OnPropertyChanged(nameof(IsEmpty));
        }
    }

    public bool CanPush(object parameter)
    {
        // Разрешить Push, если параметр не является null
        return parameter != null;
    }

    public void Pop(object parameter)
    {
        int poppedItem = stackModel.Pop();
        Console.WriteLine($"Popped Item: {poppedItem}");
        OnPropertyChanged(nameof(CurrentElement));
        OnPropertyChanged(nameof(Count));
        OnPropertyChanged(nameof(IsEmpty));
    }

    public bool CanPop(object parameter)
    {
        // Разрешить Pop, если стек не пуст
        return !stackModel.IsEmpty;
    }

    public void Clear(object parameter)
    {
        stackModel.Clear();
        OnPropertyChanged(nameof(CurrentElement));
        OnPropertyChanged(nameof(Count));
        OnPropertyChanged(nameof(IsEmpty));
    }

    public bool CanClear(object parameter)
    {
        // Разрешить Clear, если стек не пуст
        return !stackModel.IsEmpty;
    }
}

}
