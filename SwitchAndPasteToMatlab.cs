// //declarations
using System; // For IntPtr
using System.Runtime.InteropServices; // DllImport
using System.Diagnostics; // Process
using System.Windows.Forms; // SendKeys
// using System.Windows.Automation; //  UIAutomationClient.dll 
// using System.Threading; // For Thread.Sleep

class Program
{
    // --------------------------------------------------------------------------------
    // ---  Switch and Paste to Matlab
    // --------------------------------------------------------------------------------
    //dll import (can't be in method, but needs to be in class
    [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd);
    static int  switch_and_paste(string procName, string keys)
    {
        Process[] procs = Process.GetProcessesByName(procName);
        int nProcs = procs.Length;
        if (nProcs < 1) {
            Console.WriteLine("No process found for name: {0}", procName);
            return -1;
        }else{
            // We'll use the first window we found
            Process proc=procs[0];
            if (nProcs >1) {
                Console.WriteLine("{0} processes found with name: {0}",nProcs,procName);
                Console.WriteLine("Using first process:");
                Console.WriteLine("Process Name: {0} ID: {1} Title: {2}", proc.ProcessName, proc.Id, proc.MainWindowTitle);
            }
            // --- Switching to window using user32.dll function
            SwitchToThisWindow(proc.MainWindowHandle);
            SendKeys.SendWait("{Escape}");
            SendKeys.SendWait(keys);
            return 0;
        } // Proc Window found
    }


    public static int Main(string[] args)
    {
        // --------------------------------------------------------------------------------
        // --- Parsing arguments 
        // --------------------------------------------------------------------------------
        int nArgs=args.Length;
        switch (nArgs){
            case 0:
                // Default
                return switch_and_paste("MATLAB","^v");
                break;
            case 1:
                // Default
                return switch_and_paste(args[0],"^v");
                break;
            case 2:
                // Default
                return switch_and_paste(args[0],args[1]);
                break;
            default:
                return -1;
                break;
        }
    }
} // Class Program
