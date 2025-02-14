﻿using System;
using System.Runtime.InteropServices;

namespace FFXIVClientStructs.STD
{
    // std::string aka std::basic_string from msvc
    [StructLayout(LayoutKind.Explicit, Size=0x20)]
    public unsafe struct String
    {
        // if (Length < 16) uses Buffer else uses BufferPtr
        [FieldOffset(0x0)] public byte* BufferPtr;
        [FieldOffset(0x0)] public fixed byte Buffer[16];
        [FieldOffset(0x10)] public ulong Length;
        [FieldOffset(0x18)] public ulong Capacity;
    }
}