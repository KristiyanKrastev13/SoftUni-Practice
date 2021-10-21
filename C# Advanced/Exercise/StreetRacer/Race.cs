using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxhp)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxhp;
            Participants = new List<Car>();
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public List<Car> Participants { get; set; }
        public int Count => Participants.Count;

        public void Add(Car car)
        {
            string licence = car.LicensePlate;
            Car contained = Participants.FirstOrDefault(c => c.LicensePlate == licence);
            if (contained == null && Participants.Count + 1 <= Capacity)
            {
                Participants.Add(car);
            }
        }
        public bool Remove(string licensePlate)
        {
            Car isValid = Participants.FirstOrDefault(c => c.LicensePlate == licensePlate);
            if (isValid != null)
            {
                Participants.Remove(isValid);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Car FindParticipant(string licensePlate)
        {
            Car isValid = Participants.FirstOrDefault(c => c.LicensePlate == licensePlate);
            if (isValid != null)
            {
                Participants.Remove(isValid);
                return isValid;
            }
            else
            {
                return isValid;
            }
        }

        public Car GetMostPowerfulCar()
        {
            Car isValid = Participants.OrderByDescending(c => c.HorsePower).FirstOrDefault();
            return isValid;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var car in Participants)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString();
        }


    }
}
