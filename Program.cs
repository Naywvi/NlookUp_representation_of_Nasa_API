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