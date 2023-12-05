using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.EventSystems;
using UnityEngine;

namespace MyFirstPlugin.UI
{
    public class WindowDragHandler : MonoBehaviour
    {
        public static WindowDragHandler instance;

        private const int NON_EXISTING_TOUCH = -98456;

        private static RectTransform rectTransform;

        private static int pointerId = NON_EXISTING_TOUCH;
        private static Vector2 initialTouchPos;

        public WindowDragHandler(IntPtr ptr) : base(ptr)
        {
            instance = this;
        }

        public void Awake()
        {
            Plugin.log.LogMessage("      WindowsDragHandler Awake()");
            rectTransform = gameObject.GetComponent<RectTransform>();
        }

        [HarmonyPostfix]
        public static void OnBeginDrag(PointerEventData eventData)
        {
            Plugin.log.LogMessage("WindowsDragHandler OnBeginDrag()");

            if (pointerId != NON_EXISTING_TOUCH)
            {
                eventData.pointerDrag = null;
                return;
            }
            //BepInExLoader.log.LogMessage(eventData);
            pointerId = eventData.pointerId;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, Camera.current, out initialTouchPos);
        }

        [HarmonyPostfix]
        public static void OnDrag(PointerEventData eventData)
        {
            //BepInExLoader.log.LogMessage("WindowsDragHandler OnDrag()");

            // This is odd... On first drag, it doesn't appear to move. The more you drag the panel, the better the dragging works. ???

            if (eventData.pointerId != pointerId)
                return;

            Vector2 touchPos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, Camera.current, out touchPos);

            // This is better, but mouse needs clamping
            var tmp = touchPos - initialTouchPos;
            rectTransform.gameObject.transform.position += new Vector3(tmp.x, tmp.y);
        }

        [HarmonyPostfix]
        public static void OnEndDrag(PointerEventData eventData)
        {

            if (eventData.pointerId != pointerId)
                return;

            pointerId = NON_EXISTING_TOUCH;
        }

    }
}
