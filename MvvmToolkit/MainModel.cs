namespace MvvmToolkit;

[INotifyPropertyChanged]
public partial class MainModel
{
    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FullName))]
    [AlsoNotifyCanExecuteFor(nameof(SumbitCommand))]
    private string _firstName = string.Empty;

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FullName))]
    [AlsoNotifyCanExecuteFor(nameof(SumbitCommand))]
    private string _lastName = string.Empty;

    public string FullName => $"{FirstName} {LastName}";

    private bool CanSubmit =>
        !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);

    [ICommand(CanExecute = nameof(CanSubmit))]
    private void Sumbit()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
    }
}