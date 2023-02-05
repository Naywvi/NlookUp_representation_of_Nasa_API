/*************************************************************************************************************************
* Here we will find all the properties containing the visual of the result of the search for apod (a picture of the day) *
**************************************************************************************************************************/
using config;
namespace mapodResult{
    class initApodRMehods{
        private presentationRApod pApodR = new presentationRApod();
        private superfluApodR sApodR = new superfluApodR();
        private imgApodR iApodR = new imgApodR();
        public List<System.Windows.Forms.Control?> initApodR(){
            var list = new List<System.Windows.Forms.Control?>();
            list.Add(pApodR.generateTitle());
            list.Add(iApodR.generateImage());

            list.Add(pApodR.generateExplanation());

            list.Add(sApodR.generateCopyright());
            list.Add(iApodR.Download1024());
            list.Add(iApodR.Download2048());
            return list;
        }
    }
    public class presentationRApod{
        public Label generateTitle(){
            func.apodPresentation.Location = new Point(10, 10);
            func.apodPresentation.Font = new Font("Arial", 13, FontStyle.Bold);
            func.apodPresentation.Size = new Size(950, 50);
            func.apodPresentation.TextAlign = ContentAlignment.MiddleCenter;
            func.apodPresentation.BorderStyle = BorderStyle.Fixed3D;
            return func.apodPresentation;
        }
        public Label generateExplanation(){
            func.title.Location = new Point(10, 730);
            func.title.Font = new Font("Arial", 10, FontStyle.Bold);
            func.title.Size = new Size(950, 50);
            func.title.TextAlign = ContentAlignment.MiddleCenter;
            func.title.BorderStyle = BorderStyle.Fixed3D;
            return func.title;
        }
    }
    public class superfluApodR{
        public Label generateCopyright(){
            func.copyright.Location = new Point(10, 790);
            func.copyright.Font = new Font("Arial", 10, FontStyle.Bold);
            func.copyright.Size = new Size(950, 50);
            return func.copyright;
        }
    }
    public class imgApodR{
        public PictureBox generateImage(){
            func.img.Location = new Point(10, 70);
            func.img.Size = new Size(950, 650);
            return func.img;
        }
        public LinkLabel Download1024(){
            func.Dl1024.Text = "Download 1024x1024";
            func.Dl1024.Location = new Point(10, 820);
            func.Dl1024.Size = new Size(950, 50);
            func.Dl1024.TextAlign = ContentAlignment.MiddleLeft;
            return func.Dl1024;
        }
        public LinkLabel Download2048(){
            func.Dl2048.Text = "Download 2048x2048";
            func.Dl2048.Location = new Point(10, 840);
            func.Dl2048.Size = new Size(950, 80);
            func.Dl2048.TextAlign = ContentAlignment.MiddleLeft;
            return func.Dl2048;
        }
    }
}