using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Ingeo;

namespace LandScape3D
{
    [ComVisible(true)]
    [Guid("5b71e6e1-e7bb-4e61-be5d-60e46e9bfb22")]
    public class Class1
    {
        Form1 f;

        public Class1()
        {

        }

        public void Init(IIngeoApplication Ingeo)
        {
          //  bdb = new BackupDb(Ingeo);

            f = new Form1(Ingeo);
            f.Show();
            System.Windows.Forms.MessageBox.Show("Forms loaded");
        }

        public void Done()
        {
            f.Close();
            f.Dispose();
            f = null;
        }
    }
}
