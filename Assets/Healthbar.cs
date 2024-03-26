using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
    public Image health;



    // Start is called before the first frame update
    void Start()
    {

    }

    public void TakeDamage(float amount){
        EstadoJuego.hp = Mathf.Clamp(EstadoJuego.hp-amount, 0f, EstadoJuego.maxHp);
        health.transform.localScale = new Vector2(EstadoJuego.hp/EstadoJuego.maxHp, 1);
        if (EstadoJuego.hp<=0){

        EstadoJuego.Score = 0;
        EstadoJuego.timeLeft = 300f;
        SceneManager.LoadScene("GameOver");
        }
    }

}
