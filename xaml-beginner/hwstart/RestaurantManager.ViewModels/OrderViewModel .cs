using RestaurantManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.ViewModels
{
    public class OrderViewModel : ViewModel
    {
        private ObservableCollection<MenuItem> menuItems;

        private ObservableCollection<MenuItem> currentlySelectedMenuItems;

        protected override void OnDataLoaded()
        {
            this.MenuItems = this.Repository.StandardMenuItems as ObservableCollection<MenuItem>;

            this.CurrentlySelectedMenuItems = new ObservableCollection<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };

        }

        public ObservableCollection<MenuItem> MenuItems
        {
            get
            {
                return this.menuItems;
            }
            set
            {
                this.menuItems = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<MenuItem> CurrentlySelectedMenuItems
        {
            get
            {
                return this.currentlySelectedMenuItems;
            }
            set
            {
                this.currentlySelectedMenuItems = value;
                NotifyPropertyChanged();
            }
        }
    }
}
