using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tolevel1 : MonoBehaviour
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
        if (collision.gameObject.name == "Player")
        {
            CompletelevelR();
        }
    }
    private void CompletelevelR()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
