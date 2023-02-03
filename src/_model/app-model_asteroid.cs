using config;
namespace mAsteroid{
    // Callback of asteroid _model methods
    public class initAsteroidMethod{
        //<< asteroid callbacks
        private filters asteroidFilters = new filters();
        private presentation asteroidPresentation = new presentation();
        private list asteroidList = new list();
        private loading asteroidLoading = new loading();

        //List all methods to init asteroid view
        public List<Control?> initAsteroid(){
            List<System.Windows.Forms.Control?> list = new List<System.Windows.Forms.Control?>();
            list.Add(this.asteroidPresentation.generatePresentation());
            list.Add(this.asteroidFilters.filtersTitle());
            list.Add(this.asteroidFilters.filtersSelectionDefault());
            list.Add(this.asteroidFilters.filtersSelectionCustom());
            list.Add(this.asteroidFilters.filtersBorders());
            list.Add(this.asteroidFilters.filtersCustomLabelStartDate());
            list.Add(this.asteroidFilters.filtersCustomStartDate());
            list.Add(this.asteroidFilters.filtersCustomLabelEndDate());
            list.Add(this.asteroidFilters.filtersCustomEndDate());
            list.Add(this.asteroidFilters.filtersButton());
            list.Add(this.asteroidFilters.filtersCustomBorders());
            list.Add(this.asteroidList.generatedList());
            list.Add(this.asteroidLoading.generateLoading());
            return list;
        }

    }
    // Loading asteroid _model
    public class loading{
        public ProgressBar generateLoading(){
            request.loading.Location = new Point(10, 630);
            request.loading.Width = 970;
            request.loading.Minimum = 0;
            request.loading.Maximum = 100;
            request.loading.Value = 0;
            return request.loading;
        }
    }
    // List of results asteroid _model
    public class list{
        public ListBox generatedList(){
            func.list.Location = new Point(10 , 180);
            func.list.Size = new Size(10,440);
            func.list.Width = 970;
            func.list.BorderStyle = BorderStyle.Fixed3D;
            func.list.MouseDoubleClick += (sender, e) => {
                if (func.list.SelectedItem != null){
                    application.appnn app = (application.appnn)Application.OpenForms[0];
                    var id = func.list.SelectedItem.ToString().Split(' ');
                    app.tabRequest("asteroid",id[2]);
                    func.addListAsteroidOrbit();
                    func.getResultAsteroid();
                }
            };
            return func.list;
        }
    }

    // Presentation asteroid _model
    public class presentation{
        private string headerPresentation = "Welcome to nlook up, this tool will allow you to see the stars. You will see in real time, or almost what you do not know. The goal was to retrieve NASA information made available to the general public. You will be able to list the asteroids that had a short distance between itself and the planet earth. You will also have the possibility of viewing their trajectories. Whether it's 1 year ago or yesterday you will have the opportunity to review what happened. A POAD is published every day, do not hesitate to watch it, or even download it.";
        
        public Label generatePresentation(){
            Label presentation = new Label();
            presentation.Text = this.headerPresentation;
            presentation.Location = new Point(10, 10);
            presentation.Size = new Size(10, 100);
            presentation.Width = 970;
            presentation.TextAlign = ContentAlignment.MiddleCenter;
            presentation.BorderStyle = BorderStyle.Fixed3D;
            return presentation;
        }
    }

    // Filters asteroid _model
    public class filters{
        public Button filtersButton(){
            Button btnSubmit = new Button();
            btnSubmit.Location = new Point(810,124);
            btnSubmit.Text = "Submit";
            btnSubmit.Size = new Size(160,30);
            // Check if the dates are valid
            btnSubmit.Click += new EventHandler((sender, e) => {
                request.requestAsteroidList();
            });
            return btnSubmit;
        }
        public TextBox filtersCustomEndDate(){
            request.endDateT.Location = new Point(670,126);
            request.endDateT.PlaceholderText = "YYYY-MM-DD";
            request.endDateT.Width = 130;
            request.endDateT.Enabled = false;
            return request.endDateT;
        }
        public Label filtersCustomLabelEndDate(){
            Label endDateL = new Label();
            endDateL.Location = new Point(580,130);
            endDateL.Text = "End date: ";
            endDateL.Size = new Size(80,20);
            return endDateL;
        }
         public TextBox filtersCustomStartDate(){
            request.startDateT.Location = new Point(430,127);
            request.startDateT.PlaceholderText = "YYYY-MM-DD";
            request.startDateT.Width = 130;
            request.startDateT.Enabled = false;
            return request.startDateT;
        }
        public Label filtersCustomLabelStartDate(){
            Label startDateL = new Label();
            startDateL.Location = new Point(330,130);
            startDateL.Text = "Start date: ";
            return startDateL;
        }
        public Label filtersCustomBorders(){
            Label bordersCFilters = new Label();
            bordersCFilters.Location = new Point(325,120);
            bordersCFilters.Size = new Size(40,40);
            bordersCFilters.Width = 655;
            bordersCFilters.BorderStyle = BorderStyle.Fixed3D;
            return bordersCFilters;
        }
        public RadioButton filtersSelectionCustom(){
            RadioButton selectionCustom = new RadioButton();
            selectionCustom.Location = new Point(205,127);
            selectionCustom.Text = "Custom";
            selectionCustom.CheckedChanged += (sender, e) => {
                if(selectionCustom.Checked){
                    request.startDateT.Enabled = true;
                    request.endDateT.Enabled = true;
                }
            };
            return selectionCustom;
        }
        public RadioButton filtersSelectionDefault(){
            RadioButton selectionDefault = new RadioButton();
            selectionDefault.Location = new Point(100,127);
            selectionDefault.Text = "default";
            selectionDefault.Checked = true;
            selectionDefault.CheckedChanged += (sender, e) => {
                if(selectionDefault.Checked){
                    request.startDateT.Enabled = false;
                    request.endDateT.Enabled = false;
                    request.startDateT.Text = "";
                    request.endDateT.Text = "";
                }
            };
            return selectionDefault;
        }
        public Label filtersTitle(){
            Label filters = new Label();
            filters.Location = new Point(15,130);
            filters.Size = new Size(60,20);
            filters.Text = "Filters:";
            return filters;
        }
        public Label filtersBorders(){
            Label borders = new Label();
            borders.BorderStyle = BorderStyle.Fixed3D;
            borders.Location = new Point(10 , 120);
            borders.Size = new Size(40,40);
            borders.Width = 300;
            return borders;
        }
    }
}