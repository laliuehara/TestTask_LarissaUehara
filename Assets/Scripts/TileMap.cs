using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMap : MonoBehaviour
{
    private TilemapRenderer tilemapRender;
    // Start is called before the first frame update
    void Awake()
    {
        tilemapRender  = GetComponent<TilemapRenderer>();  
    }

    // Update is called once per frame
    void Update()
    {
        tilemapRender.enabled = false;
    }
}
