﻿using System;
using System.Runtime.InteropServices;

namespace AudioSensei.Bass
{
    [StructLayout(LayoutKind.Sequential)]
    internal readonly struct BassPluginFormat
    {
        public readonly uint ctype;
        public readonly IntPtr name;
        public readonly IntPtr exts;
    }
}
