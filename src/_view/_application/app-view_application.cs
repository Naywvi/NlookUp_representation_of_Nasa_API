/********************************************************************************************
* Here we will find the launch of the application allowing the management and visualization *
* of the information received from the NASA API                                             *
*********************************************************************************************/
using mApod;
using mAsteroid;
using mapodResult;
using masteroidResult;
namespace application{
    public partial class appnn : Form{
        private initApodMethod mapod = new initApodMethod();
        private initAsteroidMethod masteroid = new initAsteroidMethod();
        private initApodRMehods mApodR = new initApodRMehods();
        private initAsteroidRMethods mAsteroidR = new initAsteroidRMethods();
        public void load(){
            Tabs();
            foreach(System.Windows.Forms.Control? method in masteroid.initAsteroid())pAsteroid.Controls.Add(method);
            foreach(System.Windows.Forms.Control? method in mapod.initApod())pApod.Controls.Add(method); 
            
            dynamicTabControl.TabPages.Add(pAsteroid); //<-- Asteroid if result exist
            dynamicTabControl.TabPages.Add(pApod);
            Controls.Add(dynamicTabControl);
        }
    }
}