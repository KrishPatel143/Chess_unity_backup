using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ChessPiece
{
    public override List<Vector2Int> GetAvailableMoves(ref ChessPiece[,] bord, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();


        int direction = (team == 0) ? 1 : -1;

        if (bord[currentX, currentY + direction] == null)
        {
            r.Add(new Vector2Int(currentX, currentY + direction));
        }
        if ((bord[currentX, currentY + direction] == null) && (bord[currentX, currentY + (direction * 2)]) == null)
        {
            if (team == 0 && currentY == 1)
            {
                r.Add(new Vector2Int(currentX, currentY + direction * 2));
            }
            if (team == 1 && currentY == 6)
            {
                r.Add(new Vector2Int(currentX, currentY + direction * 2));
            }
        }
        if ( currentX != 7)
        {
            if (bord[currentX+1,currentY + direction] != null && bord[currentX+1,currentY + direction].team != team )
            {
                r.Add(new Vector2Int(currentX+1,currentY + direction));
                
            }
        }
        if ( currentX != 0)
        {
            if (bord[currentX-1,currentY + direction] != null && bord[currentX-1,currentY + direction].team != team)
            {
                r.Add(new Vector2Int(currentX-1,currentY + direction));
                
            }
        }

        return r;
    }
}
