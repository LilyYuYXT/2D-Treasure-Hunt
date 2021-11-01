using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cherrycollector : MonoBehaviour
{
    // Start is called before the first frame update
    public int cherry = 0;
    public bool guard;
   
    [SerializeField] private Text cherrytext;

    public void Start()
    {
       
     
        guard = false;
    }
   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cherry"))
        {


            Destroy(collision.gameObject);
            cherry++;
            cherrytext.text = "cherry:"+ cherry +"/9";
            
        }
    }
  public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "rock"&& cherry==1)
        {
            Debug.Log("Ahhhhh");
            guard = true;
            
        }
       
    }
    
}
