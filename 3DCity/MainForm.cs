using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ingeo;
using GraphicEngine;

namespace LandScape3D
{
    public partial class MainForm : Form
    {
        private IIngeoApplication _Application;
        private ViewTableForm _viewTableForm;

        public MainForm(IIngeoApplication ingeo)
        {
            InitializeComponent();
            _Application = ingeo;

            InitializeTreeViewDb();
        }

        public void InitializeTreeViewDb()
        {
            TreeNode aActiveDbTreeNode = treeViewDataBase.Nodes.Add("ActiveDb", "ActiveDb");

            foreach (IIngeoArea area in _Application.ActiveDb.Areas)
            {
                TreeNode aAreaTreeNode = aActiveDbTreeNode.Nodes.Add("Area", area.Name);

                foreach (IIngeoMap map in area.Maps)
                {
                    TreeNode aMapTreeNode = aAreaTreeNode.Nodes.Add("Map", map.Name);

                    if (map is IIngeoVectorMap)
                    {

                        foreach (IIngeoLayer layer in (map as IIngeoVectorMap).Layers)
                        {
                            TreeNode aLayerTreeNode = aMapTreeNode.Nodes.Add("Layer", layer.Name);



                        }
                    }

                }


            }
            

        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _viewTableForm = new ViewTableForm();

            _viewTableForm.ShowDialog();
        }
    }
}
