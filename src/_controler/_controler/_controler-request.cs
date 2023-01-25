using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
namespace config{
    static class request{
        public static JsonNode result;
        public static TextBox startDateT = new TextBox();
        public static TextBox endDateT = new TextBox();
        public static ProgressBar loading = new ProgressBar();
        public static ListBox list = new ListBox();
        public static string _reference;
        //send request to api & get response + update loading bar
        public static void search(string url, string startDate = "", string endDate = ""){
            loading.Value = 0;
            
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage{
                Method = HttpMethod.Get,
                RequestUri = new Uri(url + conf.apiKey + "&start_date=" + startDate + "&end_date=" + endDate),
            };
            loading.Value = 10;
            
            var response = client.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            
            loading.Value = 20;
            
            if (responseInfo.StatusCode == HttpStatusCode.OK){
                var read = new StreamReader(responseInfo.Content.ReadAsStreamAsync().Result);
                var Json = read.ReadToEnd();
                
                loading.Value = 40;
                
                try{
                    JsonNode forecastNode = JsonNode.Parse(Json)!;
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    JsonNode resp = forecastNode;

                    if (_reference == "date"){
                        resp = forecastNode!["date"]!; 
                    }else if(_reference == "links"){
                        resp = forecastNode!["links"]!; 
                    }
                    
                    Console.WriteLine(resp.ToJsonString());
                    result = forecastNode;
                    loading.Value = 60;
                }catch{
                    Json = Json.Remove(0, 1);
                    Json = Json.Remove(Json.Length-1 -1, 1); 
                    JsonNode forecastNode = JsonNode.Parse(Json)!;
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    result = forecastNode;
                    
                    loading.Value = 80;
                
                }
                
                loading.Value = 100;
            }else{
                loading.Value = 0;
                MessageBox.Show("Error bad request");
            }
        }
        public static void addList(){
            JsonNode date = result!["page"]!;
            MessageBox.Show(date.ToJsonString());
        }
        public static void requestAsteroid(){
            if (startDateT.Text == "" || endDateT.Text == ""){
                _reference = "links";
                search("https://api.nasa.gov/neo/rest/v1/feed?api_key=");
                JsonNode date = request.result!["element_count"]!;
                MessageBox.Show(date.ToJsonString());
                JsonNode a = request.result!["near_earth_objects"]["2023-01-30"]!;
                MessageBox.Show(a.ToJsonString());
                //addList();
                return;
            }else{
                _reference = "links";
                search("https://api.nasa.gov/neo/rest/v1/feed?api_key=", startDateT.Text, endDateT.Text);
                JsonNode date = request.result!["links"]!;
                MessageBox.Show(date.ToJsonString());
                //addList();
                return;
            }
        }
    }
}