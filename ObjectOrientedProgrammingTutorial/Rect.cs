using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTutorial {
    class Rect : Quad{
        // Polymorphic Behavior Derived line 8-11
        public override string Print() {
            return "Rect";
        
        }

        public int Area() {
            return Side1 * Side2;
        }

        public Rect() { }

        public Rect(int s1 , int s2) : base(s1, s2, s1, s2) { 
        
        }
    }
}
