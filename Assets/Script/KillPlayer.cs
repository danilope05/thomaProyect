using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    PlayerControler pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = Object.FindFirstObjectByType<PlayerControler>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player")) 
        {

            pc.ResetPosition();

        }



    }


}
