// Type: Ingeo.IIngeoPainter
// Assembly: Interop.Ingeo, Version=1.0.0.0, Culture=neutral
// Assembly location: D:\Projects\Shrp\Study\3DCity\3DCity\obj\Debug\Interop.Ingeo.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Ingeo
{
    [TypeLibType(4160)]
    [Guid("DBCE7A91-927D-11D3-967F-000021C6D845")]
    [ComImport]
    public interface IIngeoPainter
    {
        [DispId(6)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Delete();

        [DispId(7)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void PaintContour([MarshalAs(UnmanagedType.Interface), In] IIngeoPaintSurface aSurface,
                          [MarshalAs(UnmanagedType.Interface), In] IIngeoContour aContour,
                          [MarshalAs(UnmanagedType.BStr), In] string aData);

        [DispId(1)]
        string Comment { [DispId(1)]
        get; [DispId(1)]
        set; }

        [DispId(2)]
        double VisibleMin { [DispId(2)]
        get; [DispId(2)]
        set; }

        [DispId(3)]
        double VisibleMax { [DispId(3)]
        get; [DispId(3)]
        set; }

        [DispId(4)]
        TIngeoPainterType PainterType { [DispId(4)]
        get; }

        [DispId(5)]
        int Index { [DispId(5)]
        get; [DispId(5)]
        set; }
    }
}
