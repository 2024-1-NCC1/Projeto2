using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{

    public float PontosValue = 0;
    public Text PontosText;
    
    void Start()
    {
        
    }

 
    void Update()
    {
        PontosValue = PontosValue * Time.deltaTime;
    }
}
