using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cherrycollector : MonoBehaviour
{
    // Start is called before the first frame update
    private int cherry = 0;

    [SerializeField] private Text cherrytext;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cherry"))
        {
            Destroy(collision.gameObject);
            cherry++;
            cherrytext.text = "cherry;" + cherry;
        }
    }
}
