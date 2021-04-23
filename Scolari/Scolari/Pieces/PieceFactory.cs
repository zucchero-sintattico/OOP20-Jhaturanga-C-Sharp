using System;
using Scolari.Boards;
using Scolari.Util;

namespace Scolari.Pieces
{
    class PieceFactory : IPieceFactory
    {

        private readonly IPlayer player;

        public PieceFactory(IPlayer player)
        {
            this.player = player;
        }

        public IPiece Bishop(IBoardPosition piecePosition)
        {
            return this.PieceFromPieceType(PieceType.BISHOP, piecePosition);
        }

        public IPiece King(IBoardPosition piecePosition)
        {
            return this.PieceFromPieceType(PieceType.KING, piecePosition);
        }

        public IPiece Knight(IBoardPosition piecePosition)
        {
            return this.PieceFromPieceType(PieceType.KNIGHT, piecePosition);
        }

        public IPiece Pawn(IBoardPosition piecePosition)
        {
            return this.PieceFromPieceType(PieceType.PAWN, piecePosition);
        }

        public IPiece PieceFromPieceType(PieceType type, IBoardPosition piecePosition)
        {
            return new Piece(type, piecePosition, this.player);
        }

        public IPiece Queen(IBoardPosition piecePosition)
        {
            return this.PieceFromPieceType(PieceType.QUEEN, piecePosition);
        }

        public IPiece Rook(IBoardPosition piecePosition)
        {
            throw new NotImplementedException();
        }
    }
}
