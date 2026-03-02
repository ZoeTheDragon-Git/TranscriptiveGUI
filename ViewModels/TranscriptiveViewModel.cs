using CommunityToolkit.Mvvm.ComponentModel;

namespace LinuxGUI.ViewModels;

public partial class TranscriptiveViewModel : ViewModelBase
{
    // This is the code for the {Binding SampleName} - it just generates the public property
    [ObservableProperty]
    private string? _sampleName; 
}