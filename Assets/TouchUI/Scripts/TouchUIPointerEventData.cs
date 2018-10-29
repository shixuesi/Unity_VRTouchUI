using System;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TouchUI
{

    public class TouchUIPointerEventData : PointerEventData
    {
        public enum HandType { None,LeftHand,RightHand}
        public TouchUIPointerEventData(EventSystem eventSystem)
            : base(eventSystem)
        {

        }

        //public Ray worldSpaceRay;
        public Vector3 pointerPos;

        public HandType handType = HandType.None;
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<b>Position</b>: " + position);
            sb.AppendLine("<b>delta</b>: " + delta);
            sb.AppendLine("<b>eligibleForClick</b>: " + eligibleForClick);
            sb.AppendLine("<b>pointerEnter</b>: " + pointerEnter);
            sb.AppendLine("<b>pointerPress</b>: " + pointerPress);
            sb.AppendLine("<b>lastPointerPress</b>: " + lastPress);
            sb.AppendLine("<b>pointerDrag</b>: " + pointerDrag);
            sb.AppendLine("<b>pointerPos</b>: " + pointerPos);
            sb.AppendLine("<b>Use Drag Threshold</b>: " + useDragThreshold);
            return sb.ToString();
        }

    }
}
