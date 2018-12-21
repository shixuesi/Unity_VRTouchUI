using UnityEngine;
namespace TouchUI
{
    /// <summary>
    /// 触发和点击距离 设置脚本
    /// </summary>
    public class TouchLimit : MonoBehaviour
    {

        public float clickDis;//触发点击距离
        public float triggerDis;// 触发/响应距离

        public bool isTouched(float handDistance)
        {
            return handDistance <= triggerDis;
        }

        bool isDown;
        public bool isPressed(float dis)
        {
            if (dis < clickDis)
            {
                if (isDown)
                    return false;

                isDown = true;
                return true;
            }
            return false;
        }

        public bool isReleased(float dis)
        {
            if (dis >= clickDis)
            {
                if (!isDown)
                    return false;

                isDown = false;
                return true;
            }
            return false;
        }

        void OnValidate()//在编辑中辅助修改TouchLimit物体的位置
        {
            //默认只计算Canvas的Scale
            Canvas [] canvas = GetComponentsInParent<Canvas>();

            if (canvas != null && canvas.Length > 0)
            {
                float scale = 1;
                foreach (var item in canvas)
                {
                    scale *= item.transform.localScale.z;
                }
                transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, clickDis / scale);
            }
        }
        

    }
}
