using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class UserBO
    {
        public UserBO(string json)
        {
            string bodySeparator = ",";
            string[] stringSeparators = new string[] { bodySeparator };
            string[] splitBodey = json.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            if (splitBodey.Length == 5)
            {
                string body = ":";
                string[]  stringSeparators1 = new string[] { body };
                string temp = splitBodey[0];
                string[] splitCreated_at = temp.Split(stringSeparators1, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < splitCreated_at.Length; i++)
                {
                
                    _Created_at += splitCreated_at[i].Replace("\"", "");
                        if(i+1<splitCreated_at.Length)
                            _Created_at += ":";
                }
                   
                
               


                string[] splitId = splitBodey[1].Split(stringSeparators1, StringSplitOptions.RemoveEmptyEntries);
                _Id = getNumber(splitId[1].Replace("\"", ""));


                string[] splitTitle = splitBodey[2].Split(stringSeparators1, StringSplitOptions.RemoveEmptyEntries);
                _Title = splitTitle[1].Replace("\"", "");


                string[] splitUpdateed_at = splitBodey[3].Split(stringSeparators1, StringSplitOptions.RemoveEmptyEntries);
                _Updateed_at = splitUpdateed_at[1].Replace("\"", "");

                string[] splitUserId = splitBodey[4].Split(stringSeparators1, StringSplitOptions.RemoveEmptyEntries);
                _UserId =getNumber(splitUserId[1].Replace("\"", ""));
               
               
            }  
        }

        private string _Created_at = string.Empty;
        private int _Id = -1;
        private string _Title = string.Empty;
        private string _Updateed_at = string.Empty;
        private int _UserId = -1;

        private int getNumber(string a)
        {
            string b = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsDigit(a[i]))
                    b += a[i];
            }
            if (b.Length > 0)
                return  int.Parse(b);
            return -1;
        }
        public string Created_at
        {
            get{return _Created_at;}
            set{value = _Created_at;}
        }
        public int UserId
        {
            get { return _UserId; }
            set { value = _UserId; }
        }
        public int Id
        {
            get { return _Id; }
            set { value = _Id; }
        }
        public string Title
        {
            get { return _Title; }
            set { value = _Title; }
        }
        public string Updateed_at
        {
            get { return _Updateed_at; }
            set { value = _Updateed_at; }
        }
        public string toString()
        {
            return " Created_at :" + _Created_at + " Id :" + _Id + " Title :" + _Title +  " Updateed_at :" + _Updateed_at + " UserId :" + _UserId ;
        }


    }
}
