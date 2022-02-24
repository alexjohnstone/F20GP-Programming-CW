using UnityEngine;
using UnityEngine.AI;

public class PathPlanner : MonoBehaviour
    
{   public Camera mainCamera;
    public NavMeshAgent player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<NavMeshAgent>();                                     
        player.speed = (float)10f;                                                 
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
