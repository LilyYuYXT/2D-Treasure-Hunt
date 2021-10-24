using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelfpop : MonoBehaviour
{
    public bool touchshelf;
    public GameObject shelf;
    // Start is called before the first frame update
    void Start()
    {
        shelf = GameObject.Find("panelshelf");
        shelf.SetActive(false);
        touchshelf = false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            touchshelf = true;
            shelf.SetActive(true);

        }
    }
    // Update is called once per frame
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchshelf = false;
        shelf.SetActive(false);
    }
}
