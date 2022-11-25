using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private PlayerMovement player;
    [SerializeField] public Text scoreText;
    

   

    float i = 0;

    private void Start()
    {
        player.Point += Score;
        scoreText = gameObject.GetComponent<Text>();
        
        
    }
    
    void Score()
    {
        i += 1;
        //Debug.Log("Score = 1");
        //Destroy(gameObject);
        scoreText.text = i.ToString();
    }
    

    private void OnDisable()
    {
        player.Point -= Score;
    }
}
