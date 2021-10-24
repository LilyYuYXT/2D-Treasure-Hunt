using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedpop : MonoBehaviour
{
    // Start is called before the first frame update
    public bool touchbed;
    public GameObject bed;
    // Start is called before the first frame update
    void Start()
    {
        bed = GameObject.Find("panelbed");
        bed.SetActive(false);
        touchbed = false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            touchbed = true;
            bed.SetActive(true);

        }
    }
    // Update is called once per frame
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchbed= false;
        bed.SetActive(false);
    }
}
