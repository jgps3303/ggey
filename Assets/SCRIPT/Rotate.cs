using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    public void Rotate180()
    {
        // print("true");
        StartCoroutine("RotateAround");
    }
    IEnumerator RotateAround()
    {
        while(gameObject.transform.rotation.z>=0)
        {
            transform.Rotate(Vector3.back*speed*Time.deltaTime);
            yield return null;
        }
        yield return null;
    }
}
