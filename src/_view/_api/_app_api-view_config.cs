/**************************************************************************************************************
* Here we will find the heart of the launch of the application allowing the verification of the NASA API code *
***************************************************************************************************************/
namespace vApi{
    public partial class api : Form{
        public api(){
            InitializeComponent();
        }
        public void viewLoad(){
            vApiAsync();
        }
    }
}