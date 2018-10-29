using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TouchUI
{
    public class TouchUIRightHand : MonoBehaviour
    {

        public static TouchUIRightHand Instance;

        void Awake()
        {
            Instance = this;
        }
    }
}
