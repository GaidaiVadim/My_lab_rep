using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz_1
{
    [Serializable]
    class student
    {
        int nomer;
        string surname;
        string name;
        string subject;
        string rating;
        string vrating;
        string grupa;
        
        //________________

        public void set_nomer(int set)
        {
            nomer = set;
        }
        public void set_surname(string set)
        {
            surname = set;
        }
        public void set_name(string set)
        {
            name = set;
        }
        public void set_subject(string set)
        {
            subject = set;
        }
        public void set_rating(string set)
        {
            rating = set;
        }
        public void set_vrating(string set)
        {
            vrating = set;
        }
        public void set_grupa(string set)
        {
            grupa = set;
        }

        public int get_nomer()
        {
            return nomer;
        }
        public string get_surname()
        {
            return surname;
        }
        public string get_name()
        {
            return name;
        }
        public string get_subject()
        {
            return subject;
        }
        public string get_rating()
        {
            return rating;
        }
        public string get_vrating()
        {
            return vrating;
        }
        public string get_grupa()
        {
            return grupa;
        }
       
    }
}
