using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol1 : MonoBehaviour
{
    public float speed;
    private bool movingRight = true;
    public Transform groundDetetction;
    public Transform boxDetect;
    public Rigidbody2D rb;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetetction.position, Vector2.down, 2f);
        RaycastHit2D boxInfo = Physics2D.Raycast(boxDetect.position, Vector2.right, 2f);
  

        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
             
            }
        }
        if(boxInfo.collider == false)
        {
           transform.eulerAngles = new Vector3(0, 0, 0);
           movingRight = true;
          // rb.AddForce(Vector2.up * 2);

        }
    }
  
}
