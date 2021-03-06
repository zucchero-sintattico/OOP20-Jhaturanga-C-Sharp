using System;
using System.Collections.Generic;
using Scolari.Boards;
using Scolari.Util;

namespace Scolari.Pieces
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
            this.Identifier = pieceType.ToString() + "-" + pieceActualBoardPosition.ToString() + "-" + piecePlayerOwner?.ToString() ;
            this.Type = pieceType;
            this.PiecePosition = pieceActualBoardPosition;
            this.HasMoved = false;
            this.Player = piecePlayerOwner;
        }

        public override bool Equals(object obj)
        {
            return obj is Piece piece &&
                   Type == piece.Type &&
                   EqualityComparer<IBoardPosition>.Default.Equals(PiecePosition, piece.PiecePosition) &&
                   EqualityComparer<IPlayer>.Default.Equals(Player, piece.Player) &&
                   HasMoved == piece.HasMoved;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Type, PiecePosition, Player, HasMoved);
        }
    }
}
