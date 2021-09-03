using SIMS2021.UI.Components.Toolbar.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS021
{
    public class MainWindowViewModel
    {
        private ToolbarViewModel toolbarViewModel;

        public ToolbarViewModel ToolbarViewModel
        {
            get { return toolbarViewModel; }
            set { toolbarViewModel = value; }
        }
    }
}
