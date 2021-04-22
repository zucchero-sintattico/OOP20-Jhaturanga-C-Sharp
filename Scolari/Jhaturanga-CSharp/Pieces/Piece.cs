using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Board; 

namespace Jhaturanga_CSharp
{
    public class Piece : IPiece
    {
        public string Identifier { get; }

        public PieceType Type { get; }

        public IBoardPosition PiecePosition { get; set; }

        public IPlayer Player { get; }

        public bool HasMoved { get; set; }

        public Piece(PieceType pieceType, BoardPosition pieceActualBoardPosition,
            IPlayer piecePlayerOwner)
        {
            this.Identifier = pieceType.ToString() + "-" + piecePlayerOwner.ToString() + "-" + pieceActualBoardPosition.ToString();
            this.Type = pieceType;
            this.PiecePosition = pieceActualBoardPosition;
            this.HasMoved = false;
            this.Player = piecePlayerOwner;
        }

    }
}
