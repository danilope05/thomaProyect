using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmovement : MonoBehaviour
{
    public Transform [] Pose;
    public float speed;
    public int id;
    public int suma;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = Pose[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == Pose[id].position)
        {
            id += suma;
        }
        
        if (id == Pose.Length -1)
        {

            suma = -1;
        }
        if (id == 0)
        {
            suma = 1;

        }

        transform.position = Vector3.MoveTowards(transform.position, Pose[id].position, speed * Time.deltaTime);
           
    }

}
