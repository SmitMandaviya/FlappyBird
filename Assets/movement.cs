using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rg;
    public float move;

    public Logicscript logic;

    public bool Birdy = true;
    void Start()
    {
          logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();   
    }

    // Update is called once per frame
    void Update()
    {

        // if(Input.GetTouch(0).phase == TouchPhase.Began && Birdy)
        // if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && Birdy)
        if(Input.GetKeyDown(KeyCode.Space) && Birdy)
        {
            rg.velocity = Vector2.up * move;
        }
        if(transform.position.y > 14 || transform.position.y < -14)
        {
            logic.gameover();
            Birdy = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D other) {
        logic.gameover();
        Birdy = false;
    }
}
