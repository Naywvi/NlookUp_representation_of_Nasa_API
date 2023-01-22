using System;
using System.Net;
using System.IO;
namespace apodResult{
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
        private string titleApod = "Astronomy Picture of the Day - [date]"; // [date] = date of the picture + title
        public Label generateTitle(){
            var apodPresentation = new Label();
            apodPresentation.Location = new Point(10, 10);
            apodPresentation.Text = this.titleApod;
            apodPresentation.Font = new Font("Arial", 13, FontStyle.Bold);
            apodPresentation.Size = new Size(950, 50);
            apodPresentation.TextAlign = ContentAlignment.MiddleCenter;
            apodPresentation.BorderStyle = BorderStyle.Fixed3D;
            return apodPresentation;
        }
        public Label generateExplanation(){
            var title = new Label();
            title.Location = new Point(10, 730);
            title.Text = "Explanation";
            title.Font = new Font("Arial", 10, FontStyle.Bold);
            title.Size = new Size(950, 50);
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.BorderStyle = BorderStyle.Fixed3D;
            return title;
        }
    }
    public class superfluApodR{
        public Label generateCopyright(){
            var copyright = new Label();
            copyright.Location = new Point(10, 790);
            copyright.Text = "© 2021 NASA/JPL-Caltech/MSSS";//exemple copyright
            copyright.Font = new Font("Arial", 10, FontStyle.Bold);
            copyright.Size = new Size(950, 50);
            return copyright;
        }
    }
    public class imgApodR{
        public PictureBox generateImage(){
            var img = new PictureBox();
            img.Location = new Point(10, 70);
            img.Size = new Size(950, 650);
            img.LoadAsync("https://apod.nasa.gov/apod/image/2301/AUFSCHNAITER_Andreas_APOD_Bode_Cigare1024.jpg");//Image
            return img;
        }
        public LinkLabel Download1024(){
            var Dl1024 = new LinkLabel();
            Dl1024.Text = "Download 1024x1024";
            Dl1024.Location = new Point(10, 820);
            Dl1024.Size = new Size(950, 50);
            Dl1024.TextAlign = ContentAlignment.MiddleLeft;
            Dl1024.LinkClicked += new LinkLabelLinkClickedEventHandler((sender, e) => {
                WebClient client = new WebClient();
                client.DownloadFileAsync(new Uri("https://apod.nasa.gov/apod/image/2301/AUFSCHNAITER_Andreas_APOD_Bode_Cigare1024.jpg"), "date-name_1024.jpg");
            });
            return Dl1024;
        }
        public LinkLabel Download2048(){
            var Dl2048 = new LinkLabel();
            Dl2048.Text = "Download 2048x2048";
            Dl2048.Location = new Point(10, 840);
            Dl2048.Size = new Size(950, 80);
            Dl2048.TextAlign = ContentAlignment.MiddleLeft;
            Dl2048.LinkClicked += new LinkLabelLinkClickedEventHandler((sender, e) => {
                WebClient client = new WebClient();
                client.DownloadFileAsync(new Uri("https://apod.nasa.gov/apod/image/2301/AUFSCHNAITER_Andreas_APOD_Bode_Cigare2048.jpg"), "date-name_2048.jpg");
            });
            return Dl2048;
        }
    }
}