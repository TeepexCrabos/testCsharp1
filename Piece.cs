using System;
using System.Collections.Generic;
using System.Text;

namespace testCsharp1
{
    class Piece
    {
        public Piece()
        {
            numero = 0;
        }
       
        public int numero { get; set; }

        public void piece_plus()
        {
            numero = numero + 1;
        }
    }

}
