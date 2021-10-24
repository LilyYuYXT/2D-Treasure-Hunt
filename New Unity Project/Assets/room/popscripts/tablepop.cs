using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablepop : MonoBehaviour
{
    // Start is called before the first frame update
    public bool touchtable;
    public GameObject table;
    // Start is called before the first frame update
    void Start()
    {
        table = GameObject.Find("paneltable");
        table.SetActive(false);
        touchtable = false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            touchtable = true;
            table.SetActive(true);

        }
    }
    // Update is called once per frame
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchtable = false;
        table.SetActive(false);
    }
}
