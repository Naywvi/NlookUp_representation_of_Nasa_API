namespace mTab{
    // Tabs _model
    public class tab{
        public TabControl generateTabControl(){
            TabControl dynamicTabControl = new TabControl();  
            dynamicTabControl.Name = "DynamicTabControl";  
            dynamicTabControl.BackColor = Color.White;  
            dynamicTabControl.ForeColor = Color.Black;  
            dynamicTabControl.Font = new Font("Georgia", 10);  
            dynamicTabControl.Width = 1000;  
            dynamicTabControl.Height = 700;  
            return dynamicTabControl;
        }
        public TabPage generateTabPIndex(){
            TabPage tabPage1 = new TabPage();  
            tabPage1.Name = "tabPage2";  
            tabPage1.Text = "Search";  
            tabPage1.BackColor = Color.FromArgb(224, 224, 224);
            tabPage1.ForeColor = Color.Black;  
            tabPage1.Font = new Font("Verdana", 9);  
            tabPage1.Width = 100;  
            tabPage1.Height = 100;  
            return tabPage1;
        }
        public TabPage generateTabPApod(){
            TabPage tabPage2 = new TabPage();  
            tabPage2.Name = "tabPage2";  
            tabPage2.Text = "Apod - Astronomy Picture of the Day";  
            tabPage2.BackColor = Color.FromArgb(224, 224, 224);
            tabPage2.ForeColor = Color.Black;    
            tabPage2.Font = new Font("Verdana", 9);  
            tabPage2.Width = 100;  
            tabPage2.Height = 100;  
            return tabPage2;
        }
        public TabPage generateTabPAsteroid(){
            TabPage tabPage3 = new TabPage();  
            tabPage3.Name = "tabPage2";  
            tabPage3.Text = "Result";  
            tabPage3.BackColor = Color.FromArgb(224, 224, 224); 
            tabPage3.ForeColor = Color.Black;    
            tabPage3.Font = new Font("Verdana", 9);  
            tabPage3.Width = 100;  
            tabPage3.Height = 100;
            tabPage3.AutoScroll = true;
            return tabPage3;
        }
    }
}