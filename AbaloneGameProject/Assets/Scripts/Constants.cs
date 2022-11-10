using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Player {BLACK, WHITE}

public enum LetterCoords { A, B, C, D, E, F, G, H, I }
public enum NumCoords { 
    ONE = 1, 
    TWO = 2, 
    THREE = 3, 
    FOUR = 4, 
    FIVE = 5, 
    SIX = 6,
    SEVEN = 7,
    EIGHT = 8,
    NINE = 9
}

public enum Direction {
    NONE,
    LEFT,
    RIGHT,
    UP_LEFT,
    UP_RIGHT,
    DOWN_LEFT,
    DOWN_RIGHT

}

public class Constants 
{
    public const string GAME_TITLE = "Abalone" ;
}
