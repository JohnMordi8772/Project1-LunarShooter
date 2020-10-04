using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text tutorialText;
    public static bool tutorialOver = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TutorialFunction());
    }

    IEnumerator TutorialFunction()
    {
        tutorialText.text = "Welcome to Lunar Shooter! We hope you'll enjoy yourself while you play our game.";

        yield return new WaitForSeconds(3);

        tutorialText.text = "We'll start with tutorial to help you understand the game a little better.";

        yield return new WaitForSeconds(3);//5 for real 3 for testing

        tutorialText.text = "Press A to move left and D to move right.";

        while (!Input.GetKeyDown(KeyCode.A))
        {
             yield return null;
        }
        while (!Input.GetKeyDown(KeyCode.D))
        {
             yield return null;
        }

        tutorialText.text = "Good job! You might have noticed that Action Points has decreased by 2. This is because everything you do has some kind of cost." +
            " Movement/A and D cost 1 Action Point or AP. Although, movement isn't the only thing you can do.";

        yield return new WaitForSeconds(7);

        tutorialText.text = "Press Q to fire a projectile that will deal three damage to the first enemy it hits.";

        while(!Input.GetKeyDown(KeyCode.Q))
        {
            yield return null;
        }


        tutorialText.text = "Now, press W to fire projectiles in all adjacent columns that deal 1 damage each to the first enemy they hit.";

        while(!Input.GetKeyDown(KeyCode.W))
        {
            yield return null;
        }

        tutorialText.text = "Finally, press E to fire a projectile that will pierce through all enemies in your current column dealing 1 damage to each enemy it hits.";

        while (!Input.GetKeyDown(KeyCode.E))
        {
            yield return null;
        }

        tutorialText.text = "";
        tutorialOver = true;

        yield break;
    }
}
