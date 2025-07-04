using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carr : MonoBehaviour
{
    public Rigidbody2D frintTire;
    public Rigidbody2D backTire;
    public float speed = 20;

    private float movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal"); 
    }
    private void FixedUpdate()
    {
        backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        frintTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
    }
}
