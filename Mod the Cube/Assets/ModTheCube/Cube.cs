using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.8f, 0.4f, 0.9f, 1.0f);
    }
    
    void Update()
    {
        transform.Rotate(500.0f * Time.deltaTime, 500.0f, 500.0f);
    }
}
