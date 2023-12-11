using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionObj : MonoBehaviour
{
    public Animator Animator;
    public AnimationClip ShowAnim;
    public AnimationClip HideAnim;

    private void Awake()
    {
        PlayShow();
    }

    public void PlayShow()
    {
        Animator.Play(ShowAnim.name);
    }

    public void PlayHide()
    {
        Animator.Play(HideAnim.name);
    }
}
