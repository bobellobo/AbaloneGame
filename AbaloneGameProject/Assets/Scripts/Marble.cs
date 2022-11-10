using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble 
{

    public Player player {get ; private set ;}
    public int marbleNumber {get; private set;}

    public Marble(Player tmpPlayer, int tmpMarbleNumber) {
        this.player = tmpPlayer;
        this.marbleNumber = tmpMarbleNumber;
    }

}
