using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayformMove : MonoBehaviour , IMove
{
    bool top = false;

    [SerializeField] float topPosition;
    [SerializeField] float downPosition;
    public void Move()
    {
        StartCoroutine("MoveAround");
    }
    IEnumerator MoveAround()
    {
        while(true)
        {
            if(top)
            {
                while(gameObject.transform.position.y>=downPosition)
                {
                    transform.Translate(Vector3.down * Time.deltaTime*0.5f,Space.World);
                    yield return null;
                }
                top = false;
            }
            if(top == false)
            {
                while(gameObject.transform.position.y<=topPosition)
                {
                    transform.Translate(Vector3.up * Time.deltaTime*0.5f,Space.World);
                    yield return null;
                }
                top = true;
            }
            yield return null;
        }
        // yield return null;
    }

}
