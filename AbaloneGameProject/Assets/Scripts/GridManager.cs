using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Hole _holePrefab;

    void Start(){
        GenerateGrid();
    }

    void GenerateGrid(){
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var spawnedHole = Instantiate(_holePrefab, new Vector3(x,y), Quatternion.identity);
                spawnedHole.name = $"Hole {x} {y}";
            }
        }
    }
}
