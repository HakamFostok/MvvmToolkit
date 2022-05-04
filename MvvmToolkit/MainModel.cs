namespace MvvmToolkit;

[INotifyPropertyChanged]
public partial class MainModel
{
    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FullName))]
    private string _firstName = string.Empty;

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FullName))]
    private string _lastName = string.Empty;

    public string FullName => $"{FirstName} {LastName}";

    [ICommand]
    public void Sumbit()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
    }
}