using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 
    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        float CarVertical = Input.GetAxis("Vertical");

        //
        float CarHorizontal = Input.GetAxis("Horizontal");

        //
        transform.position = transform.position + new Vector3(0, 0, 0.4f) * CarVertical * speed;

        //
        transform.position = transform.position + new Vector3(0.2f,0,0) * CarHorizontal * speed;
    }
}
