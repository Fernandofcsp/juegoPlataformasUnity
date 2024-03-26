using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstadoJuego : MonoBehaviour
{
    public static int Score;
    public static float hp, maxHp = 120f;
    public static float timeLeft = 300f;
    public static int Score2;
    public static Text TextScore2;

    public static EstadoJuego estadoJuego;

    void Awake(){
        if(estadoJuego==null){
            Score2=Score;
            estadoJuego = this;
            DontDestroyOnLoad(gameObject);
        }else if(estadoJuego!=this){
            Destroy(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
    if(hp<=0){
        hp=maxHp;}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
