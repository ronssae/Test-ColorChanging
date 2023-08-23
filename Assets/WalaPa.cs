using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalaPa : MonoBehaviour
{
    public List<Color> color;
    public MeshRenderer meshrenderer;
    public float delaytime;


    // Start is called before the first frame update
    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        //for (int i = 0; i < color.Count; i++) 
        //{
        //    meshrenderer.material.color = color[Random.Range(0, color.Count)];
        //}
    }
    private void OnEnable()
    {
        //ChangeColor();
    }
    private void OnDisable()
    {
        //ChangeColor();
    }
    private void OnMouseUpAsButton()
    {
        //ChangeColor();
    }
    private void OnMouseDown()
    {
        //Invoke("ChangeColor", 0.0001f);
    }
    private void OnMouseEnter()
    {
        //ChangeColor();
    }
    private void OnMouseExit()
    {
        //ChangeColor();
    }
    private void OnMouseOver()
    {
        //Invoke("ChangeColor", delaytime);
        InvokeRepeating("ChangeColor", 0, 0);
    }
    private void OnMouseDrag()
    {
        //ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Fixed Update is called 50 calls per second
    void FixedUpdate()
    {
        
    }
    //Late Update is the last one to be called
    void LateUpdate()
    {
        
    }

    public void ChangeColor()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshrenderer.material.color = color[Random.Range(0, color.Count)];
        }
    }
}
