using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Board;
using Jhaturanga_CSharp.Movement.MovementManaging;

namespace Jhaturanga_CSharp.Pieces
{
    public class Piece : IPiece
    {
        public string Identifier { get; }

        public PieceType Type { get; }

        public IBoardPosition PiecePosition { get; set; }

        public IPlayer Player { get; }

        public bool HasMoved { get; set; }

        public Piece(PieceType pieceType, IBoardPosition pieceActualBoardPosition,
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
