using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTac : MonoBehaviour
{
    public int[,] Grid;
    public int row;
    public int col;
    public int space;
    string SpaceGrid;

    public GameObject Prefab;
    void Start()
    {

        Grid = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
               Instantiate(Prefab, new Vector3(i,0,j),Quaternion.identity);
                row += 2;
                col += 2;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void GridSpace()
    {
        for  (space =0 ;  space < 10; space++)
        {
            SpaceGrid = "      ";
        }
    }

}
