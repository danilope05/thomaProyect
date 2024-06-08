using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelpass : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {

            print("Switch level" + level);
            SceneManager.LoadScene(level, LoadSceneMode.Single);
        }
    }
}





