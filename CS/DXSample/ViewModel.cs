using System;
using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Mvvm;

namespace DXSample {
    public class ViewModel : ViewModelBase {
        public ObservableCollection<RowObject> Items {
            get { return GetProperty(() => Items); }
            set { SetProperty(() => Items, value); }
        }
        public ViewModel() {
            Random random = new Random();

            Items = new ObservableCollection<RowObject>();
            for (int i = 0; i < 10; i++) {
                Items.Add(new RowObject() {
                    Id = i,
                    Name = String.Format("Name {0}", i),
                    Age = random.Next(18, 50),
                    RegistrationDate = DateTime.Now.AddDays(random.Next(-100, 100))
                });
            }
        }
    }
    public class RowObject : BindableBase {
        public int Id {
            get { return GetProperty(() => Id); }
            set { SetProperty(() => Id, value); }
        }
        public string Name {
            get { return GetProperty(() => Name); }
            set { SetProperty(() => Name, value); }
        }
        public int Age {
            get { return GetProperty(() => Age); }
            set { SetProperty(() => Age, value); }
        }
        public DateTime RegistrationDate {
            get { return GetProperty(() => RegistrationDate); }
            set { SetProperty(() => RegistrationDate, value); }
        }
    }
}
