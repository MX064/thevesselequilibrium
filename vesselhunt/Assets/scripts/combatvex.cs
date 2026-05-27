using System;
using TMPro;
using UnityEngine;


public class combatvex : MonoBehaviour
{
    public Transform shader2;
    [SerializeField] private GameObject marrowvex;
    public TextMeshProUGUI outputt;
    private float vexx;
    private float vexy;
    private float shadery;
    private float shaderx;
    private float vexhealth = 120;
    private float shaderhealth = 100;
    [SerializeField] private GameObject deathscreen;
    void Start()
    {
        shadery = shader2.position.y;
        shaderx = shader2.position.x;
    }

   
    void Update()
    {
        vexx = marrowvex.transform.position.x;
        vexy = marrowvex.transform.position.y;
        shadery = shader2.position.y; 
        shaderx = shader2.position.x; 

        if ((vexhealth > 0) && (shader2.transform.eulerAngles.z == 90))
        {
            if (Math.Abs(shaderx - vexx) < 8 && Math.Abs(shadery - vexy) < 8 && (vexy == -1.25f))
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    vexhealth -= 10;
                    shaderhealth -= 8.5f;
                    outputt.text = "Vex health = " + vexhealth + " Shader health = " + shaderhealth;
                }
                if (Input.GetKeyDown(KeyCode.H))
                {
                    shaderhealth += 5;
                    vexhealth += 7;
                    outputt.text = "Vex health = " + vexhealth + " Shader health = " + shaderhealth;
                }
                if (Input.GetKeyDown(KeyCode.S) && shaderhealth < 20)
                {
                    shaderhealth -= 10;
                    vexhealth -= 25;
                    outputt.text = "Critical hit! Vex health = " + vexhealth + " Shader health = " + shaderhealth;
                }
            }
        }

        if (vexhealth <= 0) 
        {
            marrowvex.GetComponent<SpriteRenderer>().color = Color.red;
            marrowvex.transform.position = new Vector3(vexx, -2, marrowvex.transform.position.z);
        }

        if (shaderhealth <= 0) 
        {
            shader2.GetComponent<SpriteRenderer>().color = Color.red;
            deathscreen.SetActive(true);
        }
    }
}
