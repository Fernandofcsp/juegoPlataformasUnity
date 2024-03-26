using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeLeftScript : MonoBehaviour
{
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text= GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        EstadoJuego.timeLeft-= Time.deltaTime;
        if(EstadoJuego.timeLeft<=0)
        SceneManager.LoadScene("GameOver");
        text.text= "Tiempo: " + Mathf.Round(EstadoJuego.timeLeft) + " Seg";
    }
}
