using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Parallax.Canvas
{
    public class ParallaxCanvasLayer : MonoBehaviour
    {
        public RectTransform startRTf;
        public RectTransform endRTf;

        [Range(0f, 100f)]
        public float speed;

        public List<Image> imgBackgrounds;
        //-------------------------------------------------
        private Vector2 startPoint { get { return startRTf.anchoredPosition; } }
        private Vector2 endPoint { get { return endRTf.anchoredPosition; } }

        public void Move()
        {
            foreach (var img in imgBackgrounds)
            {
                var newPosition = img.rectTransform.anchoredPosition + new Vector2(speed, 0f);
                img.rectTransform.anchoredPosition = newPosition;
                if (img.rectTransform.anchoredPosition.x >= endPoint.x)
                    img.rectTransform.anchoredPosition = startPoint;
            }
        }
    }
}
