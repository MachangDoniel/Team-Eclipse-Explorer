using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator animator;

   
    public void SetAnimator(GameObject g)
    {
        animator = g.transform.GetChild(0).GetComponent<Animator>();
        print("Animation is set");
    }

    public void StopAnim()
    {
        if (animator != null) { print("Animation stop"); animator.speed = 0; }
        
    }
    public void ResumeAnim()
    {
        if (animator != null) { animator.speed = 1; }
       
    }
}
