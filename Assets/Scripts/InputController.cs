using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    private AnimationController animationController;
    private GameplayController gameplayController;

    private string playersChoice;

    private void Awake()
    {
        animationController = GetComponent<AnimationController>();
        gameplayController = GetComponent<GameplayController>();
    }
    public void GetChoice()
    {
        string choiceName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        GameChoices selectedChoice = GameChoices.NONE;
        switch (choiceName)
        {
            case "Rock":
                selectedChoice = GameChoices.ROCK;
                break;

            case "Paper":
                selectedChoice = GameChoices.PAPER;
                break;

            case "Scissors":
                selectedChoice = GameChoices.SCISSORS; 
                break;

        }
        gameplayController.SetChoices(selectedChoice);
        animationController.PlayerMadeChoice();
    }
}
