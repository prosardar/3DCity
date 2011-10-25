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
<<<<<<< HEAD
            TreeNode aActiveDbTreeNode = treeViewDataBase.Nodes.Add("ActiveDb", _Application.ActiveDb.Caption);

            aActiveDbTreeNode.ImageIndex = 0;
            aActiveDbTreeNode.SelectedImageIndex = 0;
=======
            TreeNode aActiveDbTreeNode = treeViewDataBase.Nodes.Add("ActiveDb", "ActiveDb");
>>>>>>> ef18f144040be708478faf6dde1bfa7d1ed2d067

            foreach (IIngeoArea area in _Application.ActiveDb.Areas)
            {
                TreeNode aAreaTreeNode = aActiveDbTreeNode.Nodes.Add("Area", area.Name);

<<<<<<< HEAD
                aAreaTreeNode.ImageIndex = 1;
                aAreaTreeNode.SelectedImageIndex = 1;

=======
>>>>>>> ef18f144040be708478faf6dde1bfa7d1ed2d067
                foreach (IIngeoMap map in area.Maps)
                {
                    TreeNode aMapTreeNode = aAreaTreeNode.Nodes.Add("Map", map.Name);

                    if (map is IIngeoVectorMap)
                    {

<<<<<<< HEAD
                        aMapTreeNode.ImageIndex = 3;
                        aMapTreeNode.SelectedImageIndex = 3;

=======
>>>>>>> ef18f144040be708478faf6dde1bfa7d1ed2d067
                        foreach (IIngeoLayer layer in (map as IIngeoVectorMap).Layers)
                        {
                            TreeNode aLayerTreeNode = aMapTreeNode.Nodes.Add("Layer", layer.Name);

<<<<<<< HEAD
                            aLayerTreeNode.ImageIndex = 4;
                            aLayerTreeNode.SelectedImageIndex = 4;

                            foreach (IIngeoStyle style in layer.Styles)
                            {
                                TreeNode aStyleTreeNode = aLayerTreeNode.Nodes.Add("Style", style.Name);

                                aStyleTreeNode.ImageIndex = 5;
                                aStyleTreeNode.SelectedImageIndex = 5;

                                foreach (IIngeoPainter painter in style.Painters)
                                {
                                  
                                    if (painter is IIngeoStdPainter)
                                    {
                                        TreeNode stdPainter = aStyleTreeNode.Nodes.Add("StdPainter", "Standard");

                                        stdPainter.ImageIndex = 6;
                                        stdPainter.SelectedImageIndex = 6;
                                    }
                                    else
                                    {
                                        if (painter is IIngeoTextPainter)
                                        {
                                            TreeNode textPainter = aStyleTreeNode.Nodes.Add("StdPainter", "Text");

                                            textPainter.ImageIndex = 7;
                                            textPainter.SelectedImageIndex = 7; 
                                        }
                                        else
                                        {
                                            TreeNode symbolPainter = aStyleTreeNode.Nodes.Add("StdPainter", "Symbol");

                                            symbolPainter.ImageIndex = 8;
                                            symbolPainter.SelectedImageIndex = 8;
                                        }
                                    }
                                }
                            }
                            foreach (IIngeoSemTable SemTable in layer.SemTables)
                            {
                                TreeNode aSemTable = aLayerTreeNode.Nodes.Add("SemTable", SemTable.Name);

                                aSemTable.ImageIndex = 9;
                                aSemTable.SelectedImageIndex = 9;
                            }
                        }
                    }
                    else
                    {
                        aMapTreeNode.ImageIndex = 10;
                        aMapTreeNode.SelectedImageIndex = 10;
                    }
                }
            }
=======


                        }
                    }

                }


            }
            

>>>>>>> ef18f144040be708478faf6dde1bfa7d1ed2d067
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
