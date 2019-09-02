using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] bool isCollide;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isCollide = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnCollisionStay(Collision collision)
    {
        isCollide = true;
        if (collision.gameObject.tag == "Player")
        {
            Vector3 forceVec = new Vector3(10.0f, 500.0f, 0.0f);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(forceVec);
            }
        }
    }
}
