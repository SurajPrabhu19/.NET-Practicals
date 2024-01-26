using ServicesContracts;

namespace Services
{
    public class CityService: ICityService
    {
        private List<string> _cities;
        private Guid uniqueId;
        public CityService() { 
            uniqueId = Guid.NewGuid();
            _cities = new List<string>()
            {
                "Mumbai", "Kolkata", "Delhi", "Banglore"
            };
        }

        public List<string> getCities()
        {
            return _cities;
        }

        public string getUniqueId()
        {
            return uniqueId.ToString();
        }
    }
}
