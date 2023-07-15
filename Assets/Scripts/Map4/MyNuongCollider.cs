using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MyNuongCollider : MonoBehaviour
{
    int a = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet2")
        {
            a -= 1;

            if (a == 0)
            {
                Destroy(gameObject);
                Destroy(GameObject.FindGameObjectWithTag("Play2"));
                /*Time.timeScale = 0;*/
                SceneManager.LoadScene(7);
            }
            
        }
        if (collision.gameObject.tag == "bullet")
        {
            a -= 1;

            if (a == 0)
            {
                Destroy(gameObject);
                Destroy(GameObject.FindGameObjectWithTag("Player"));
                SceneManager.LoadScene(8);
            }
        }
    }
}
