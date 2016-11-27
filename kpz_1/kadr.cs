using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz_1
{
    [Serializable]
    class kadr
    {
        int rating;
        String surname;
        string name;
        string subject;
        string vrating;
        //________________

        public void set_rating(int set)
        {
            rating = set;
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
        public void set_vrating(string set)
        {
            vrating = set;
        }

        public int get_rating()
        {
            return rating;
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
        public string get_vrating()
        {
            return vrating;
        }
        public System.DateTime get_date()
        {
            return date;
        }
    }
}
