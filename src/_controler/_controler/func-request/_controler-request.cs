/*****************************************************************************************************************************
* Here we will find the functions that allow us to send requests to the nasa api once the validation of the api code is done *
*****************************************************************************************************************************/
using System.Net;
using Newtonsoft.Json;
namespace config{
    static class request{

        public static TextBox startDateT = new TextBox();
        public static TextBox endDateT = new TextBox();
        public static TextBox startDateTA = new TextBox();
        public static TextBox endDateTA = new TextBox();
        public static ProgressBar loading = new ProgressBar();
        public static ProgressBar loading2 = new ProgressBar();

        //send request to api & get response + update loading bar
        public static void load(int loader, string reset = ""){
            if(loader == 0){
                if (reset == "reset")loading.Value = 0;
                else loading.Value += 20;
            }else if (loader == 1){
                if (reset == "reset")loading2.Value = 0;
                else loading2.Value += 20;
            }
        }
        public static bool search(int loader,string url, string startDate = "", string endDate = ""){
            load(loader,"reset");
            load(loader);

            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage{
                Method = HttpMethod.Get,
                RequestUri = new Uri(url + conf.apiKey + "&start_date=" + startDate + "&end_date=" + endDate),
            };
            load(loader);
            
            var response = client.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            
            load(loader);
            try{
                if (responseInfo.StatusCode == HttpStatusCode.OK){
                var read = new StreamReader(responseInfo.Content.ReadAsStreamAsync().Result);
                
                load(loader);
                if(url == "https://api.nasa.gov/neo/rest/v1/feed?api_key="){
                    conf.result = JsonConvert.DeserializeObject(read.ReadToEnd());
                }else if (url == "https://api.nasa.gov/planetary/apod?api_key="){
                    conf.result2 = JsonConvert.DeserializeObject(read.ReadToEnd());
                }

                load(loader);
                
                return true;
                }else{
                    load(loader,"reset");
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
                if(search(0,url))func.addListAsteroid();
            }else{
                if(search(0,url, startDateT.Text, endDateT.Text))func.addListAsteroid();
            }
        }

        public static void requestApodList(){
            var url = "https://api.nasa.gov/planetary/apod?api_key=";
            if (startDateTA.Text == "" || endDateTA.Text == ""){
                if(search(1,url)) func.addListApodToday();
                
            }else{
                if(search(1,url, startDateTA.Text, endDateTA.Text))func.addListApod();
            }
        }
    }
}
