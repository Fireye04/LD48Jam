using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject player;
    public Transform transform;
  
    private float playerLoc;
    private float mousePos;
    private Transform playerT;
    private Vector2 worldPosition;
    private Vector3 currentpos;
    private Vector3 originalpos;
    private Vector3 originalScale;
    private CharacterController2D CC2D;
    public int flipConstant;

    private bool s_FacingRight;

    private void Start() {
        int flipConstant = 1;
        Vector3 originalpos = new Vector3 (1, 0, 0);
        Vector3 originalScale = new Vector3 (1, 1, 1);
        if (player != null) {
            playerT = player.GetComponent<Transform>();
            CC2D = player.GetComponent<CharacterController2D>();
        }

    }


    void Update() {

        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        float mouseLoc = worldPosition.x;
        float playerLoc = playerT.position.x;
        Debug.Log(player.transform.position.x - transform.position.x);

        if (mouseLoc < playerLoc &&CC2D.m_FacingRight) {

            transform.position = new Vector2(player.transform.position.x - 1, transform.position.y);
            transform.localScale = new Vector3(-1f, 1f, 1f);


        }

        else if (mouseLoc > playerLoc && CC2D.m_FacingRight)
        {
            transform.position = new Vector2(player.transform.position.x + 1,transform.position.y);

            transform.localScale = new Vector3(1f, 1f, 1f);


        }
        else if (mouseLoc < playerLoc && !CC2D.m_FacingRight) {


            transform.position = new Vector2(player.transform.position.x - 1, transform.position.y);
            transform.localScale = new Vector3(1f, 1f, 1f);

        }
        else if (mouseLoc > playerLoc  && !CC2D.m_FacingRight) {

        
            transform.position = new Vector2(player.transform.position.x + 1, transform.position.y);
            transform.localScale = new Vector3(-1f, 1f, 1f);

        } /*else {
            Debug.Log("else"); 
            transform.localPosition = originalpos;
            transform.localScale = originalScale;
        }*/
    }

    private void Flip(float face) {
        // Switch the way the player is labelled as facing.
        s_FacingRight = !s_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

        Vector3 currentpos = transform.localPosition;
        currentpos.x += face;
        transform.localPosition = currentpos;
    }
}
