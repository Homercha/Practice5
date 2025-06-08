using System;

namespace Lab05Lib
{
    public class Town
    {
        public string Name;
        public string Country;
        public string Region;
        public int Population;
        public double YearIncome;
        public double Square;
        public bool HasPort;
        public bool HasAirport;
        public double PopulationDensity
        {
            get
            {
                return GetPopulationDensity();
            }
        }
        public double YearIncomePerInhabitant
        {
            get
            {
                return GetYearIncomePerInhabitant();
            }
        }
        public double GetYearIncomePerInhabitant()
        {
            return (Population != 0) ? YearIncome / Population : 0;
        }
        public double GetPopulationDensity()
        {
            return (Square != 0) ? Population / Square : 0;
        }
    }
}
