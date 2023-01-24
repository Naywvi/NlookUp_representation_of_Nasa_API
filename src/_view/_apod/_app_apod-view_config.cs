namespace vApod{
    public partial class apod : Form{
        public apod(){
            InitializeComponent();
        }
        public void viewLoad(){
            this.vApodAsync();
        }
    }
}