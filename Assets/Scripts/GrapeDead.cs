using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(PlayerMovement))]
public class GrapeDead : MonoBehaviour
{
    [SerializeField] private PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        //player.Grape += GrapeDestroy;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
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
