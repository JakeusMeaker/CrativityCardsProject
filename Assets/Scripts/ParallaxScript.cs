using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScript : MonoBehaviour
{
    public float textureSpeed;
    
    public GameObject background;
    
    public Renderer backgroundRender;
    
    private void Start()
    {
        backgroundRender = background.GetComponent<Renderer>();
     
    }

    private void LateUpdate()
    {
        backgroundRender.material.mainTextureOffset = new Vector2(Time.time * textureSpeed, 0f);
        
    }
}
