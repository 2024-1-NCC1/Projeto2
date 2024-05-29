using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirMetal : MonoBehaviour
{
    public string tipo;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == tipo)
        {
            ScoreManager.instance.AddScore(10);
        }
        else
        {
            ScoreManager.instance.MinusScore(5);
        }
    }
}