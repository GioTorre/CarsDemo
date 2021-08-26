using demo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace demo.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        /// <summary>Gets or sets the car.</summary>
        /// <value>The car.</value>
        public Car Car
        {
            get { return _car; }
            set { SetProperty(ref _car, value); }
        }

        /// <summary>Gets or sets the car selected.</summary>
        /// <value>The car selected.</value>
        public Car CarSelected
        {
            get { return _carSelected; }
            set { SetProperty(ref _carSelected, value); ItemTapped(); }
        }

        /// <summary>Gets or sets the list cars.</summary>
        /// <value>The list cars.</value>
        public ObservableCollection<Car> ListCars
        {
            get { return _cars; }
            set { SetProperty(ref _cars, value); }
        }

        /// <summary>Gets or sets the name of button.</summary>
        /// <value>The name of button.</value>
        public string NameOfButton
        {
            get { return _NameOfButton; }
            set { SetProperty(ref _NameOfButton, value); }
        }

        /// <summary>Gets or sets the add car.</summary>
        /// <value>The add car.</value>
        public ICommand AddCarCommand { get; set; }

        /// <summary>Gets or sets the item car tapped command.</summary>
        /// <value>The item car tapped command.</value>
        public ICommand ItemCarTappedCommand { get; set; }


        /// <summary>Initializes a new instance of the <see cref="AboutViewModel" /> class.</summary>
        public AboutViewModel()
        {
            _car = new Car();
            NameOfButton = "Add Car";
            _cars = new ObservableCollection<Car>();
            AddCarCommand = new Command(AddCars);
            ItemCarTappedCommand = new Command(ItemTapped);
        }

        private ObservableCollection<Car> _cars;
        private Car _carSelected;
        private Car _car;
        private string _NameOfButton;
        
        private void AddCars()
        {
            if (this._car.Id != Guid.Empty)
            {
                var modifyItem = this._cars.FirstOrDefault(x => x.Id == this._car.Id);

                if (modifyItem != null)
                {
                    modifyItem = this._car;
                }

                this._car = new Car();
            }
            else
            {
                this._car.Id = Guid.NewGuid();
                this._cars.Add(this.Car);
                this._car = new Car();
            }

            NameOfButton = "Add Car";
        }

        private void ItemTapped()
        {
            this.Car = this.CarSelected;
            NameOfButton = "Modify Car";
        }
    }
}