using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inilemondrop : MonoBehaviour
{
    float currentTime;
    [SerializeField] float rate;
    float nextTime;

    [SerializeField] GameObject instObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime>nextTime)
        {
            GameObject instanobj =  Instantiate(instObject, gameObject.transform.position, Quaternion.identity);
            nextTime += rate;
            Destroy(instanobj, 2.5f);
        }

    }
}
