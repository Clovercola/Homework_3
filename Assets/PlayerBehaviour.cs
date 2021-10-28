using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private Object prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Prevents you from infinitely falling off the cube I'm using as a floor.
        float prot = gameObject.transform.position.y;
        if (prot < -10f)
        {
            Vector3 fixPlayer = new Vector3(0, 5, 0);
            gameObject.transform.position = fixPlayer;
        }

        // Movement keys

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 vector = gameObject.transform.position;
            vector.x += 0.01f;
            gameObject.transform.position = vector;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 vector = gameObject.transform.position;
            vector.x -= 0.01f;
            gameObject.transform.position = vector;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 vector = gameObject.transform.position;
            vector.z -= 0.01f;
            gameObject.transform.position = vector;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Vector3 vector = gameObject.transform.position;
            vector.z += 0.01f;
            gameObject.transform.position = vector;
        }


    }

    //Trigger Collision method. Spawns boxes at 10y, 8 units above the player's spawn.

    private void OnTriggerEnter(Collider other)
    {
        Object obj = Object.Instantiate(prefab);
        GameObject gameObj = (GameObject) obj;
        Vector3 vector = gameObj.transform.position;
        vector.x = 0;
        vector.y = 10;
        vector.z = 0;
        gameObj.transform.position = vector;
    }

}
