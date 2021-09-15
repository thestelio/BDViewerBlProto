using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDViewerBlProto.Data.Models
{
    public class TreeItemData
    {
        public int OrderID { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }

        public TreeItemData ParentNode { get; set; }

        public bool IsExpanded { get; set; } = true;

        public bool HasChild => TreeItems != null && TreeItems.Count > 0;

        public HashSet<TreeItemData> TreeItems { get; set; } = new HashSet<TreeItemData>();

        public TreeItemData(int orderid, string title, string icon, TreeItemData parentnode)
        {
            OrderID = orderid;
            Title = title;
            Icon = icon;
            ParentNode = parentnode;
        }
    }
}
