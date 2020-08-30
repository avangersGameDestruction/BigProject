using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OmegaProject.GlobalKeyBoardHook;

namespace OmegaProject
{
    public class GlobalKeyBoardHook
    {
        // multiple dll imports for the auto clicker and other perposes
        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr hhk, int code, int wParam, ref keyBoardHookStruct lParam);
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LLKeyboardHook callback, IntPtr hInstance, uint theardID);
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);
        // delegate int for impelmenting the load library key board hooking
        public delegate int LLKeyboardHook(int Code, int wParam, ref keyBoardHookStruct lParam);
        // int's for calc and call the presses clicks
        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x0101;
        const int WM_SYSKEYDOWN = 0x0104;
        const int WM_SYSKEYUP = 0x0105;
        // a load library key board hooking call
        LLKeyboardHook llkh;
        // generate the hooked key list 
        public List<Keys> HookedKeys = new List<Keys>();

        IntPtr Hook = IntPtr.Zero;
        // public events for calc the clicks if get presses 
        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;

        public GlobalKeyBoardHook()
        {
            llkh = new LLKeyboardHook(HookProc);
        }

        ~GlobalKeyBoardHook()
        { unhook(); }

        // hook the autoclicker
        public void hook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            Hook = SetWindowsHookEx(WH_KEYBOARD_LL, llkh, hInstance, 0);
        }

        // unhook the autoclicker
        public void unhook()
        {
            UnhookWindowsHookEx(Hook);
        }

        // function for hooking the keybind processes
        public int HookProc(int Code, int wParam, ref keyBoardHookStruct lParam)
        {
            if (Code >= 0)
            {
                Keys key = (Keys)lParam.vkCode;
                if (HookedKeys.Contains(key))
                {
                    KeyEventArgs kArg = new KeyEventArgs(key);
                    if ((wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN) && (KeyDown != null))
                        KeyDown(this, kArg);
                    else if ((wParam == WM_KEYUP || wParam == WM_SYSKEYUP) && (KeyUp != null))
                        KeyUp(this, kArg);
                    if (kArg.Handled)
                        return 1;
                }
            }
            return CallNextHookEx(Hook, Code, wParam, ref lParam);
        }
    }

    // structure for hooking the keyboard shortcuts
    public struct keyBoardHookStruct
    {
        public int vkCode;
        public int scanCode;
        public int flags;
        public int time;
        public int dwExtraInfo;
    }
}
