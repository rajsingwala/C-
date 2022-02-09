using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI.Model;
using WeatherAPI.ViewModel.Commands;
using WeatherAPI.ViewModel.Helpers;

namespace WeatherAPI.ViewModel
{
    public class WeatherVM : INotifyPropertyChanged
    {
        public ObservableCollection<AutoComplete> Cities;
        public event PropertyChangedEventHandler PropertyChanged;

        private string query;
        public string Query
        {
            get { return query; }
            set { query = value;
                OnPropertyChanged("Query");
                }
        }

        private CurrentCondition condition;
        public CurrentCondition Condition
        {
            get { return condition; }
            set { condition = value;
                OnPropertyChanged("Condition");
                }
        }

        private AutoComplete selectedCity;
        public AutoComplete SelectedCity
        {
            get { return selectedCity; }
            set { selectedCity = value;
                OnPropertyChanged("Selected City");
                GetConditions();
                }
        }

        public SearchCommand SearchCommand { get; set; }

        public WeatherVM()
        {
            SearchCommand = new SearchCommand(this);
            Cities = new ObservableCollection<AutoComplete>();
        }

        public async void GetConditions()
        {
            Query = string.Empty;
            Cities.Clear();
            Condition = await WeatherHelpers.GetCondition(SelectedCity.Key);
        }

        public async void MakeQuery()
        {
            var cities = await WeatherHelpers.GetAutoComplete(Query);

            Cities.Clear();
            foreach (var city in cities)
            {
                Cities.Add(city);
            }



        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
