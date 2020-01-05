using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1: blue
// 2: red
// 3: green
// 4: black

// value goes from 1 to 13

public class Tile : MonoBehaviour
{
    // public GameObject TileBlock;
    private int value;
    private int color;

    public Tile(int _val, int _col) {
        value = _val;
        color = _col;
    }

    public int getValue() { return value; }
    public int getColorAsInt() { return color; }
    public string getColorAsString() { 
        switch (color) {
            case 1:
                return "Blue";
            case 2:
                return "Red";
            case 3:
                return "Green";
            default:
                return "Black";
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
