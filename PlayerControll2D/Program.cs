using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerControll2D
{
    class PlayerController2D : MonoBehaviour
    {
        /*Use CharacterController2D*/
        public CharacterController controller;
        public float horizontalMove = 0f;
        public float runSpeed = 40f;
        bool jump = false;
        bool crouch = false;

        void Start()
        {

        }

        void Updade()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            if (Input.GetButtonDown("Jump"))
            {
                
                jump = true;
            }

            if (Input.GetButtonDown("Crouch"))
            {
                crouch = true;
            }
            else if (Input.GetButtonUp("Crouch"))
            {
                crouch = false;
            }
        }

        void FixedUpdate()
        {
            //Move Player
            controller.Move(horizontalMove * Time.deltaTime, crouch, jump);
            jump = false;
        }
    }
}
