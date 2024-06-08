using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerchange : MonoBehaviour
{
    public PlayerControler playerController;
    public PlayerControler player2Controller;
    private bool player1Active = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SwitchPlayer();
        }
    }
    public void SwitchPlayer()
    {
        if (player1Active)
        {
            playerController.enabled = false;
            player2Controller.enabled = true;
            player1Active = false;
        }
        else
        {
            playerController.enabled = true;
            player2Controller.enabled = false;
            player1Active = true;
        }
    }
}

