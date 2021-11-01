using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip Spell_04;


    void Start()

    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = Spell_04;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Key")
        {
            GetComponent<AudioSource>().Play();
            Destroy(GameObject.FindWithTag("Door1"));

            Destroy(GameObject.FindWithTag("Key1"));
            
        }
    }
}
