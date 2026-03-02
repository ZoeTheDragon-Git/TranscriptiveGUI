using CommunityToolkit.Mvvm.ComponentModel;

namespace LinuxGUI.ViewModels;

public partial class TranscriptiveViewModel : ViewModelBase
{
    [ObservableProperty]
    private string? _sampleName; 
}