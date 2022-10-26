using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox_Script : MonoBehaviour
{
    //a public array of game objects
    public GameObject[] items;
    //a public int, representing which object in the array to spawn
    public int itemindexer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //check the tag of the thing that hit It. If its the player or the AI run the next line of code??
        if (other.tag == "Player")
        {
            //pick a random number using Random.Range() and store it in your int variable
            int itemindexer = Random.Range(0, 5);
            // instantiate? an object from the array, using your int as the index
            Instantiate(items[itemindexer], transform.position, Quaternion.identity);
            //deactivate this object using gameObject.SetActive()
            gameObject.SetActive(false);
            //invoke? the activator function
            Invoke("Reawaken", 10.0f);
        }
        
    }

    //create a function, that activates the gameObject again
    void Reawaken()
    {
        gameObject.SetActive(true);
    }
}
