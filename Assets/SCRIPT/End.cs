using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<LiquColider>().con[1] = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        other.GetComponent<LiquColider>().con[1] = false;
    }
}
