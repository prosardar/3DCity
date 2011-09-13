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
    public class Engine3DCOM
    {
        Form1 f;

        public Engine3DCOM()
        {

        }

        public void Init(IIngeoApplication Ingeo)
        {
            f = new Form1(Ingeo);
            f.Show();
        }

        public void Done()
        {
            f.Close();
            f.Dispose();
            f = null;
        }
    }
}
