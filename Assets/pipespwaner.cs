using System;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random =UnityEngine.Random;

public class pipespwaner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float highoffset = 10;

    public float spawnrate = 2;

    private float timer = 0;
    

    void Start()
    {
          spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if ( timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
             spawn();
             timer=0;
        }
    }
    void spawn()
    {
        float lowestpoint=  transform.position.y + highoffset ;
        float highestpoint = transform.position.y - highoffset ;

        Instantiate(pipe,new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint) ,0),transform.rotation);
    }
}
