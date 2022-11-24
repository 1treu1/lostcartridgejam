using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapeDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private PlayerMovement player;
    private void Start()
    {
        player.Point += Score;
    }

    void Score()
    {
        Debug.Log("Score = 1");
        Destroy(gameObject);
    }
   

    private void OnDisable()
    {
        player.Point -= Score;
    }
}
