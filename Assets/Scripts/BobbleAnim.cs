using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobbleAnim : MonoBehaviour
{
    public Renderer rend;
    public float i = 0f;
    public double mml;

    private Animation anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim["First"].layer = 123;
    }
    

    public void Triggered()
    {
        Debug.Log("� �������");
            rend.material.color = new UnityEngine.Color(255f, i, 0f);
            i = i + 0.1f;
            mml=mml+0.97;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (anim.isPlaying)
            {
                return;
            }

            Debug.Log("Nice");
            anim.Play("First");
        }
    }

    void OnGUI()
    {
        if(mml>0)
        {
        string lox = "ml";
        int w= Screen.width, h = Screen.height;
        GUIStyle style = new GUIStyle();
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h*5/100;
        style.normal.textColor = Color.black;
        string text = mml.ToString() + lox;
        GUI.Label(new Rect(0,0,w,h*2/100),text,style);
        }
    }
}
