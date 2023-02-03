using application;
namespace config{
    public class func{
        public static ListBox list = new ListBox();
        public static ListBox listOrbit = new ListBox();
        public static Label AROrbitV = new Label();
        public static Label AROrbitV2 = new Label();
        public static Label AROrbitV3 = new Label();
        public static Label AROrbitV4 = new Label();
        public static Label AROrbitM2 = new Label();
        public static Label AROrbitM3 = new Label();
        public static Label AROrbitM4 = new Label();
        public static Label AROrbitM5 = new Label();
        public static Label AROrbitM = new Label();


        public static Label ARNameAsteroide = new Label();
        public static Label ARSuspicious = new Label();
        public static Label ARMagnitude = new Label();
        public static Label ARUncertain = new Label();
        public static Label AREquinox = new Label();
        public static RadioButton ARkm = new RadioButton();
        public static RadioButton ARml = new RadioButton();
        public static Label estimSmin = new Label();
        public static Label estimSmax = new Label();
        public static Label estimHmin = new Label();
        public static Label estimHmax = new Label();
        public static Label ARFirst = new Label();
        public static Label ARLast = new Label();
        public static Label ARNumber = new Label();
        public static Label ARDescriptionA = new Label();
        public static void addListAsteroid(){
            list.Items.Clear();
            foreach (var item in request.result.near_earth_objects){
                foreach (var asteroid in item.Value){
                    list.Items.Add("id : "+ asteroid.id + " date : " + asteroid.close_approach_data[0].close_approach_date_full + " name : " + asteroid.name );
                }
            }
        }
        
        public static void addListAsteroidOrbit(){
            var count = -1;
            listOrbit.Items.Clear();
            foreach (var item in request.resultAsteroid.close_approach_data){
                count++;
                listOrbit.Items.Add(count.ToString()+" - " + item.close_approach_date_full + " orbiting " + item.orbiting_body);
            }
        }

        public static void getResultAsteroidOrbit(string idS){
            var id = int.Parse(idS);
            AROrbitV.Text = "Date of Observation : " + request.resultAsteroid.close_approach_data[id].close_approach_date_full;
            AROrbitV2.Text = "Estimated velocity km/h : " + request.resultAsteroid.close_approach_data[id].relative_velocity.kilometers_per_hour;
            AROrbitV3.Text = "Estimated velocity km/s : " + request.resultAsteroid.close_approach_data[id].relative_velocity.kilometers_per_second;
            AROrbitV4.Text = "Estimated miles/h : " + request.resultAsteroid.close_approach_data[id].relative_velocity.miles_per_hour;
            AROrbitM2.Text = "Astronom : " + request.resultAsteroid.close_approach_data[id].miss_distance.astronomical;
            AROrbitM3.Text = "Lunar : " + request.resultAsteroid.close_approach_data[id].miss_distance.lunar;
            AROrbitM4.Text = "Kilometers : " + request.resultAsteroid.close_approach_data[id].miss_distance.kilometers;
            AROrbitM5.Text = "Miles : " + request.resultAsteroid.close_approach_data[id].miss_distance.miles;
            AROrbitM.Text = "Miss Distance : ";
        }
        public static void getResultAsteroid(){
            ARDescriptionA.Refresh();
            ARDescriptionA.Text = "Description of " + request.resultAsteroid.name.ToString() + " : " + request.resultAsteroid.orbital_data.orbit_class.orbit_class_description.ToString();
            ARNumber.Text = "Number of observation of " + request.resultAsteroid.name.ToString() + " : " + request.resultAsteroid.orbital_data.observations_used.ToString() + " observations you can find them below";
            ARNumber.Text = "Estimated futur observation of " + request.resultAsteroid.name.ToString() + " : " + request.resultAsteroid.orbital_data.orbit_determination_date;
            ARLast.Text = "Last observation of " + request.resultAsteroid.name.ToString() + " : " + request.resultAsteroid.orbital_data.last_observation_date;
            ARFirst.Text = "First observation of " + request.resultAsteroid.name.ToString() + " : " + request.resultAsteroid.orbital_data.first_observation_date;
            AREquinox.Text = "Equinox : " + request.resultAsteroid.orbital_data.equinox.ToString();
            ARUncertain.Text = "Uncertain : " + request.resultAsteroid.orbital_data.orbit_uncertainty.ToString() + "%";
            ARMagnitude.Text = "Magnitude : " + request.resultAsteroid.absolute_magnitude_h.ToString();

            ARkm.CheckedChanged += (sender, e) => {
                estimHmax.Text = "Estimated km/h MAX : " + request.resultAsteroid.estimated_diameter.kilometers.estimated_diameter_max;
                estimHmin.Text = "Estimated km/h MIN : " + request.resultAsteroid.estimated_diameter.kilometers.estimated_diameter_min;
                estimSmax.Text = "Estimated m/s MAX : " + request.resultAsteroid.estimated_diameter.meters.estimated_diameter_max;
                estimSmin.Text = "Estimated m/s MIN : " + request.resultAsteroid.estimated_diameter.meters.estimated_diameter_max;
            };
            if(ARkm.Checked == true ){
                estimHmax.Text = "Estimated km/h MAX : " + request.resultAsteroid.estimated_diameter.kilometers.estimated_diameter_max;
                estimHmin.Text = "Estimated km/h MIN : " + request.resultAsteroid.estimated_diameter.kilometers.estimated_diameter_min;
                estimSmax.Text = "Estimated m/s MAX : " + request.resultAsteroid.estimated_diameter.meters.estimated_diameter_max;
                estimSmin.Text = "Estimated m/s MIN : " + request.resultAsteroid.estimated_diameter.meters.estimated_diameter_max;
            };

            ARml.CheckedChanged += (sender, e) => {
                estimHmax.Text = "Estimated miles/h MAX : " + request.resultAsteroid.estimated_diameter.miles.estimated_diameter_max;
                estimHmin.Text = "Estimated miles/h MIN : " + request.resultAsteroid.estimated_diameter.miles.estimated_diameter_min;
                estimSmax.Text = "Estimated feet/s MAX : " + request.resultAsteroid.estimated_diameter.feet.estimated_diameter_max;
                estimSmin.Text = "Estimated feet/s MIN : " + request.resultAsteroid.estimated_diameter.feet.estimated_diameter_max;
            };

            if(request.resultAsteroid.is_potentially_hazardous_asteroid.ToString() == "True")ARSuspicious.Text = request.resultAsteroid.name.ToString() + " is a potentially hazardous asteroid";
            else ARSuspicious.Text = request.resultAsteroid.name.ToString() + " is not a potentially hazardous asteroid";

            ARNameAsteroide.Text = request.resultAsteroid.name.ToString();
        }
    }
}