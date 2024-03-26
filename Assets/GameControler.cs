using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{

    public string ScoreString = "Score";


    public Text TextScore;

    public static GameControler Gamecontroller;

    void Awake() {
        Gamecontroller = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TextScore!= null){
            TextScore.text = ScoreString + EstadoJuego.Score.ToString();
        }
    }

}
