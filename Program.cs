namespace nlook_up{

    static class Program{
        [STAThread]
        static void Main(){
            ApplicationConfiguration.Initialize();
            Application.Run(new app());
        }    
        
    }   
}

