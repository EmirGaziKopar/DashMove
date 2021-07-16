using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DashMove.Scripts
{

    public class CharacterMove : MonoBehaviour
    {

        [SerializeField]TrailRenderer trailRenderer;
        new Rigidbody2D rigidbody2D;
        float localScaleY;
        [SerializeField] float characterSpeed = 0f;
        [SerializeField] float DashSpeed = 5f;
        int direction;
        //How much time the character move
        float horizontal;
        float vertical;
       [SerializeField] float EffectTime = 1f;
        float EffectTime2;
        bool control;
        


        private void Awake()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();

            trailRenderer = GetComponentInChildren<TrailRenderer>();

            EffectTime2 = EffectTime;

        }

        private void Start()
        {

            localScaleY = transform.localScale.y;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                control = true;
                EffectTime = EffectTime2;

            }
        }
        private void FixedUpdate()
        {


            




            if (control == true)
            {
                if (EffectTime > -0.2)
                {
                    EffectTime -= Time.deltaTime;
                    trailRenderer.emitting = true;

                }
                
                if (EffectTime < 0)
                {
                    trailRenderer.emitting = false;
                    
                }
            }

            horizontal = Input.GetAxis("Horizontal");

            vertical = Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, vertical * characterSpeed, 0);
                if (Input.GetMouseButton(0)) // tek seferlik yakalama için getkeydown
                {

                    direction = 0;
                    dashFunction();
                    



                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.localScale = new Vector3(-localScaleY, transform.localScale.y, transform.localScale.z);
                transform.position += new Vector3(horizontal * characterSpeed, 0, 0);

                if (Input.GetMouseButton(0)) // tek seferlik yakalama için getkeydown
                {
                    direction = 1;
                    dashFunction();
                    


                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, vertical * characterSpeed, 0);
                if (Input.GetMouseButton(0)) // tek seferlik yakalama için getkeydown
                {
                    direction = 2;
                    dashFunction();
                    


                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.localScale = new Vector3(localScaleY, transform.localScale.y, transform.localScale.z);
                transform.position += new Vector3(horizontal * characterSpeed, 0, 0);
                if (Input.GetMouseButton(0)) // tek seferlik yakalama için getkeydown
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



                if (EffectTime > 0)
                {
                    transform.position += new Vector3(0, vertical * characterSpeed * DashSpeed, 0);
                }
                
                


            }
            if (direction == 1)
            {


                if (EffectTime > 0)
                {
                    transform.position += new Vector3(horizontal * characterSpeed * DashSpeed, 0, 0);
                }
                    
                

            }
            
            if (direction == 2)
            {

                if(EffectTime > 0)
                {
                    transform.position += new Vector3(0, vertical * characterSpeed * DashSpeed, 0);
                }
                
                


            }
            if (direction == 3)
            {


                if(EffectTime > 0)
                {
                    transform.position += new Vector3(horizontal * characterSpeed * DashSpeed, 0, 0);
                }
               
                

            }
        }




    }

    

}

