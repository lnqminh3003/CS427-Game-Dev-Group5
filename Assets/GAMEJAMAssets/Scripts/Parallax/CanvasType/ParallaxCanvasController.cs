using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace Parallax.Canvas
{
    public class ParallaxCanvasController : MonoBehaviour
    {
        List<ParallaxCanvasLayer> layers;
        private void Start()
        {
            layers = GetComponentsInChildren<ParallaxCanvasLayer>().ToList();
        }

        private void FixedUpdate()
        {
            foreach (var layer in layers)
            {
                layer.Move();
            }
        }
    }
}
