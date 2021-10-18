using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Key 2")
        {
            Destroy(GameObject.FindWithTag("Door2"));
            Destroy(GameObject.FindWithTag("Key2"));
        }
    }
}
