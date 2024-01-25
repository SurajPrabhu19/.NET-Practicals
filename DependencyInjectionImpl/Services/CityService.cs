using ServicesContracts;

namespace Services
{
    public class CityService: ICityService
    {
        private List<string> _cities;
        public CityService() { 
            _cities = new List<string>()
            {
                "Mumbai", "Kolkata", "Delhi", "Banglore"
            };
        }

        public List<string> getCities()
        {
            return _cities;
        }
    }
}
