using System;

namespace Carfleet{
    public class Truck:Vehicle
    {
        #region private attributes
        private Boolean _isCarryingGoods = false;
        #endregion private attributes

        #region public methods
        public Truck(string registration, string brand, string model, string chassisNumber):base(registration, brand, model, chassisNumber)
        {
        }

        public Boolean IsCarryingGoods
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            _registration = registration;
            _brand = brand;
            _model = model;
            _chassisNumber = chassisNumber;
        }
<<<<<<< HEAD

        public string Registration
        {
            get
            {
                return _registration;
            }
            set
            {
                _registration= value;
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
                _brand= value;
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
                _model= value;
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
                _chassisNumber= value;
            }
        }
=======
>>>>>>> 3805f8d1eb02f3f03f5de4e0568cee4dfb734356
        #endregion public methods
    }
}
