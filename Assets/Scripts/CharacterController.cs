using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    Transform currentTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTransform = transform;
        if (Input.GetKey(KeyCode.W))
        {
            currentTransform.position = new Vector3(currentTransform.position.x, currentTransform.position.y, currentTransform.position.z + (speed * Time.deltaTime));
        }
        else
        {
            if (Input.GetKey(KeyCode.S))
            {
                currentTransform.position = new Vector3(currentTransform.position.x, currentTransform.position.y, currentTransform.position.z - (speed * Time.deltaTime));
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            currentTransform.position = new Vector3(currentTransform.position.x - (speed * Time.deltaTime), currentTransform.position.y, currentTransform.position.z);
        } else
        {
            if (Input.GetKey(KeyCode.D))
            {
                currentTransform.position = new Vector3(currentTransform.position.x + (speed * Time.deltaTime), currentTransform.position.y, currentTransform.position.z);
            }
        }
        

    }
}
