using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloading
{
    class Vector
    {
        private double length;

        public Vector()
        {

        }
        public Vector(double value)
        {
            this.length = value;
        }


        public static Vector operator +(Vector a, Vector b)
        {
            Vector vector = new Vector();
            vector.length = a.length + b.length;
            return vector;
        }

        public static Vector operator *(Vector c, Vector d)
        {
            Vector vector = new Vector();
            vector.length = c.length * d.length;
            return vector;

        }

        public override string ToString()
        {
            return (String.Format($"{length}"));
        }
    }
}
