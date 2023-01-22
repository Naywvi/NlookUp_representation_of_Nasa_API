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
            ProgressBar loading = new ProgressBar();
            loading.Location = new Point(10, 630);
            loading.Width = 970;
            loading.Minimum = 0;
            loading.Maximum = 100;
            loading.Value = 40;
            return loading;
        }
    }
    // List of results asteroid _model
    public class list{
        public ListBox generatedList(){
            ListBox list = new ListBox();
            list.Location = new Point(10 , 180);
            list.Size = new Size(10,440);
            list.Width = 970;
            list.BorderStyle = BorderStyle.Fixed3D;
            //generateItem(); //<---- depuis l'api
            list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");list.Items.Add("GeeksForGeeks");
            return list;
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
            return btnSubmit;
        }
        public TextBox filtersCustomEndDate(){
            TextBox endDateT = new TextBox();
            endDateT.Location = new Point(670,126);
            endDateT.PlaceholderText = "YYYY-MM-DD";
            endDateT.Width = 130;
            return endDateT;
        }
        public Label filtersCustomLabelEndDate(){
            Label endDateL = new Label();
            endDateL.Location = new Point(580,130);
            endDateL.Text = "End date: ";
            endDateL.Size = new Size(80,20);
            return endDateL;
        }
         public TextBox filtersCustomStartDate(){
            TextBox startDateT = new TextBox();
            startDateT.Location = new Point(430,127);
            startDateT.PlaceholderText = "YYYY-MM-DD";
            startDateT.Width = 130;
            return startDateT;
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
            return selectionCustom;
        }
        public RadioButton filtersSelectionDefault(){
            RadioButton selectionDefault = new RadioButton();
            selectionDefault.Location = new Point(100,127);
            selectionDefault.Text = "default";
            selectionDefault.Checked = true;
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