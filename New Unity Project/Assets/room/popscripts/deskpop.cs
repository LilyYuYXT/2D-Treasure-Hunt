using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deskpop : MonoBehaviour
{
    // Start is called before the first frame update
    public bool touchdesk;
    public GameObject desk;
    public GameObject Map;

    // Start is called before the first frame update
    void Start()
    {
        desk = GameObject.Find("paneldesk");
        Map = GameObject.Find("Map");
        desk.SetActive(false);
        Map.SetActive(false);
        touchdesk = false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            touchdesk = true;
            desk.SetActive(true);

        }
    }
    private void Update()
    {
        if (touchdesk &&Input.GetKeyDown("m"))
        {
            Map.SetActive(true);


        }
    }
    // Update is called once per frame
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchdesk = false;
        desk.SetActive(false);
        Map.SetActive(false);
    }
}
