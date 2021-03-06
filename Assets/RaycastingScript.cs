using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastingScript : MonoBehaviour
{
    [SerializeField] private Object holdPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Press Space to fire. If there's nothing between the center (right in front of the camera), the raycast will hit the target in the back and activate.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 origin = new Vector3(0, 3, 0);
            Vector3 direction = new Vector3(0, 0, 1);
            bool rayHit = Physics.Raycast(origin, direction, 100f);
            if (rayHit == true)
            {
                Object obj = Object.Instantiate(holdPrefab);
                GameObject gameObj = (GameObject)obj;
                Vector3 vector = gameObj.transform.position;
                vector.x = 0;
                vector.y = 10;
                vector.z = 45;
                gameObj.transform.position = vector;
            }
        }
    }
}
