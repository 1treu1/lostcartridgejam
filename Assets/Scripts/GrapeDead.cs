using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(PlayerMovement))]
public class GrapeDead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //player.Grape += GrapeDestroy;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("PowerUp"))
        {
            


            Destroy(gameObject);
            //isCherry = true;

        }
    }
    void GrapeDestroy()
    {
        //Destroy(gameObject);
        
    }

    private void OnDisable()
    {
        //player.Grape -= GrapeDestroy;
    }
}
