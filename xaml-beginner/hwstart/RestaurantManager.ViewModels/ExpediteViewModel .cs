using RestaurantManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.ViewModels
{
    public class ExpediteViewModel : ViewModel
    {

        private ObservableCollection<Order> orderItems;

        protected override void OnDataLoaded()
        {
            //NotifyPropertyChanged("OrderItems");
            orderItems = base.Repository.Orders;
        }

        public ObservableCollection<Order> OrderItems
        {
            get { return orderItems; }
            set { orderItems = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
