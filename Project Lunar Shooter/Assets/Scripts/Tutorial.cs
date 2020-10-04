using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text tutorialText;
    public static bool tutorialOver;
    // Start is called before the first frame update
    void Start()
    {
        tutorialOver = false;
        StartCoroutine(TutorialFunction());
    }

    IEnumerator TutorialFunction()
    {
        tutorialText.text = "Welcome to Lunar Shooter! We hope you'll enjoy yourself while you play our game.";

        yield return new WaitForSeconds(5);

        tutorialText.text = "We'll start with tutorial to help you understand the game a little better.";

        yield return new WaitForSeconds(5);

        tutorialText.text = "Press A to move left and D to move left.";

        while (!Input.GetKeyDown(KeyCode.A))
        {
             yield return null;
        }
        while (!Input.GetKeyDown(KeyCode.D))
        {
             yield return null;
        }

        tutorialText.text = "";
        tutorialOver = true;

        yield break;
    }
}
