using System;
using System.Runtime.InteropServices;

namespace Go.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GoString
    {
        private readonly IntPtr _ptr;
        private readonly int _size;

        private GoString(IntPtr ptr, int size)
        {
            this._ptr = ptr;
            this._size = size;
        }

        public static implicit operator string(GoString goStr)
        {
            return Marshal.PtrToStringAnsi(goStr._ptr, goStr._size);
        }
    }
}