using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DashMove.Scripts
{

    public class CharacterMove : MonoBehaviour
    {
        public float DashForce;
        public float StartDashTimer;
        float currentDashTimer;
        float dashDirection;
        bool isDashing;
        new Rigidbody2D rigidbody2D;
        float localScaleY;
        [SerializeField] float characterSpeed = 0f;
        [SerializeField] float DashSpeed = 5f;
        int direction;
        //How much time the character move
        float horizontal;
        float vertical;
        
 




        private void Awake()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();

        }

        private void Start()
        {

            localScaleY = transform.localScale.y;
        }

        private void FixedUpdate()
        {

            horizontal = Input.GetAxis("Horizontal");

            vertical = Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, vertical * characterSpeed, 0);
                if (Input.GetKeyDown(KeyCode.O)) // tek seferlik yakalama i�in getkeydown
                {
                    direction = 0;
                    dashFunction();


                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.localScale = new Vector3(-localScaleY, transform.localScale.y, transform.localScale.z);
                transform.position += new Vector3(horizontal * characterSpeed, 0, 0);

                if (Input.GetKeyDown(KeyCode.O)) // tek seferlik yakalama i�in getkeydown
                {
                    direction = 1;
                    dashFunction();


                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, vertical * characterSpeed, 0);
                if (Input.GetKeyDown(KeyCode.O)) // tek seferlik yakalama i�in getkeydown
                {
                    direction = 2;
                    dashFunction();


                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.localScale = new Vector3(localScaleY, transform.localScale.y, transform.localScale.z);
                transform.position += new Vector3(horizontal * characterSpeed, 0, 0);
                if (Input.GetKeyDown(KeyCode.O)) // tek seferlik yakalama i�in getkeydown
                {
                    direction = 3;
                    dashFunction();


                }
            }





        }
        public void dashFunction()
        {
            if (direction == 0)
            {



                transform.position += new Vector3(0, vertical * characterSpeed*DashSpeed, 0);


            }
            if (direction == 1)
            {
               
                
                
                    transform.position += new Vector3(horizontal * characterSpeed * DashSpeed, 0, 0);
                
            }
            
            if (direction == 2)
            {


                transform.position += new Vector3(0, vertical * characterSpeed*DashSpeed, 0);


            }
            if (direction == 3)
            {



                transform.position += new Vector3(horizontal * characterSpeed*DashSpeed, 0, 0);

            }
        }




    }

    

}
