using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TripLog.Models;

namespace TripLog.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
          LogEntries = new ObservableCollection<TripLogEntry>
{
                new TripLogEntry
{
Title = "Harar Jagol",
Notes = "Amazing!",
Rating = 3,
Date = new DateTime(2020, 2, 5),
Latitude = 9.3126,
Longitude = 42.1227
},
new TripLogEntry
{
Title = "Washington Monument",
Notes = "Amazing!",
Rating = 3,
Date = new DateTime(2019, 2, 5),
Latitude = 38.8895,
Longitude = -77.0352
},
new TripLogEntry
{
Title = "Statue of Liberty",
Notes = "Inspiring!",
Rating = 4,
Date = new DateTime(2019, 4, 13),
Latitude = 40.6892,
Longitude = -74.0444
},
new TripLogEntry {
Title = "Golden Gate Bridge",
Notes = "Foggy, but beautiful.",
Rating = 5,
Date = new DateTime(2019, 4, 26),
Latitude = 37.8268,
Longitude = -122.4798
}
};
}
 ObservableCollection<TripLogEntry> _logEntries;
 public ObservableCollection<TripLogEntry> LogEntries
        {
            get => _logEntries;
            set
            {
                _logEntries = value;
                OnPropertyChanged();
            }
        }
    }
}
