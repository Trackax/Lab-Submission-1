using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.ComponentModel;

public class ChessPiece : MonoBehaviour
{
    // Createss the Chess Piece Types
    public enum ChessType
    {
        PawnWhite,
        RookWhite,
        KnightWhite,
        BishopWhite,
        QueenWhite,
        KingWhite,
        PawnBlack,
        RookBlack,
        KnightBlack,
        BishopBlack,
        QueenBlack,
        KingBlack
    }

    // Assigns Images to Types
    private string pawnWhite = "Pawn(White)";
    private string rookWhite = "Rook(White)";
    private string knightWhite = "Knight(White)";
    private string bishopWhite = "Bishop(White)";
    private string queenWhite = "Queen(White)";
    private string kingWhite = "King(White)";
    private string pawnBlack = "Pawn(Black)";
    private string rookBlack = "Rook(Black)";
    private string knightBlack = "Knight(Black)";
    private string bishopBlack = "Bishop(Black)";
    private string queenBlack = "Queen(Black)";
    private string kingBlack = "King(Black)";
    public ChessType currentChessType;

    // Points for Gizmo Lines to Connect
    public Transform pawnTarget1;
    public Transform pawnTarget2;
    public Transform rookTarget1;
    public Transform rookTarget2;
    public Transform rookTarget3;
    public Transform rookTarget4;
    public Transform bishopTarget1;
    public Transform bishopTarget2;
    public Transform bishopTarget3;
    public Transform bishopTarget4;
    public Transform knightTarget1;
    public Transform knightTarget2;
    public Transform knightTarget3;
    public Transform knightTarget4;
    public Transform knightTarget5;
    public Transform knightTarget6;
    public Transform knightTarget7;
    public Transform knightTarget8;
    public Transform knightTarget9;
    public Transform knightTarget10;
    public Transform knightTarget11;
    public Transform knightTarget12;
    public Transform queenTarget1;
    public Transform queenTarget2;
    public Transform queenTarget3;
    public Transform queenTarget4;
    public Transform queenTarget5;
    public Transform queenTarget6;
    public Transform queenTarget7;
    public Transform queenTarget8;
    public Transform kingTarget1;
    public Transform kingTarget2;
    public Transform kingTarget3;
    public Transform kingTarget4;
    public Transform kingTarget5;
    public Transform kingTarget6;
    public Transform kingTarget7;
    public Transform kingTarget8;

    // Makes the Chess Piece Visible
    private void OnDrawGizmos()
    {
        switch (currentChessType)
        {
            case ChessType.PawnWhite:
                Gizmos.DrawIcon(transform.position, pawnWhite, true);
                break;
            case ChessType.PawnBlack:
                Gizmos.DrawIcon(transform.position, pawnBlack, true);
                break;
            case ChessType.RookWhite:
                Gizmos.DrawIcon(transform.position, rookWhite, true);
                break;
            case ChessType.RookBlack:
                Gizmos.DrawIcon(transform.position, rookBlack, true);
                break;
            case ChessType.KnightWhite:
                Gizmos.DrawIcon(transform.position, knightWhite, true);
                break;
            case ChessType.KnightBlack:
                Gizmos.DrawIcon(transform.position, knightBlack, true);
                break;
            case ChessType.BishopWhite:
                Gizmos.DrawIcon(transform.position, bishopWhite, true);
                break;
            case ChessType.BishopBlack:
                Gizmos.DrawIcon(transform.position, bishopBlack, true);
                break;
            case ChessType.QueenWhite:
                Gizmos.DrawIcon(transform.position, queenWhite, true);
                break;
            case ChessType.QueenBlack:
                Gizmos.DrawIcon(transform.position, queenBlack, true);
                break;
            case ChessType.KingWhite:
                Gizmos.DrawIcon(transform.position, kingWhite, true);
                break;
            case ChessType.KingBlack:
                Gizmos.DrawIcon(transform.position, kingBlack, true);
                break;
        }
    }

