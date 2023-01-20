using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessPiece
{
    public override List<Vector2Int> GetAvailableMoves(ref ChessPiece[,] bord, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();
        if (currentX + 1 < tileCountX)
        {
            if (bord[currentX + 1, currentY] == null)
                r.Add(new Vector2Int(currentX + 1, currentY));

            else if (team != bord[currentX + 1, currentY].team)
                r.Add(new Vector2Int(currentX + 1, currentY));

            if (currentY + 1 < tileCountY)
            {
                if (bord[currentX + 1, currentY + 1] == null)
                    r.Add(new Vector2Int(currentX + 1, currentY + 1));

                else if (team != bord[currentX + 1, currentY + 1].team)
                    r.Add(new Vector2Int(currentX + 1, currentY + 1));
            }
            if (currentY - 1 >= 0)
            {
                if (bord[currentX + 1, currentY - 1] == null)
                    r.Add(new Vector2Int(currentX + 1, currentY - 1));

                else if (team != bord[currentX + 1, currentY - 1].team)
                    r.Add(new Vector2Int(currentX + 1, currentY - 1));
            }
        }
        if (currentX - 1 >= 0)
        {
            if (bord[currentX - 1, currentY] == null)
                r.Add(new Vector2Int(currentX - 1, currentY));

            else if (team != bord[currentX - 1, currentY].team)
                r.Add(new Vector2Int(currentX - 1, currentY));

            if (currentY + 1 < tileCountY)
            {
                if (bord[currentX - 1, currentY + 1] == null)
                    r.Add(new Vector2Int(currentX - 1, currentY + 1));

                else if (team != bord[currentX - 1, currentY + 1].team)
                    r.Add(new Vector2Int(currentX - 1, currentY + 1));
            }
            if (currentY - 1 >= 0)
            {
                if (bord[currentX - 1, currentY - 1] == null)
                    r.Add(new Vector2Int(currentX - 1, currentY - 1));

                else if (team != bord[currentX - 1, currentY - 1].team)
                    r.Add(new Vector2Int(currentX - 1, currentY - 1));
            }
        }
        if (currentY - 1 >= 0){
            if (bord[currentX, currentY - 1] == null)
                    r.Add(new Vector2Int(currentX, currentY - 1));

                else if (team != bord[currentX, currentY - 1].team)
                    r.Add(new Vector2Int(currentX, currentY - 1));
        }
        if (currentY + 1 < tileCountY){
            if (bord[currentX, currentY + 1] == null)
                    r.Add(new Vector2Int(currentX, currentY + 1));

                else if (team != bord[currentX, currentY + 1].team)
                    r.Add(new Vector2Int(currentX, currentY + 1));
        }

        return r;
    }
}
