using System;
using UnityEngine;

public class Player : MonoBehaviour {
    private Rigidbody rb;

    public float horizontalSpeed;
    public float forwardSpeed;
    public float jumpForce;
    
    public int health;
    public int score;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        health = 3;
        score = 0;
    }

    private void Update()
    {
        float hMovement = Input.GetAxis("Horizontal");
        
        Vector3 movement = new Vector3(hMovement * horizontalSpeed,0,forwardSpeed);
        
        transform.position += movement * Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            AudioManager.instance.PlayJumpSound();
        }
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "Coin")
        {
            
            Destroy(obj.gameObject);
        }
    }

    private void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Car")
        {
            Destroy(obj.transform.parent.gameObject);
            health -= 1;
            if (health <= 0)
            {
                Time.timeScale = 0;
            }
        }
    }
}
