/* Author: George Tang
 * Project: Project Lunar Shooter
 * Purpose: If the conditions are met load next scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//public class LoadNextScene : MonoBehaviour
//{
//    public Animator transition;

//    public float transitionTime = 1f;
//    // if conditions are met the next scene will load
//    void Update()
//    {
           // if win conditions are met then load next scene
//        if (WinLossManager.win)
//        {
//            LoadNextLevel();
//        }
//    }

//    public void LoadNextLevel()
//    {
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//    }

//    IEnumerator LoadLevel(int levelIndex)
//    {
//        //play animation
//        transition.SetTrigger("Start");
//        //wait
//        yield return new WaitForSeconds(transitionTime);
//        //load scene
//        SceneManager.LoadScene(levelIndex);
//    }
//}
