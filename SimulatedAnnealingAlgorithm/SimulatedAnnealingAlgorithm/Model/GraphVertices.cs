using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatedAnnealingAlgorithm.Model
{
    public class GraphVertices
    {
        private List<String> cities = new List<String>();

        private List<String> departureСities = new List<String>();

        private List<String> arrivalСities = new List<String>();

        private List<Int32> flightPrices = new List<Int32>();

        private List<Int32> returnFlightPrices = new List<Int32>();

        public GraphVertices(String s)
        {
            setAll(s);
        }

        public List<String> getCities()
        {
            return cities;
        }

        public List<String> getDepartureСities()
        {
            return departureСities;
        }

        public List<String> getArrivalСities()
        {
            return arrivalСities;
        }

        public List<Int32> getFlightPrices()
        {
            return flightPrices;
        }

        public List<Int32> getReturnFlightPrice()
        {
            return returnFlightPrices;
        }

        private void setAll(String s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                String departureCity = "";
                String arrivalCity = "";
                String flightPrice = "";
                String returnFlightPrice = "";

                while (s[i] != ';')
                {
                    departureCity += s[i];
                    i++;
                }

                i++;

                while (s[i] != ';')
                {
                    arrivalCity += s[i];
                    i++;
                }

                i++;

                while (s[i] != ';')
                {
                    flightPrice += s[i];
                    i++;
                }

                i++;

                while (s[i] != '\n')
                {
                    if (s[i] != '\r')
                    {
                        returnFlightPrice += s[i];
                    }
                    i++;

                    if (i == s.Length) break;
                }

                this.departureСities.Add(departureCity);
                this.arrivalСities.Add(arrivalCity);

                if (flightPrice.Equals("N/A"))
                    this.flightPrices.Add(0);
                else
                    this.flightPrices.Add(Convert.ToInt32(flightPrice));

                if (returnFlightPrice.Equals("N/A"))
                    this.returnFlightPrices.Add(0);
                else
                    this.returnFlightPrices.Add(Convert.ToInt32(returnFlightPrice));
            }

            setCities();
        }

        private void setCities()
        {
            for (int i = 0; i < this.departureСities.Count; i++)
            {

                String departureCity = this.departureСities[i];

                if (!this.cities.Contains(departureCity))
                    this.cities.Add(departureCity);
            }

            for (int i = 0; i < this.arrivalСities.Count; i++)
            {
                String arrivalCity = this.arrivalСities[i];

                if (!this.cities.Contains(arrivalCity))
                    this.cities.Add(arrivalCity);
            }
        }

        public int getPriceOfWay(String from, String to)
        {

            for (int i = 0; i < this.departureСities.Count; i++)
            {

                if (this.departureСities[i].Equals(from)
                        && this.arrivalСities[i].Equals(to))
                {
                    return this.flightPrices[i];
                }

                if (this.departureСities[i].Equals(to)
                        && this.arrivalСities[i].Equals(from))
                {
                    return this.returnFlightPrices[i];
                }
            }

            return 0;
        }

        /*public void printRepository()
        {

            System.out.print("cities: ");
            cities.printList();

            System.out.print("departureСities: ");
            departureСities.printList();

            System.out.print("arrivalCities: ");
            arrivalСities.printList();

            System.out.print("flightPrice: ");
            flightPrices.printList();

            System.out.print("returnFlightPrice: ");
            returnFlightPrices.printList();

        }*/
    }
}
