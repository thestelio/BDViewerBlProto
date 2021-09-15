using System.Collections.Generic;
using MudBlazor;

namespace BDViewerBlProto.Data.Models
{
    public class ActivateCourse
    {
        private bool CourseFirstLoad = true;

        private readonly HashSet<TreeItemData> _TreeItems = new();

        public ActivateCourse()
        {
            BuildCourseStructure();
        }

        public HashSet<TreeItemData> TreeItems
        {
            get {return _TreeItems; }
            set
            {
                if (CourseFirstLoad)
                {
                    BuildCourseStructure();
                    CourseFirstLoad = false;
                }
                else
                {
                     value.IntersectWith(_TreeItems);
                }
            }
        }

        private void SetInitialCourseConditions()
        {
            int i = 0;

            TopicCount = TreeItems.Count;
            HashSet<TreeItemData>.Enumerator tdENum = TreeItems.GetEnumerator();

            while (tdENum.MoveNext())
            {
                if (tdENum.Current.HasChild)
                {
                    i += tdENum.Current.TreeItems.Count;
                }
            }
            SlideGroupCount = i;
        }

        public int TopicCount { get; set; } = 0;
        public int SlideGroupCount { get; set; } = 0;

        private void BuildCourseStructure()
        {
            TreeItemData TParentNode = new(100, "INTRODUCTION", Icons.TwoTone.LibraryBooks, null);

            TreeItems.Add(new TreeItemData(100, "INTRODUCTION", Icons.TwoTone.LibraryBooks, null)
            {
                TreeItems = new HashSet<TreeItemData>()
                {
                    new TreeItemData(1, "Overview", Icons.TwoTone.MenuBook,TParentNode)
                }
            });
            TParentNode = new TreeItemData(101, "SYSTEM INTRODUCTION", Icons.TwoTone.LibraryBooks, null);
            TreeItems.Add(new TreeItemData(101, "SYSTEM INTRODUCTION", Icons.TwoTone.LibraryBooks, null)
            {
                TreeItems = new HashSet<TreeItemData>()
                {
                    new TreeItemData(2, "Introduction", Icons.TwoTone.MenuBook,TParentNode)
                }
            });
            TParentNode = new TreeItemData(102, "COMPONENT LOCATION AND DESCRIPTION", Icons.TwoTone.LibraryBooks, null);
            TreeItems.Add(new TreeItemData(102, "COMPONENT LOCATION AND DESCRIPTION", Icons.TwoTone.LibraryBooks, null)
            {
                TreeItems = new HashSet<TreeItemData>()
                {
                    new TreeItemData(3,"Hydraulic Control Panel", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(4,"CNI-MU Soft Panel", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(5,"Fire Control Panel", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(6,"Reservoirs", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(7,"Vent Filters", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(8,"Drain Valves", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(9,"Suction Boost Pumps", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(10,"Suction Boost Pumps: Low-Pressure Warning Switches", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(11,"Suction Line Check Valves", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(12,"Suction Boost Pump Control Relays", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(13,"Suction Line SOV", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(14,"Pressure Line SOVs", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(15,"Pressure Relief Valves", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(16,"Pressure Transducers", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(17,"Accumulators and Pressure Gauge", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(18,"Engine Driven Pumps", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(19,"EDP: Mechanical Drive Section", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(20,"EDP: Fluid Displacement Section", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(21,"EDP: Pressure Control Section", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(22,"EDP Low-Pressure Warning Switches", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(23,"EDP Snubber Valves", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(24,"EDP Isolation Check Valves", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(25,"High-Pressure Filters", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(26,"Case Drain Check Valves", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(27,"Return Filters", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(28,"Case Drain Filters", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(29,"Quick-disconnect (QD) Couplings", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(30,"Ground Test QD", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(31,"Ground Test Checkout Valve", Icons.TwoTone.MenuBook,TParentNode)
                }
            });
            TParentNode = new TreeItemData(103, "SYSTEM DESCRIPTION AND OPERATION", Icons.TwoTone.LibraryBooks, null);
            TreeItems.Add(new TreeItemData(103, "SYSTEM DESCRIPTION AND OPERATION", Icons.TwoTone.LibraryBooks, null)
            {
                TreeItems = new HashSet<TreeItemData>()
                {
                    new TreeItemData(32,"Hydraulic Fluid Flow Operation: Part 1", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(33,"Hydraulic Fluid Flow Operation: Part 2", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(34,"Booster and Utility Hydraulic Systems: Part 1", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(35,"Booster and Utility Hydraulic Systems: Part 2", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(36,"Booster and Utility Hydraulic Systems: Part 3", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(37,"Booster and Utility Hydraulic Systems: Part 4", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(38,"Pressure Shutoff Valve and Suction Line Shutoff Valve Operation", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(39,"Normal Operation of Shutoff Valves", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(40,"Emergency Operation of Shutoff Valves", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(41,"Electrical Operation- Booster Suction Boost Pump", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(42,"Electrical Operation - Utility Suction Boost Pump", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(43,"Electrical Operation - Hydraulic Pressure and Suction SOVs Normal", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(44,"Electrical Operation - Hydraulic Pressure and Suction SOVs Isolated", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(45,"Electrical Operation - Hydraulic Pressure and Suction SOVs Fire Handle Pulled", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(46,"Power Distribution - Suction Boost Pumps", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(47,"Pressure Shutoff Valves", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(48,"Pressure Transducers", Icons.TwoTone.MenuBook,TParentNode)
                }
            });
            TParentNode = new TreeItemData(104, "INDICATION", Icons.TwoTone.LibraryBooks, null);
            TreeItems.Add(new TreeItemData(104, "INDICATION", Icons.TwoTone.LibraryBooks, null)
            {
                TreeItems = new HashSet<TreeItemData>()
                {
                    new TreeItemData(49,"Pressure Indication – Pressure Transducers", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(50,"Pressure Indication - Display", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(51,"1553 Data Bus Interface", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(52,"ACAWS", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(53,"Fault Log", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(54,"Maintenance Messages", Icons.TwoTone.MenuBook,TParentNode),
                    new TreeItemData(55,"Any Questions?", Icons.TwoTone.MenuBook,TParentNode)
                }
            });
            SetInitialCourseConditions();
        }
    }
}
