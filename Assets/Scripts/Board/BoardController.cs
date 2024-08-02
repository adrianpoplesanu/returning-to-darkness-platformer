using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    public int width = 10;
    public int height = 10;
    public int[,] tiles;
    public GameObject[,] renderingTiles;
    public Sprite newSpriteTile0;
    public Sprite newSpriteTile1;
    public Sprite newSpriteTile2;
    public Sprite newSpriteTile3;
    public Sprite newSpriteTile4;
    public Sprite newSpriteTile5;
    public Sprite newSpriteTile6;
    public Sprite newSpriteTile7;
    public Sprite newSpriteTile8;
    public Sprite newSpriteTile9;

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
        renderingTiles = new GameObject[width, height];
        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {
                tiles[i, j] = Random.Range(0, 10);
                renderingTiles[i, j] = new GameObject();
                SpriteRenderer spriteRenderer = renderingTiles[i, j].AddComponent<SpriteRenderer>();
                switch(tiles[i, j]){
                    case 0:
                        spriteRenderer.sprite = newSpriteTile0;
                    break;
                    case 1:
                        spriteRenderer.sprite = newSpriteTile1;
                    break;
                    case 2:
                        spriteRenderer.sprite = newSpriteTile2;
                    break;
                    case 3:
                        spriteRenderer.sprite = newSpriteTile3;
                    break;
                    case 4:
                        spriteRenderer.sprite = newSpriteTile4;
                    break;
                    case 5:
                        spriteRenderer.sprite = newSpriteTile5;
                    break;
                    case 6:
                        spriteRenderer.sprite = newSpriteTile6;
                    break;
                    case 7:
                        spriteRenderer.sprite = newSpriteTile7;
                    break;
                    case 8:
                        spriteRenderer.sprite = newSpriteTile8;
                    break;
                    case 9:
                        spriteRenderer.sprite = newSpriteTile9;
                    break;
                }
                spriteRenderer.sortingOrder = 1;
                renderingTiles[i, j].transform.position = new Vector3(i, j, 0);
            }
        }
    }

    void LoadBoardFromFile() {

    }

    void SaveBoardToFile() {

    }
}
