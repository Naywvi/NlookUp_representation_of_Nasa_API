namespace view{
    public partial class app : Form{
        
        public app(){
            InitializeComponent();
        }
        private void viewLoad(string view){
            
            switch (view){
                case "api":
                this.ClientSize = new System.Drawing.Size(500,200);
                    this.vApiAsync();
                    return;
                case "asteroid":
                    this.vAsteroidAsync();
                    break;
                case "apod":
                    this.vApodAsync();
                    break;
                case "result-asteroid":
                    this.vAsteroidResultAsync();
                    break;
                case "result-apod":
                    this.vApodResult();
                    break;
            }
        }
    }
}