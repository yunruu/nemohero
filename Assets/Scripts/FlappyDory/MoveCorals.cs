using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCorals : MonoBehaviour
{
    private float speed = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
