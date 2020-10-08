using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSpaceman : MonoBehaviour
{
    public GameObject spaceman;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(Camera.main.transform.position, spaceman.transform.position) < 50)
        {
            spaceman.GetComponent<Animator>().Play("Animation");
        }
        else
        {
            spaceman.GetComponent<Animator>().Play("Default State");
        }

    }
}
