using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ChessPiece
{

    public override List<Vector2Int> GetAvailableMoves(ref ChessPiece[,] bord, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        int x = currentX - 1; 
        int y = currentY - 1;
        while( x >=  0 && y >= 0){
            if (bord[x, y] != null)
            {
                if (team != bord[x, y].team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
            r.Add(new Vector2Int(x, y));

            x--;
            y--;
        }
        x = currentX + 1; 
        y = currentY + 1;
        while( x <  tileCountX && y < tileCountY){
            if (bord[x, y] != null)
            {
                if (team != bord[x, y].team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
            r.Add(new Vector2Int(x, y));
            x++;
            y++;
        }
        x = currentX - 1; 
        y = currentY + 1;
        while(x >= 0 && y < tileCountY){
            if (bord[x, y] != null)
            {
                if (team != bord[x, y].team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
            r.Add(new Vector2Int(x, y));
            x--;
            y++;
        }
        x = currentX + 1; 
        y = currentY - 1;
        while( x <  tileCountX && y >= 0){
            if (bord[x, y] != null)
            {
                if (team != bord[x, y].team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
            r.Add(new Vector2Int(x, y));
            x++;
            y--;
        }

        return r;
    }

}
