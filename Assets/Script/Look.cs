using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{

   public GameObject Tomas;


    void Update()
    {
        Vector3 position = transform.position;
        position.x = Tomas.transform.position.x;
        transform.position = position;  


    }
}