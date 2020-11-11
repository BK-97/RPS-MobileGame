using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    [SerializeField]
    private Animator playerChoiceHandlerAnimation, choiceAnimation, readyAnimation;

    public void ResetAnimations(){
        playerChoiceHandlerAnimation.Play("ShowHandler");
        choiceAnimation.Play("RemoveChoices");
        readyAnimation.Play("readyback");
        
    }
    public void PlayerMadeChoice() {
        playerChoiceHandlerAnimation.Play("RemoveHandler");
        choiceAnimation.Play("ShowChoices");
        readyAnimation.Play("readygo");
    }
    public void Readyset()
    {
        readyAnimation.Play("readyanimation");
        
    }

}
