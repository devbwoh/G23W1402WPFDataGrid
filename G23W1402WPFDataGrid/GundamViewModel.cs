using System.Collections.ObjectModel;
using System.ComponentModel;

namespace G23W1402WPFDataGrid;

class GundamViewModel : INotifyPropertyChanged
{
    private ObservableCollection<GundamModel> _gundamList 
        = new ObservableCollection<GundamModel>();

    public ObservableCollection<GundamModel> GundamList {
        get { return _gundamList; }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private string _gundamImage = "";

     public string GundamImage {
        get { return _gundamImage; }
    }

    public void Add(GundamModel model) {
        _gundamList.Add(model);
    }

    public void Select(GundamModel model) {
        _gundamImage = $"images/{model.Name}.jpg";
        OnPropertyChanged(nameof(GundamImage));
    }

    // propName에 "GundamImage"가 넘어감
    protected void OnPropertyChanged(string propName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

}
