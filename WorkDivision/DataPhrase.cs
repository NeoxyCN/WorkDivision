using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkDivision
{
    public class DataPhrase
    {
        //姓名,主持,便利贴,灯,pu,盖章,姓名2,主持,便利贴,灯,pu,盖章,
        //works number
        public int WORKS_NUMBER = 5;
        public struct result
        {
            public int length;
            public string[] resultArray;
        }

        public static result r;

        public DataPhrase()
        {
            r.length = 0;
            r.resultArray = new string[0];
        }

        public result Phrase(string text)
        {
            string[] results=text.Split(',');
            r.length = results.Length;
            r.resultArray = results;

            return r;
        }

        public List<string> GetNameList()
        {
            List<string> list = new List<string>();

            string[] strArray=r.resultArray;
            for (int i = 0; i < r.length; i+=(WORKS_NUMBER+1))
            {
                string temp = strArray[i];
                System.Diagnostics.Debug.WriteLine(temp);
                list.Add(temp);
            }
            
            return list;
        }

    }
}
