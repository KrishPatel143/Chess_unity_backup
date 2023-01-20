using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessPiece
{
    public override List<Vector2Int> GetAvailableMoves(ref ChessPiece[,] bord, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();


        for (int i = currentY-1; i >= 0; i--){
            if(bord[currentX, i] != null){
                if(team != bord[currentX,i].team){
                    r.Add(new Vector2Int(currentX, i));
                }
                break;
            }
            r.Add(new Vector2Int(currentX, i));
        }
        for (int i = currentY+1; i < tileCountY; i++){
            if(bord[currentX, i] != null){
                if(team != bord[currentX,i].team){
                    r.Add(new Vector2Int(currentX, i));
                }
                break;
            }
            r.Add(new Vector2Int(currentX, i));
        }
        for (int i = currentX-1; i >= 0; i--){
            if(bord[i,currentY] != null){
                if(team != bord[i,currentY].team){
                    r.Add(new Vector2Int(i,currentY));
                }
                break;
            }
            r.Add(new Vector2Int(i,currentY));
        }
        for (int i = currentX+1; i < tileCountY; i++){
            if(bord[i,currentY] != null){
                if(team != bord[i,currentY].team){
                    r.Add(new Vector2Int(i,currentY));
                }
                break;
            }
            r.Add(new Vector2Int(i,currentY));
        }

        return r;
    }
}
