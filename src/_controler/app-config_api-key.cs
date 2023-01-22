using System.Net;
namespace cApi{
    class cApiMethods{
        public void verifyApiKey(string apiKey){
            var req = WebRequest.Create("https://api.nasa.gov/planetary/apod?api_key="+apiKey);
            req.Method = "GET";
            var webResponse = req.GetResponse();
            MessageBox.Show("ok");
            // if (myHttpWebResponse.StatusCode == HttpStatusCode.OK){
            //     return true;
            // }else{
            //     return false;
            // }
        }
    }
}