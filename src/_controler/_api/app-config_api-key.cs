/******************************************************************************
* Here we will find the functions affecting the application itself.           *
* In the field of API code verification. We will have the config of           *
* the window in question as well as its function allowing the verification    *
******************************************************************************/
using application;
using config;
namespace vApi{
    partial class api{
        private int _height = 500;
        public int height{
            get => _height;
        }
        private int _width = 200;
        public int width{
            get => _width;
        }
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing){
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void InitializeComponent(){
            components = new System.ComponentModel.Container();
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(height, width);

            //<< Disable resizing
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            MaximizeBox = false;

            Text = "nlook up";
            viewLoad();
            
        }
        // Hide api & show application after verify api key
        public void apikeyValid(string apiKey){ 
            conf.apiKey = apiKey;
            vApi.api FormThread = (vApi.api)Application.OpenForms[0];
            FormThread.Hide();
            var app = new appnn();
            app.Show();
        }
    }
}