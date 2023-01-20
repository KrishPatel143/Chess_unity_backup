using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessPiece
{
    public override List<Vector2Int> GetAvailableMoves(ref ChessPiece[,] bord, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();


        int x = currentX + 1;
        int y = currentY + 2;

        if (x < tileCountX && y < tileCountY)
        {

            if (Available(x, y, ref bord))
                r.Add(new Vector2Int(x, y));

        }

        x = currentX + 2;
        y = currentY + 1;

        if (x < tileCountX && y < tileCountY)
        {
            if (Available(x, y, ref bord))
                r.Add(new Vector2Int(x, y));

        }

        x = currentX - 2;
        y = currentY + 1;

        if (x >= 0 && y < tileCountY)
        {
            if (Available(x, y, ref bord))
                r.Add(new Vector2Int(x, y));

        }
        x = currentX - 1;
        y = currentY + 2;

        if (x >= 0 && y < tileCountY)
        {
            if (Available(x, y, ref bord))
                r.Add(new Vector2Int(x, y));

        }

        x = currentX + 2;
        y = currentY - 1;

        if (x < tileCountX && y >= 0)
        {
            if (Available(x, y, ref bord))
                r.Add(new Vector2Int(x, y));

        }
        x = currentX + 1;
        y = currentY - 2;

        if (x < tileCountX && y >= 0)
        {
            if (Available(x, y, ref bord))
                r.Add(new Vector2Int(x, y));

        }

        x = currentX - 2;
        y = currentY - 1;

        if (x >= 0 && y >= 0)
        {
            if (Available(x, y, ref bord))
                r.Add(new Vector2Int(x, y));

        }
        x = currentX - 1;
        y = currentY - 2;

        if (x >= 0 && y >= 0)
        {
            if (Available(x, y, ref bord))
                r.Add(new Vector2Int(x, y));

        }

        return r;
    }
    private bool Available(int x, int y, ref ChessPiece[,] bord)
    {
        if (bord[x, y] != null)
        {
            if (team == bord[x, y].team)
                return false;
        }
        return true;
    }

}
