using System;
using System.Collections.Generic;
using System.Text;

namespace _3D_Graph
{
    class Demo
    {
        public int X;
        public int Y;
        public int Z;

        public Demo(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;

        }

        internal void Move()
        {
            throw new NotImplementedException();
        }

        internal void Locate()
        {
            throw new NotImplementedException();
        }

        public Demo()
        {
        }

        public void Move(int X, int Y, int Z)
        {
            X = X + 3;
            Y = Y + 2;
            Z = Z + 1;
        }
        public void Graph()
        {
            Console.WriteLine(" you are staning position is:", +X, Y, Z);
        }


    }
}        

   

