using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarUI : MonoBehaviour
{
    
    private Image barPower;
    float time;

    //[SerializeField] public CherryDead cherry;
    public float timeBarPower = 7;
    private float timer;
    bool isCherry;
    // Start is called before the first frame update
    void OnEnable()
    {
        CherryDead.onCherryDead += IsCherry;
    }
    

    void Start()
    {
        barPower = gameObject.GetComponent<Image>();
        barPower.fillAmount = 0.01f;
        //isCherry = false;


    }
    void Update()
    {
        Debug.Log("Update"+isCherry);
        if (isCherry == true)
        {
            Debug.Log("Hola");
            TimeGame();
        }
    }

    void IsCherry()
    {
        Debug.Log("Evento Cherry Activado");
        isCherry = true;
    }
    void TimeGame()
    {
      
        barPower.fillAmount = 1;
        time += Time.deltaTime;
        timer = timeBarPower - (int)(time % 60);
        barPower.fillAmount = timer / timeBarPower;

        if (barPower.fillAmount <= 0)
        {
            barPower.fillAmount = 0.01f;
            timer = 0;
            time = 0;
            isCherry = false;
        }
    }

    private void OnDisable()
    {
        CherryDead.onCherryDead -= IsCherry;
    }



    // Update is called once per frame



}
