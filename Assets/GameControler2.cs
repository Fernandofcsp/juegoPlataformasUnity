using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler2 : MonoBehaviour
{

    public string ScoreString = "Score";
    public Text TextScore;
    public static GameControler2 Gamecontroller;

    void Awake() {
        Gamecontroller = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        TextScore.text = ScoreString + EstadoJuego.Score2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (TextScore!= null){
            TextScore.text = ScoreString + EstadoJuego.Score2.ToString();
        }
    }


    void LevelPass(int pnts){
        if (TextScore!= null){
            TextScore.text = ScoreString + EstadoJuego.Score2.ToString();

        }
    }
}