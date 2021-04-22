using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Boards
{

    interface IBoardBuilder
    {
        IBoardBuilder Rows(int rows);

        IBoardBuilder Columns(int columns);

        IBoardBuilder AddPiece(IPiece piece);

        IBoard Build();
    }
}
