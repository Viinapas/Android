using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaSkiJump
{
    class Referens1
    { 
    }
   
    public class Jump
    {
        public float t1, t2, t3, t4, t5;
        public float jumplong;
        public float points ;
    }

    public class Hill

        // Points
    {
        public String hillName;
        public float cp; //critic line
        public float factor; //factor
        public float kpp; // criticline counterpoints
                
    }
    public class Jumpper

        // SkiJumper
    {
        public string fName;
        public string sName;
        public int number;
        public Jump c1;
        public Jump c2;



        // SkiJump arenas example Lahti

        public Hill h;

        public float points;


    }
}
