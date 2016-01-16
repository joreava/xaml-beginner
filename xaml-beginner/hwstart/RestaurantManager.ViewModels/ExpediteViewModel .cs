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
        protected override void OnDataLoaded()
        {
            NotifyPropertyChanged("OrderItems");
        }

        public ObservableCollection<Order> OrderItems
        {
            get { return base.Repository.Orders; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
