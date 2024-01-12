using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace TUSOM.Alpha.Phases.Games
{
    // this script controls the robot player on the navmesh
    public class RobotController : MonoBehaviour
    {
        [Header("Controller Scripts")]
        public CharacterController charControl;
        public bool canPlayerMove;
      
        public Camera mainCam; // declare camera to store our camera from the inspector
        public Vector3 currentPostition; // a vector 3 to hold the players current position - for the navemesh
                                         // public Vector3 transBrickposition;
        public Ray cameraRay; // public ray to detect when the player is over ground/brick etc
        RaycastHit cameraRayHit; // raycasthit to detect when the ray has hit something
        RaycastHit hit; // = Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition));
        public Vector3 velocity; // instantiate a vector3 called velocity, to move the player down, to simulate gravity

        private float move, movespeed, rotation, rotatespeed;


        void Start()
        {
        //    agent = GetComponent<NavMeshAgent>(); // get NavMeshAgent component and apply it to agent .. this is redundant, we have set it in the inspector 
            canPlayerMove = true;
            movespeed = 5f;
            rotatespeed = 100f;
          
        }

        // Update is called once per frame
        void Update()
        {

            move = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
            rotation = Input.GetAxis("Horizontal") * rotatespeed * Time.deltaTime;
           
            
              if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject()) // on mouse click
                  {
                      Ray position = mainCam.ScreenPointToRay(Input.mousePosition); // new RAY decalred as position and is set to the mouse position called once per frame
                      RaycastHit hitInfo; // get a raycast variable to detect what we hit

                      if (Physics.Raycast(position, out hitInfo, 100f)) // if the raycast from position hits in distance of 100f
                      {
                          Debug.Log("We Hit: " + hitInfo.collider); // log the position it hits
                      }

                      Debug.Log(hit.collider); // log the collider it hits
                  }
            
        }
        private void LateUpdate()
        {
            transform.Translate(0f, 0f, move);
            transform.Rotate(0f, rotation, 0f);
        }
    }
}
