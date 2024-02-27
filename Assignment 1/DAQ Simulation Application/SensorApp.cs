using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SensorApp
{
    // Purpose: Simulate a sensor which can give acumulating sensor values between -5 and 5
    // Version: 29/01-24
    // Author: Torstein Solheim Olberg
    public class Sensor(int sensor_number)
	{
		double value = 0.0F;
		readonly Random random_sensor_value = new(sensor_number);

        // Purpose: Return a new accumulated value. Adds a random value between -5 and 5 to the last.
        // Version: 30/01-24
        // Author: Torstein Solheim Olberg
        public double GetNewValue()
		{
			double min_value = -5F;
			double max_value = 5F;

			value += random_sensor_value.NextDouble();
			return ((max_value - min_value) * value) + min_value;
		}
	}

    // Purpose: Dataclass for storing sensor data of 6 sensors
    // Version: 30/01-24
    // Author: Torstein Solheim Olberg
    public class Sensordata : IEnumerable<double>
    {
        public string? Date {  get; set; }
		public double _sensor_0 { get; set; }
        public double _sensor_1 { get; set; }
        public double _sensor_2 { get; set; }
        public double _sensor_3 { get; set; }
        public double _sensor_4 { get; set; }
        public double _sensor_5 { get; set; }

        // Purpose: returning sensors values in order
        // Version: 30/01-24
        // Author: Torstein Solheim Olberg
        public IEnumerator<double> GetEnumerator()
        {
            yield return _sensor_0;
            yield return _sensor_1;
            yield return _sensor_2;
            yield return _sensor_3;
            yield return _sensor_4;
            yield return _sensor_5;
        }

        // Purpose: Making the dataclass iterable
        // Version: 30/01-24
        // Author: Torstein Solheim Olberg
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Purpose: Making the data class indexable
        // Version: 30/01-24
        // Author: Torstein Solheim Olberg
        public double this[int index]
		{
			get
			{
                return index switch
                {
                    0 => _sensor_0,
                    1 => _sensor_1,
                    2 => _sensor_2,
                    3 => _sensor_3,
                    4 => _sensor_4,
                    5 => _sensor_5,
                    _ => 0,
                };
            }
            set
			{
                switch (index)
                {
                    case 0:
                        _sensor_0 = value;
                        break;
                    case 1:
                        _sensor_1 = value;
                        break;
                    case 2:
                        _sensor_2 = value;
                        break;
                    case 3:
                        _sensor_3 = value;
                        break;
                    case 4:
                        _sensor_4 = value;
                        break;
                    case 5:
                        _sensor_5 = value;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}