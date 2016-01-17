using RestaurantManager.Models;
using RestaurantManager.ViewModels;
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
        #region Commands
        public DelegateCommand<MenuItem> AddMenuItemCommand { get; set; }
        public DelegateCommand<string> SubmitOrderCommand { get; set; }
        #endregion

        public OrderViewModel()
        {
            this.AddMenuItemCommand = new DelegateCommand<MenuItem>(AddMenuItemAction);
            this.SubmitOrderCommand = new DelegateCommand<string>(SubmitOrderAction);
           
        }


        #region Attributes


        private ObservableCollection<MenuItem> menuItems;

        private ObservableCollection<MenuItem> currentlySelectedMenuItems;
        #endregion

        #region Properties


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
        #endregion

        #region Methods
        private void SubmitOrderAction(string specialReq)
        {

            Repository.Orders.Add(new Order
            {
                Complete = false,
                Expedite = true,
                SpecialRequests = specialReq,
                Table = Repository.Tables.Last(),
                Items = currentlySelectedMenuItems,
            });
        }

        private void AddMenuItemAction(MenuItem menuItem)
        {
            if (this.currentlySelectedMenuItems == null) this.currentlySelectedMenuItems = new ObservableCollection<MenuItem>();
            this.currentlySelectedMenuItems.Add(menuItem);
        }
        protected override void OnDataLoaded()
        {
            this.MenuItems = this.Repository.StandardMenuItems as ObservableCollection<MenuItem>;

            this.CurrentlySelectedMenuItems = new ObservableCollection<MenuItem>
            {
                //this.MenuItems[3],
                //this.MenuItems[5]
            };

        }
        #endregion
    }
}
