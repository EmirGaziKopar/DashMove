using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DashMove.Controller
{
    public class PcInput : MonoBehaviour
    {

        public bool pressA => Input.GetKey(KeyCode.A);
        public bool pressS => Input.GetKey(KeyCode.S);
        public bool pressD => Input.GetKey(KeyCode.D);
        public bool pressW => Input.GetKey(KeyCode.W);

    }

}
