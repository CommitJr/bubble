using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    [Header("Movimento sinudal")]
    public float speed;
    public float amplitude;    
    float startingVal;

    [SerializeField] private float velocity;
    void Start()
    {
       
    }

    void Update()
    {
        Sine(speed, amplitude);
    }

    private void OnEnable()
    {
        startingVal = transform.position.y;
    }

    private void Sine(float Speed, float Amplitude)
    {
        float x = transform.position.x;
        float z = transform.position.z;
        float y = Mathf.Sin(Time.time * Speed) * Amplitude;

        transform.position = new Vector3(x, startingVal + y, z);
    }


}
