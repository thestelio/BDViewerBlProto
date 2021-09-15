using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MudBlazor;

namespace BDViewerBlProto.Services
{
 

    public class CourseData
    {

        private string _CourseTitle =  "C-130J Electrical Systems Course - 201343";
        public string CourseTitle 
        { 
            get { return _CourseTitle; } 
            set { _CourseTitle = value; NotifyDataChange(); }
        }

        private string _CourseModule = "Phase 5 - Hydraulics, Landing Gear and Braking Systems";
        public string CourseModule 
        { 
            get { return _CourseModule; } 
            set { _CourseModule = value; NotifyDataChange(); }
        }

        private string _CourseLearningObjective = "Booster and Utility Hydraulic Systems";
        public string CourseLearningObjective 
        { 
            get { return _CourseLearningObjective; }
            set { _CourseLearningObjective = value; NotifyDataChange(); }
        }

        private string _CourseTopic = "Course Topic";
        public string CourseTopic
        {
            get { return _CourseTopic; }
            set { _CourseTopic = value; NotifyDataChange(); }
        }

        private string _CourseGroup = "Course Slide Group";
        public string CourseGroup
        {
            get { return _CourseGroup; }
            set { _CourseGroup = value; NotifyDataChange(); }
        }

        private int _TopicCount = 0;
        public int TopicCount 
        {
            get { return _TopicCount; }
            set { _TopicCount = value; NotifyDataChange(); }
        }

        private int _TopicChildCount = 0;
        public int TopicChildCount 
        {
            get { return _TopicChildCount; } 
            set { _TopicChildCount = value; NotifyDataChange(); }
        }

        private int _ActiveSlideGroup = 1;
        public int ActiveSlideGroup 
        { 
            get { return _ActiveSlideGroup; }
            set { _ActiveSlideGroup = value; NotifyDataChange(); }
        }

        public event Action StateChanged;

        private void NotifyDataChange() => StateChanged?.Invoke();

    }

}