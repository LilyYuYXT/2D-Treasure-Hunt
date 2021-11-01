using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelGuard : MonoBehaviour
{
    // Start is called before the first frame update
    public bool touchguard;
    public GameObject guard;
    // Start is called before the first frame update
    void Start()
    {
        guard = GameObject.Find("panelguard");
        guard.SetActive(false);
        touchguard = false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            touchguard = true;
            guard.SetActive(true);

        }
    }
    // Update is called once per frame
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchguard = false;
        guard.SetActive(false);
    }
}

