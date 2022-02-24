using UnityEngine;
using UnityEngine.AI;

public class PathPlanner : MonoBehaviour
    //declaring variables
{   public Camera mainCamera;
    public NavMeshAgent player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<NavMeshAgent>();                                     //setting the player as the navmeshagent
        player.speed = (float)10f;                                                 //setting the players speed to the set variable
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))                                             //setting the input as left arrow key
        {                                             
            Ray pointer = mainCamera.ScreenPointToRay(Input.mousePosition);         //setting the starting point of the ray to the mouse position
            RaycastHit position;                                                    //store location of where the raycast hit in in variable position

            if (Physics.Raycast(pointer, out position))                             //shoot the ray to the position stored in position 
            {                           
                player.SetDestination(position.point);                              //move the player to the location stored in position 
            }
        }
    }
}
