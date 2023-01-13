using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reload : MonoBehaviour
{
    [SerializeField] GameObject[] mainChar;
    // Start is called before the first frame update
    void Start()
    {
        mainChar[0] = FindObjectsOfType<LiquMove>()[0].gameObject;
        mainChar[1] = FindObjectsOfType<LiquMove>()[1].gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(mainChar[0]== false||mainChar[1]== false)
        {
            ReLoadScene();
        }

    }
    public void ReLoadScene()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

}
