using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Json_Blueprint.Classes
{
    class ControlManager
    {
        // Creates a layout and fills it with controls
        public static FlowLayoutPanel CreateLayout(FlowLayoutPanel flowLayout, FlowDirection flowDir, List<Control> cList)
        {
            flowLayout.FlowDirection = flowDir;
            flowLayout.Size = new System.Drawing.Size(700, 100);
            FillLayout(flowLayout, cList);
            return flowLayout;
        }

        // Overload
        public static void CreateLayout(Panel panel, DockStyle dock, FlowDirection flowDir)
        {
            panel.AutoScroll = true;
            panel.Dock = dock;
        }   

        private static void FillLayout(FlowLayoutPanel flowLayout, List<Control> cList)
        {
            for (int i = 0; i < cList.Count; i++)
            {
                flowLayout.Controls.Add(cList[i]);
            }
        }
    }
}
