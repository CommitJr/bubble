using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerData {

    public int level;
    public int level5;
    public int level4;
    public int level3;
    public int level2;
    public int level1;
    public int world;
    
    public int health;
    public float[] position;
    public float score;
    

    public playerData(bolha player)
    {
        level = player.level;
        level5 = player.level5;
        level4 = player.level4;
        level3 = player.level3;
        level2 = player.level2;
        level1 = player.level1;

        health = player.health;
        world = player.world;

        position = new float[2];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
    }
}
