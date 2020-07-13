using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
   public class LocationModel

    {
        private string _locationName;
        private int _defaultStock = 50;
        public int Stock
        {
            get => _defaultStock;
            set
            {
                if (value > Stock)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _defaultStock -= value;

            }
        }

        public string LocationName
        {
            get => _locationName;
            set
            {

                if (_locationName != "Auburn")
                {
                    throw new ArgumentException($"{value} is not a valid Store Location");
                }
                else if (_locationName != "Syracuse")
                {
                    throw new ArgumentException($"{value} is not a valid Store Location");
                }
                else if (_locationName != "Rochester")
                {
                    throw new ArgumentException($"{value} is not a valid Store Location");
                }

                _locationName = value;

            }
        }

        public int LocationId { get; set; }




    }
}