    // Draws the Lines for the Moves
    private void OnDrawGizmosSelected()
    {
        switch (currentChessType)
        {
            case ChessType.PawnWhite:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, pawnTarget1.position);
                Gizmos.DrawLine(transform.position, pawnTarget2.position);
                break;
            case ChessType.RookWhite:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, rookTarget1.position);
                Gizmos.DrawLine(transform.position, rookTarget2.position);
                Gizmos.DrawLine(transform.position, rookTarget3.position);
                Gizmos.DrawLine(transform.position, rookTarget4.position);
                break;
            case ChessType.BishopWhite:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, bishopTarget1.position);
                Gizmos.DrawLine(transform.position, bishopTarget2.position);
                Gizmos.DrawLine(transform.position, bishopTarget3.position);
                Gizmos.DrawLine(transform.position, bishopTarget4.position);
                break;
            case ChessType.KnightWhite:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, knightTarget1.position);
                Gizmos.DrawLine(knightTarget1.position, knightTarget2.position);
                Gizmos.DrawLine(knightTarget1.position, knightTarget3.position);
                Gizmos.DrawLine(transform.position, knightTarget4.position);
                Gizmos.DrawLine(knightTarget4.position, knightTarget5.position);
                Gizmos.DrawLine(knightTarget4.position, knightTarget6.position);
                Gizmos.DrawLine(transform.position, knightTarget7.position);
                Gizmos.DrawLine(knightTarget7.position, knightTarget8.position);
                Gizmos.DrawLine(knightTarget7.position, knightTarget9.position);
                Gizmos.DrawLine(transform.position, knightTarget10.position);
                Gizmos.DrawLine(knightTarget10.position, knightTarget11.position);
                Gizmos.DrawLine(knightTarget10.position, knightTarget12.position);
                break;
            case ChessType.QueenWhite:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, queenTarget1.position);
                Gizmos.DrawLine(transform.position, queenTarget2.position);
                Gizmos.DrawLine(transform.position, queenTarget3.position);
                Gizmos.DrawLine(transform.position, queenTarget4.position);
                Gizmos.DrawLine(transform.position, queenTarget5.position);
                Gizmos.DrawLine(transform.position, queenTarget6.position);
                Gizmos.DrawLine(transform.position, queenTarget7.position);
                Gizmos.DrawLine(transform.position, queenTarget8.position);
                break;
            case ChessType.KingWhite:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, kingTarget1.position);
                Gizmos.DrawLine(transform.position, kingTarget2.position);
                Gizmos.DrawLine(transform.position, kingTarget3.position);
                Gizmos.DrawLine(transform.position, kingTarget4.position);
                Gizmos.DrawLine(transform.position, kingTarget5.position);
                Gizmos.DrawLine(transform.position, kingTarget6.position);
                Gizmos.DrawLine(transform.position, kingTarget7.position);
                Gizmos.DrawLine(transform.position, kingTarget8.position);
                break;
            case ChessType.PawnBlack:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, pawnTarget1.position);
                Gizmos.DrawLine(transform.position, pawnTarget2.position);
                break;
            case ChessType.RookBlack:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, rookTarget1.position);
                Gizmos.DrawLine(transform.position, rookTarget2.position);
                Gizmos.DrawLine(transform.position, rookTarget3.position);
                Gizmos.DrawLine(transform.position, rookTarget4.position);
                break;
            case ChessType.BishopBlack:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, bishopTarget1.position);
                Gizmos.DrawLine(transform.position, bishopTarget2.position);
                Gizmos.DrawLine(transform.position, bishopTarget3.position);
                Gizmos.DrawLine(transform.position, bishopTarget4.position);
                break;
            case ChessType.KnightBlack:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, knightTarget1.position);
                Gizmos.DrawLine(knightTarget1.position, knightTarget2.position);
                Gizmos.DrawLine(knightTarget1.position, knightTarget3.position);
                Gizmos.DrawLine(transform.position, knightTarget4.position);
                Gizmos.DrawLine(knightTarget4.position, knightTarget5.position);
                Gizmos.DrawLine(knightTarget4.position, knightTarget6.position);
                Gizmos.DrawLine(transform.position, knightTarget7.position);
                Gizmos.DrawLine(knightTarget7.position, knightTarget8.position);
                Gizmos.DrawLine(knightTarget7.position, knightTarget9.position);
                Gizmos.DrawLine(transform.position, knightTarget10.position);
                Gizmos.DrawLine(knightTarget10.position, knightTarget11.position);
                Gizmos.DrawLine(knightTarget10.position, knightTarget12.position);
                break;
            case ChessType.QueenBlack:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, queenTarget1.position);
                Gizmos.DrawLine(transform.position, queenTarget2.position);
                Gizmos.DrawLine(transform.position, queenTarget3.position);
                Gizmos.DrawLine(transform.position, queenTarget4.position);
                Gizmos.DrawLine(transform.position, queenTarget5.position);
                Gizmos.DrawLine(transform.position, queenTarget6.position);
                Gizmos.DrawLine(transform.position, queenTarget7.position);
                Gizmos.DrawLine(transform.position, queenTarget8.position);
                break;
            case ChessType.KingBlack:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, kingTarget1.position);
                Gizmos.DrawLine(transform.position, kingTarget2.position);
                Gizmos.DrawLine(transform.position, kingTarget3.position);
                Gizmos.DrawLine(transform.position, kingTarget4.position);
                Gizmos.DrawLine(transform.position, kingTarget5.position);
                Gizmos.DrawLine(transform.position, kingTarget6.position);
                Gizmos.DrawLine(transform.position, kingTarget7.position);
                Gizmos.DrawLine(transform.position, kingTarget8.position);
                break;
        }
    }
}
