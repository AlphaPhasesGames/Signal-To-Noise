using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    // this script controls the robot player on the navmesh
    public class RobotController : MonoBehaviour
    {
        [Header("Controller Scripts")]
        private CharacterController charControl;

        [SerializeField]
        private float moveSpeed;
        private float inputX;
        private float inputZ;
        private Vector3 v_movement;
        private Vector3 v_velocity;

        public Camera mainCam; // declare camera to store our camera from the inspector
        public Ray cameraRay; // public ray to detect when the player is over ground/brick etc
        RaycastHit cameraRayHit; // raycasthit to detect when the ray has hit something
        RaycastHit hit; // = Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition));

        private void Awake()
        {
            charControl = GetComponent<CharacterController>();
        }

        void Start()
        {
            moveSpeed = 5f;          
        }

        // Update is called once per frame
        void Update()
        {
            inputX = Input.GetAxis("Horizontal");
            inputZ = Input.GetAxis("Vertical");

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

        private void FixedUpdate()
        {
            v_movement = charControl.transform.forward * inputZ;
            charControl.transform.Rotate(Vector3.up * inputX * (100f * Time.deltaTime));

            charControl.Move(v_movement * moveSpeed * Time.deltaTime);
        }
    }
}
