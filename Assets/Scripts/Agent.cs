using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Agent : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;
    Vector3 desired = Vector3.zero;
    Vector3 steer= Vector3.zero;

    float maxSpeed=5;
    float maxSteer=15;

    Transform target;

   
   
   
    void Update()
    {
        target = GameObject.Find("Target").transform;
        desired = -(target.position - transform.position).normalized*maxSpeed;

        steer = Vector3.ClampMagnitude(desired-velocity, maxSteer);

        velocity += steer*Time.deltaTime;

        transform.position += velocity*Time.deltaTime;

        

        if (transform.position.x <-7 || transform.position.x>7 || transform.position.y>5 || transform.position.y<-5)
        {
            SceneManager.LoadScene("SampleScene");
            Debug.Log("Perdiste");
        }



    }
}
