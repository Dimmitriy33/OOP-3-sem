using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab9
{
    public class User
    {
        public delegate void Mydelegate(string str);
        public event Mydelegate MoveElement;
        public event Mydelegate SqueezeElement;

        private double size;
        private int position;

        public User()
        {
            this.size = 1;
            this.position = 0;
        }

        public User(double Size, int Pos)
        {
            this.size = Size;
            this.position = Pos;
        }

        internal void Move(int Pos)
        {
            this.Position -= Pos;
            MoveElement?.Invoke($"element moved by {Pos}");
        }
        internal void Squeeze(double coeff)
        {
            this.Size *= coeff;
            SqueezeElement?.Invoke($"element squeezed by {coeff}");

        }

        public double Size
        {
            get => this.size;
            set => this.size = value;
        }

        public int Position
        {
            get => this.position;
            set => this.position = value;
        }

    }

}
