using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Funny
{
    public class MouseInputs
    {
        public static void ClickLeftMouseButton()
        {
            INPUT mouseDownInput = new INPUT();
            mouseDownInput.type = SendInputEventType.InputMouse;
            mouseDownInput.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENT_LEFTDOWN;
            User32_MouseInputs.SendInput(1, ref mouseDownInput, Marshal.SizeOf(new INPUT()));

            INPUT mouseUpInput = new INPUT();
            mouseUpInput.type = SendInputEventType.InputMouse;
            mouseUpInput.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENT_LEFTUP;
            User32_MouseInputs.SendInput(1, ref mouseUpInput, Marshal.SizeOf(new INPUT()));
        }
        public static void ClickRightMouseButton()
        {
            INPUT mouseDownInput = new INPUT();
            mouseDownInput.type = SendInputEventType.InputMouse;
            mouseDownInput.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENT_RIGHTDOWN;
            User32_MouseInputs.SendInput(1, ref mouseDownInput, Marshal.SizeOf(new INPUT()));

            INPUT mouseUpInput = new INPUT();
            mouseUpInput.type = SendInputEventType.InputMouse;
            mouseUpInput.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENT_RIGHTUP;
            User32_MouseInputs.SendInput(1, ref mouseUpInput, Marshal.SizeOf(new INPUT()));
        }



        public static void MouseButton(MouseEventFlags mouseEventFlags)
        {
            INPUT mouseUpInput = new INPUT();
            mouseUpInput.type = SendInputEventType.InputMouse;
            mouseUpInput.mkhi.mi.dwFlags = mouseEventFlags;
            User32_MouseInputs.SendInput(1, ref mouseUpInput, Marshal.SizeOf(new INPUT()));
        }




        public static void MouseMove(int dx, int dy)
        {
            INPUT mouseMove = new INPUT();
            mouseMove.type = SendInputEventType.InputMouse;
            mouseMove.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENT_MOVE;
            mouseMove.mkhi.mi.dx = dx;
            mouseMove.mkhi.mi.dy = dy;
            User32_MouseInputs.SendInput(1, ref mouseMove, Marshal.SizeOf(new INPUT()));
        }
    }
}
