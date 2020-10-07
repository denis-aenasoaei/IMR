using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator animator = new Animator(); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s") && animator.GetCurrentAnimatorStateInfo(0).IsName("Default State"))
        {
            animator.Play("Animation");
        }
        else if (Input.GetKeyDown("s") && animator.GetCurrentAnimatorStateInfo(0).IsName("Animation"))
        {
            animator.Play("Default State");
        }
    }
}
