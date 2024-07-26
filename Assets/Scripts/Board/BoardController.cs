using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    public int width = 10;
    public int height = 10;
    public int[,] tiles;

    void Start()
    {
        Debug.Log("board");
        GenerateRandomBoard();
        PrintTiles();
    }

    void Update()
    {
        
    }

    void PrintTiles() {
        string result = "";
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                result += tiles[i, j] + " ";
            }
            result += "\n";
        }
        Debug.Log(result);
    }

    void GenerateRandomBoard() {
        tiles = new int[width, height];
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                tiles[i, j] = 1;
            }
        }
    }

    void LoadBoardFromFile() {

    }

    void SaveBoardToFile() {

    }
}
