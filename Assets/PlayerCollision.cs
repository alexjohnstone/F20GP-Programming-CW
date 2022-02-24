using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System; 
using System.Reflection;
using System.Collections;


public class PlayerCollision : MonoBehaviour {
    float time = 2.5f;              


    IEnumerator OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")                   // conditional statement that uses collider tag "obstacle" to excecute the body 
        {
        print ("you lose");                                             
        yield return new WaitForSeconds(time);                          // time delay to allow time between the print statement and the level restart 
        ClearLog();                                                     // clear log function to remove the log for the next instance of the game 
        SceneManager.LoadScene( SceneManager.GetActiveScene().name);    // relaod scene 
        // FindObjectOfType<winLose>().Lose();
        }
        else if (collisionInfo.collider.tag == "END")                   // conditional statement that uses collider tag "END" to excecute the body
        {
        print("you win");                                              
        yield return new WaitForSeconds(time);
        ClearLog();
        SceneManager.LoadScene( SceneManager.GetActiveScene().name);
        }
    }
    //clear log function to remove the log 
    public void ClearLog() 
    {
    var assembly = Assembly.GetAssembly(typeof(UnityEditor.Editor));
    var type = assembly.GetType("UnityEditor.LogEntries");
    var method = type.GetMethod("Clear");
    method.Invoke(new object(), null);
    }
}