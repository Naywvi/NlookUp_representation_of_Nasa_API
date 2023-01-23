// using System.Net;
// using mApiKey;
// namespace cApi{
//     public class cApiMethods : mApi{
//         public void verifyApiKey(){
//             try{
//                 HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.nasa.gov/planetary/apod?api_key=" + this.inputApiKeyTxt.Text);
//                 HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
//                 if (myHttpWebResponse.StatusCode == HttpStatusCode.OK);MessageBox.Show("ok");
//             }catch(WebException){
//                 MessageBox.Show("no");
//             }
//         }
//     }
// }