using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _3080ReleaseTool
{
    public class Library
    {
        public string getCurrentTime()
        {
            try
            {
                string time = DateTime.Now.ToString("hh:mm:ss");
                return time;
            }
            catch(Exception ex)
            {
                errorHandler("GetCurrentTime", ex.ToString());
                return "TIMEERROR";
            }
        }

        public void errorHandler(string title, string error)
        {
            MessageBox.Show(error, title);
        }
    }
}
