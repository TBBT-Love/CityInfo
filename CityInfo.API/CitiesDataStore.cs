using CityInfo.API.Model;

namespace CityInfo.API
{
    public class CitiesDataStore
    {

        public List<CityDTO> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {
            //init dummy Data
            Cities = new List<CityDTO>() {

            new CityDTO(){
               Id = 1,
                Name = "Shimla",
                 Description="Queen of hills"
            },new CityDTO(){
               Id = 2,
                Name = "Darjeeling",
                 Description="Land of tea"
            },new CityDTO(){
               Id = 3,
                Name = "Chirapunjee",
                 Description="Land where it rains a lot!!"
            }
        };
        }
    }
}
