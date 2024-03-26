using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class COLISION : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.CompareTag("Player")){
            EstadoJuego.Score += 1000;
            SceneManager.LoadScene("Game2");

        }

    }
}
