using Scolari.Boards;

namespace Scolari.Pieces
{
        public interface IPieceFactory
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="type"></param>
            /// <param name="piecePosition"></param>
            /// <returns></returns>
            IPiece PieceFromPieceType(PieceType type, IBoardPosition piecePosition);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="piecePosition"></param>
            /// <returns></returns>
            IPiece Pawn(IBoardPosition piecePosition);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="piecePosition"></param>
            /// <returns></returns>
            IPiece King(IBoardPosition piecePosition);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="piecePosition"></param>
            /// <returns></returns>
            IPiece Queen(IBoardPosition piecePosition);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="piecePosition"></param>
            /// <returns></returns>
            IPiece Bishop(IBoardPosition piecePosition);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="piecePosition"></param>
            /// <returns></returns>
            IPiece Knight(IBoardPosition piecePosition);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="piecePosition"></param>
            /// <returns></returns>
            IPiece Rook(IBoardPosition piecePosition);
        }
    
}
