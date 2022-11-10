using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board 
{

    public Dictionary<Marble, int> positions ; // int à remplacer

    public Board(){
        positions = new Dictionary<Marble, int>();
        this.Init();
    }

    void Init(){
        // boucle for de O à 1 pour parcourir Players
            // boucle for pour parcourir les Coords
                // Marble marble = new Marble(Player[i], Coords[j qqch]);
    }

}
