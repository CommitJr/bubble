using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerData {

    public int level;
    public int health;
    public float[] position;
    public float score;
    public int world;

    public playerData(bolha player)
    {
        level = player.level;
        health = player.health;
        world = player.world;

        position = new float[2];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
    }
}
