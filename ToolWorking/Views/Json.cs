using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolWorking.Model;
using ToolWorking.Utils;

namespace ToolWorking.Views
{
    public partial class Json : Form
    {
        // Path folder
        string pathFolderCreateFile;
        string fileNameCreate;
        int fileType;
        // List column in script table
        private List<ColumnModel> lstSetting = new List<ColumnModel>();
        BindingSource bindingSource = new BindingSource();

        public Json()
        {
            InitializeComponent();
        }




    }
}