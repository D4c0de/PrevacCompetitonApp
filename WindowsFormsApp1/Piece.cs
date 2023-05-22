using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public struct Piece
    {
        public String color { get; set; }
        public int ID { get; set; }
        public Piece(string _color,int _id)
        {
            color= _color;
            ID = _id;
        }
    }
}
