using System.Collections;
using System.Collections.Generic;
using UnityEditor.Graphs;
using UnityEngine;
using KartGame.KartSystems;

public class megabananapealslowitem : MonoBehaviour
{
    //public float variable for the slow speed
    public float slowSpeed = 5f;

    public ArcadeKart arcadeKart;

    private void Start()
    {
        arcadeKart = GetComponent<ArcadeKart>();
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Hit");
        if(col.gameObject.name == "harrison banana peal model final")
        {
            //use getcomponent to save the Arkadekart script in the Arkadekart variable
            arcadeKart.baseStats.TopSpeed = slowSpeed;
         


            Debug.Log("Hit Banana peal");
            Destroy(col.gameObject);
        }
    }
   
   
   
        
   
}
