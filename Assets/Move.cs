using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float movepipe;

    public float destroypipe = -40;
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
      transform.position  = transform.position + (Vector3.left * movepipe) * Time.deltaTime;

      if(transform.position.x < destroypipe)
      {
        Destroy(gameObject);
      }
    }
}
