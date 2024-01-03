using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WorkDivision
{
    public class MyDataBase
    {
        public string Path;
        public MyDataBase(string path) {
            Path= path;
        }

        public string ReadData()
        {
            try
            {
                StreamReader sr = new StreamReader(Path, Encoding.UTF8);
                string d=sr.ReadToEnd();
                return d;
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show("无法打开data.txt:" + '\n' + '\n'+ ex.ToString(),"错误");
            }
            return "None";
        }

        public bool WriteData()
        {
            return false;
        }
    }
}
