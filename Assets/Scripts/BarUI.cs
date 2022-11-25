using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarUI : MonoBehaviour
{
    [SerializeField] private PlayerMovement player;
    public float timeBarPower = 30;
    private float timer;
    private Image barPower;
    // Start is called before the first frame update
    void Start()
    {
        barPower = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        TimeGame();
    }
    void TimeGame()
    {
        if (player.isGame)
        {
            player.time += Time.deltaTime;
            timer = 30 - (int)(player.time % 60);

            barPower.fillAmount = timer / timeBarPower;

            Debug.Log((int)(barPower.fillAmount));
        }
    }
}
