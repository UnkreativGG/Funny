﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Funny
{
    public class User32_MouseInputs
    {
        [DllImport("user32.dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT p);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr ptr);
    }






    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct INPUT
    {
        public SendInputEventType type;
        public MOUSEANDKEYBOARDINPUT mkhi;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct KEYBOARDINPUT
    {
        public ushort wVk;
        public ushort wScan;
        public uint dwFlags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HARDWAREINPUT
    {
        public int uMsg;
        public short wParamL;
        public short wParamH;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MOUSEINPUT
    {
        public int dx;
        public int dy;
        public uint mouseData;
        public MouseEventFlags dwFlags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MOUSEANDKEYBOARDINPUT
    {
        [FieldOffset(0)]
        public MOUSEINPUT mi;

        [FieldOffset(0)]
        public KEYBOARDINPUT ki;

        [FieldOffset(0)]
        public HARDWAREINPUT hi;
    }

    [Flags]
    public enum MouseEventFlags : uint
    {
        MOUSEEVENT_MOVE = 0x0001,
        MOUSEEVENT_LEFTDOWN = 0x0002,
        MOUSEEVENT_LEFTUP = 0x0004,
        MOUSEEVENT_RIGHTDOWN = 0x0008,
        MOUSEEVENT_RIGHTUP = 0x0010,
        MOUSEEVENT_MIDDLEDOWN = 0x0020,
        MOUSEEVENT_MIDDLEUP = 0x0040,
        MOUSEEVENT_XDOWN = 0x0080,
        MOUSEEVENT_XUP = 0x0100,
        MOUSEEVENT_WHEEL = 0x0800,
        MOUSEEVENT_VIRTUALDESK = 0x4000,
        MOUSEEVENT_ABSOLUTE = 0x8000
    }

    [Flags]
    public enum SendInputEventType : uint
    {
        InputMouse,
        InputKeyboard,
        InputHardware
    }
}
