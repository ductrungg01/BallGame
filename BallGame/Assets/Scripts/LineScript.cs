using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
    public float moveSpeed;
    float xDirection;

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");

        Debug.Log(xDirection);

        float moveStep = moveSpeed * Time.deltaTime * xDirection;
        transform.position += new Vector3(moveStep, 0, 0);
    }
}
