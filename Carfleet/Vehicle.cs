using System;

namespace Carfleet{
    public class Vehicle
    {
        #region private attributes
        private string _registration;
        private string _brand;
        private string _model;
        private string _chassisNumber;
        #endregion private attributes

        #region public methods
        public Vehicle(string registration, string brand, string model, string chassisNumber)
        {
            _registration = registration;
            _brand = brand;
            _model = model;
            _chassisNumber = chassisNumber;
        }

        public string Registration
        {
            get
            {
                return _registration;
            }
            set
            {
<<<<<<< HEAD:Carfleet/Car.cs
                _registration= value;
=======
                _registration = value;
>>>>>>> 3805f8d1eb02f3f03f5de4e0568cee4dfb734356:Carfleet/Vehicle.cs
            }
        }

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
<<<<<<< HEAD:Carfleet/Car.cs
                _brand= value;
=======
                _brand = value;
>>>>>>> 3805f8d1eb02f3f03f5de4e0568cee4dfb734356:Carfleet/Vehicle.cs
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
<<<<<<< HEAD:Carfleet/Car.cs
                _model= value;
=======
                _model = value;
>>>>>>> 3805f8d1eb02f3f03f5de4e0568cee4dfb734356:Carfleet/Vehicle.cs
            }
        }

        public string ChassisNumber
        {
            get
            {
                return _chassisNumber;
            }
            set
            {
<<<<<<< HEAD:Carfleet/Car.cs
                _chassisNumber= value;
=======
                _chassisNumber = value;
>>>>>>> 3805f8d1eb02f3f03f5de4e0568cee4dfb734356:Carfleet/Vehicle.cs
            }
        }

        public override string ToString()
        {
            return this.Registration + " - " + this.Brand + " - " + this.Model + " - " + this.ChassisNumber;
        }
        #endregion public methods
    }
}
