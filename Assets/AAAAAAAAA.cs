using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAAAAAAAA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(xMovement,0);
    }
}
