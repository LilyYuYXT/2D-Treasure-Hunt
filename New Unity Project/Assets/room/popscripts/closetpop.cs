using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closetpop : MonoBehaviour
{
    // Start is called before the first frame update
  
    // Start is called before the first frame update
    public bool touchcloset;
    public GameObject closet;
    // Start is called before the first frame update
    void Start()
    {
        closet = GameObject.Find("panelcloset");
        closet.SetActive(false);
        touchcloset = false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            touchcloset = true;
            closet.SetActive(true);

        }
    }
    // Update is called once per frame
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchcloset = false;
        closet.SetActive(false);
    }
}
