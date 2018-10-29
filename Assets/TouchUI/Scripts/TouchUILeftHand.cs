using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TouchUI
{
    public class TouchUILeftHand : MonoBehaviour
    {

        public static TouchUILeftHand Instance;

        void Awake()
        {
            Instance = this;
        }
    }
}
