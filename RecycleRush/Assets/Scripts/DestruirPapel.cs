using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPapel : MonoBehaviour
{


   
    private void OnCollisionEnter(Collision collision)
    {
   
       
        Debug.Log("Foi");
        switch (collision.gameObject.tag)
        {

            case "papel":
                Destroy(collision.gameObject);
                break;

            case "metal":
                Destroy(collision.gameObject);
                break;

            case "plastico":
                Destroy(collision.gameObject);
                break;

            case "vidro":
                Destroy(collision.gameObject);
                break;

            case "organico":
                Destroy(collision.gameObject);
                break;


        }
    }


}
