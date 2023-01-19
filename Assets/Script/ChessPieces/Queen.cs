using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChessPiece
{

    public override List<Vector2Int> GetAvailableMoves(ref ChessPiece[,] bord, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        for (int i = currentY - 1; i >= 0; i--)
        {
            if (bord[currentX, i] != null)
            {
                if (team != bord[currentX, i].team)
                {
                    r.Add(new Vector2Int(currentX, i));
                }
                break;
            }
            r.Add(new Vector2Int(currentX, i));
        }
        for (int i = currentY + 1; i < tileCountY; i++)
        {
            if (bord[currentX, i] != null)
            {
                if (team != bord[currentX, i].team)
                {
                    r.Add(new Vector2Int(currentX, i));
                }
                break;
            }
            r.Add(new Vector2Int(currentX, i));
        }
        for (int i = currentX - 1; i >= 0; i--)
        {
            if (bord[i, currentY] != null)
            {
                if (team != bord[i, currentY].team)
                {
                    r.Add(new Vector2Int(i, currentY));
                }
                break;
            }
            r.Add(new Vector2Int(i, currentY));
        }
        for (int i = currentX + 1; i < tileCountY; i++)
        {
            if (bord[i, currentY] != null)
            {
                if (team != bord[i, currentY].team)
                {
                    r.Add(new Vector2Int(i, currentY));
                }
                break;
            }
            r.Add(new Vector2Int(i, currentY));
        }

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
