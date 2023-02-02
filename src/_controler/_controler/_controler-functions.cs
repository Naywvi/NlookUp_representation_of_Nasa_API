using application;
namespace config{
    public class func{
        public static ListBox list = new ListBox();

        public static void addListAsteroid(){
            list.Items.Clear();
            foreach (var item in request.result.near_earth_objects){
                foreach (var asteroid in item.Value){
                    list.Items.Add("id : "+ asteroid.id + " date : " + asteroid.close_approach_data[0].close_approach_date_full + " name : " + asteroid.name );
                }
            }
        }
    }
}