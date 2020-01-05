using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject tilePrefab;
    List<Tile> tiles = new List<Tile>();

    GameObject player1;
    GameObject player2;


    void Start()
    {
        for (int val = 1; val <= 13; val++) {
            for (int color = 1; color <= 4; color++) {
                tiles.Add(new Tile(val, color));
                tiles.Add(new Tile(val, color));
            }
        }
        
        Shuffle(tiles);

        player1 = GameObject.Find("Player (1)");
        player2 = GameObject.Find("Player (2)");
    }

    void Update()
    {
        
    }

    public Tile DrawTile() {
        // picks index to remove from
        int index = Random.Range(0, tiles.Count - 1);
        // saves tile at that index
        Tile temp = tiles[index];
        // removes tile from list
        tiles.RemoveAt(index);
        // returns tile
        return temp;
    }




    // helper methods

    private Color getColorFromNumber(int num) {
        switch (num) {
            case 1:
                return Color.blue;
            case 2:
                return Color.red;
            case 3:
                return Color.green;
            default:
                return Color.black;
        }
    }

    private void Shuffle<T>(List<T> list)  
    {  
        for (int i = 0; i < list.Count; i++) {
            T temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}

