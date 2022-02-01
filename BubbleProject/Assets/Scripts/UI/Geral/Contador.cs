using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador{
    private float currentTime;
    private float maxTime;

    public void SetCurrentTime(float time)
    {
        currentTime = time;
    }
    public Contador(float maxTime){
        this.maxTime = maxTime;
        currentTime = 0;
    }

    public bool RepeatCountTime(){

        currentTime += Time.deltaTime;

        if(currentTime > maxTime){
            currentTime = 0;
            return true;
        }
        
        return false;
    }

    
}
