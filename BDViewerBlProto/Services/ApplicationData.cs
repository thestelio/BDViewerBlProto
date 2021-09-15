using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDViewerBlProto.Services
{
    public class ApplicationData
    {
        private string _Role = "Instructor";
        public string Role
        {
            get { return _Role; }
            set { _Role = value; NotifyDataChange(); }
        }

        private string _TrainingScope = "Technical Training Flight";
        public string TrainingScope
        {
            get { return _TrainingScope; }
            set
            {
                _TrainingScope = value;

                if (_TrainingScope == "Technical Training Flight")
                    TrainingScopeImage = "/Images/Logos/TTF2.png";
                else if(_TrainingScope == "Pilot Training")
                    TrainingScopeImage = "/Images/Logos/Pilot2.png";
                else if (_TrainingScope == "Loadmaster Training")
                    TrainingScopeImage = "/Images/Logos/Loadmaster2.png";
                else
                    TrainingScopeImage = "/Images/Logos/Learninglogics.png";

                NotifyDataChange();
            }
        }
   
        public string TrainingScopeImage { get; set; } = "/Images/Logos/TTF.png";

        private bool _WindowZero = true;
        public bool WindowZero
        {
            get { return _WindowZero; }
            set { _WindowZero = value; NotifyDataChange(); }
        }

        private bool _WindowSlide = false;
        public bool WindowSlide
        {
            get { return _WindowSlide; }
            set { _WindowSlide=value; NotifyDataChange(); }
        }

        public string SelectedWindow()
        {
            string strWindow = "";

            if (WindowZero) { strWindow = "Window Zero"; }
            if (WindowSlide)
            {
                strWindow += (!WindowZero) ? "Window Slide" : " and Window Slide";
            }
            return strWindow;
        }

        public void UpdateAppState()
        {
            NotifyDataChange();
        }

        public event Action StateChanged;

        private void NotifyDataChange() => StateChanged?.Invoke();
    }
}
