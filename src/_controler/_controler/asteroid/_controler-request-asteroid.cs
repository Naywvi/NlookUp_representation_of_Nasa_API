using System.Net;
using Newtonsoft.Json;

namespace config{
    static class request{

        public static TextBox startDateT = new TextBox();
        public static TextBox endDateT = new TextBox();
        public static ProgressBar loading = new ProgressBar();

        //send request to api & get response + update loading bar
        public static bool search(string url, string startDate = "", string endDate = ""){
            loading.Value = 0;
            loading.Value += 20;
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage{
                Method = HttpMethod.Get,
                RequestUri = new Uri(url + conf.apiKey + "&start_date=" + startDate + "&end_date=" + endDate),
            };
            loading.Value += 20;
            
            var response = client.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            
            loading.Value += 20;

            try{
                if (responseInfo.StatusCode == HttpStatusCode.OK){
                var read = new StreamReader(responseInfo.Content.ReadAsStreamAsync().Result);
                
                loading.Value += 20;
                if(url == "https://api.nasa.gov/neo/rest/v1/feed?api_key="){
                    conf.result = JsonConvert.DeserializeObject(read.ReadToEnd());
                }else if (url == "https://api.nasa.gov/planetary/apod?api_key="){
                    conf.result2 = JsonConvert.DeserializeObject(read.ReadToEnd());
                }

                loading.Value += 20;
                
                return true;
                }else{
                    loading.Value = 0;
                    MessageBox.Show("Error bad request");
                    return false;
                }
            }catch{
                MessageBox.Show("Error bad request");
                return false;
            }
        }
        public static async Task<Task> loadAsteroidRequest(string id){
            var taskCompletionSource = new TaskCompletionSource();
            HttpClient client = new HttpClient();

            var request = new HttpRequestMessage{
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.nasa.gov/neo/rest/v1/neo/" + id + "?api_key=" + conf.apiKey),
            };

            var response = client.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            
            var read = new StreamReader(responseInfo.Content.ReadAsStreamAsync().Result);
            
            conf.resultAsteroid = JsonConvert.DeserializeObject(read.ReadToEnd());
            
            return taskCompletionSource.Task;
        }
        
        public static void requestAsteroidList(){
            var url = "https://api.nasa.gov/neo/rest/v1/feed?api_key=";
            if (startDateT.Text == "" || endDateT.Text == ""){
                if(search(url))func.addListAsteroid();
            }else{
                if(search(url, startDateT.Text, endDateT.Text))func.addListAsteroid();
            }
        }
        public static void requestApodList(){
            var url = "https://api.nasa.gov/planetary/apod?api_key=";
            if (startDateT.Text == "" || endDateT.Text == ""){
                if(search(url))func.addListAsteroid();
            }else{
                if(search(url, startDateT.Text, endDateT.Text))func.addListAsteroid();
            }
        }
    }
}
