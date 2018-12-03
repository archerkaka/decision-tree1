using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionTreeSimulation
{
    class DoubleBufferedPanel:Panel
    {
        public DoubleBufferedPanel()
            : base()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.Opaque |
                          ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
