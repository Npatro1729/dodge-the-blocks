using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float gravityFactor = 20f;
    public Rigidbody2D rb;
    void Start(){
        rb.gravityScale += Time.timeSinceLevelLoad / gravityFactor;
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -15f){
            Destroy(gameObject);
        }
    }
}
