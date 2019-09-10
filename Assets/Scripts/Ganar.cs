using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganar : MonoBehaviour
{
    public float radio;
    float distance;

    public GameObject agent;



    void Update()
    {
        if(agent != null)
        {
            distance = ( agent.transform.position - transform.position).magnitude;
        }


        if(distance<radio)
        {
            Debug.Log("Ganastes GAAAAAAAAA");
            SceneManager.LoadScene("SampleScene");
        }



    }


        void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radio);
    }
}
