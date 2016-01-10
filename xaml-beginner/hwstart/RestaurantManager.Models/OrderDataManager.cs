using System.Collections.Generic;
using System.ComponentModel;


namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {

        private List<MenuItem> menuItems;

        private List<MenuItem> currentlySelectedMenuItems;

        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };

        }

        public List<MenuItem> MenuItems
        {
            get
            {
                return this.menuItems;
            }
            set
            {
                this.menuItems = value;
                OnPropertyChanged();
            }
        }

        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get
            {
                return this.currentlySelectedMenuItems;
            }
            set
            {
                this.currentlySelectedMenuItems = value;
                OnPropertyChanged();
            }
        }
    }
}