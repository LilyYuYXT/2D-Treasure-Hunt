using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sofapop : MonoBehaviour
{
    // Start is called before the first frame update
    public bool touchsofa;
    public GameObject sofa;
    // Start is called before the first frame update
    void Start()
    {
        sofa = GameObject.Find("panelsofa");
        sofa.SetActive(false);
        touchsofa = false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            touchsofa = true;
            sofa.SetActive(true);

        }
    }
    // Update is called once per frame
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchsofa = false;
        sofa.SetActive(false);
    }
}
