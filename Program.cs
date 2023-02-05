/**************************************************************************************************
* Here we will find the launch of the application redirecting to the verification of the API code *
**************************************************************************************************/
using vApi;
namespace view{
    static class Program{
        [STAThread]
        static void Main(){
            ApplicationConfiguration.Initialize();
            Application.Run(new api());
        }
    }
}