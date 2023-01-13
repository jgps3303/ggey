using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatetop : MonoBehaviour
{
    [SerializeField]Transform point;
    [SerializeField] float speed;
    [SerializeField] GameObject[] child;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back*speed*Time.deltaTime);
    }
}
