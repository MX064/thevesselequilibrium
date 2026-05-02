using System;
using UnityEngine;

public class combat : MonoBehaviour
{
    public Transform Shader;
    [SerializeField] private GameObject goon1;
    [SerializeField] private GameObject goon2;
    [SerializeField] private GameObject goon3;
    [SerializeField] private GameObject goon4;

    [SerializeField] private GameObject Nyra;
    private float goon1x;
    private float goon1y;
    private float goon2y;
    private float goon2x;
    private float goon3y;
    private float goon3x;
    private float goon4x;
    private float goon4y;
    private float shadery;
    private float shaderx;
    private float Nyray;

    private int goon1health = 30;
    private int goon2health = 40;
    private int goon3health = 50;
    private int goon4health = 60;
    private int shaderhealth = 100;

    private int currentGoon = 0;
    private bool combatMessageShown = false;
    private bool combatStarted = false;

    private bool goon1active = false;
    private bool goon2active = false;
    private bool goon3active = false;
    private bool goon4active = false;

    void Start()
    {
        shadery = Shader.position.y;
        shaderx = Shader.position.x;
    }

    void Update()
    {
        Nyray = Nyra.transform.position.y;

        if (!combatStarted && Nyray <= -13.0f)
        {
            combatStarted = true;
            currentGoon = 1;
            goon1active = true;
            goon1x = goon1.transform.position.x;
            goon1y = goon1.transform.position.y;
            goon1.GetComponent<SpriteRenderer>().color = Color.black;
            Debug.Log("Travel rightwards to the goons and defeat them. Stay in your range to attack. Your range is 8 in x dimension and 8 in y dimension.");
        }

        if (currentGoon == 0) return;

        shadery = Shader.position.y;
        shaderx = Shader.position.x;

        if (currentGoon == 1)
        {
            if (Math.Abs(shaderx - goon1x) < 8 && Math.Abs(shadery - goon1y) < 8 && goon1active)
            {
                if (!combatMessageShown)
                {
                    Debug.Log("Press J to damage enemies. Press H to heal.");
                    combatMessageShown = true;
                }

                if (Input.GetKeyDown(KeyCode.J))
                {
                    goon1health -= 10;
                    shaderhealth -= 2;
                    Debug.Log("Goon 1 health = " + goon1health + " Shader health = " + shaderhealth);
                }
                if (Input.GetKeyDown(KeyCode.H))
                {
                    shaderhealth += 5;
                    goon1health += 1;
                    Debug.Log("Goon 1 health = " + goon1health + " Shader health = " + shaderhealth);
                }
            }

            if (goon1health < 1)
            {
                goon1active = false;
                goon1.GetComponent<SpriteRenderer>().color = Color.red;
                goon2active = true;
                goon2.GetComponent<SpriteRenderer>().color = Color.black;
                goon2x = goon2.transform.position.x;
                goon2y = goon2.transform.position.y;
                Debug.Log("Defeat goon 2");
                currentGoon = 2;
                combatMessageShown = false;
            }
        }

        else if (currentGoon == 2)
        {
            if (Math.Abs(shaderx - goon2x) < 8 && Math.Abs(shadery - goon2y) < 8 && goon2active)
            {
                if (!combatMessageShown)
                {
                    Debug.Log("Press J to damage enemies. Press H to heal.");
                    combatMessageShown = true;
                }

                if (Input.GetKeyDown(KeyCode.J))
                {
                    goon2health -= 10;
                    shaderhealth -= 2;
                    Debug.Log("Goon 2 health = " + goon2health + " Shader health = " + shaderhealth);
                }
                if (Input.GetKeyDown(KeyCode.H))
                {
                    shaderhealth += 5;
                    goon2health += 1;
                    Debug.Log("Goon 2 health = " + goon2health + " Shader health = " + shaderhealth);
                }
            }

            if (goon2health < 1)
            {
                goon2active = false;
                goon2.GetComponent<SpriteRenderer>().color = Color.red;
                goon3active = true;
                goon3.GetComponent<SpriteRenderer>().color = Color.black;
                goon3x = goon3.transform.position.x;
                goon3y = goon3.transform.position.y;
                Debug.Log("Defeat goon 3");
                currentGoon = 3;
                combatMessageShown = false;
            }
        }

        else if (currentGoon == 3)
        {
            if (Math.Abs(shaderx - goon3x) < 8 && Math.Abs(shadery - goon3y) < 8 && goon3active)
            {
                if (!combatMessageShown)
                {
                    Debug.Log("Press J to damage enemies. Press H to heal.");
                    combatMessageShown = true;
                }

                if (Input.GetKeyDown(KeyCode.J))
                {
                    goon3health -= 10;
                    shaderhealth -= 2;
                    Debug.Log("Goon 3 health = " + goon3health + " Shader health = " + shaderhealth);
                }
                if (Input.GetKeyDown(KeyCode.H))
                {
                    shaderhealth += 5;
                    goon3health += 1;
                    Debug.Log("Goon 3 health = " + goon3health + " Shader health = " + shaderhealth);
                }
            }

            if (goon3health < 1)
            {
                goon3active = false;
                goon3.GetComponent<SpriteRenderer>().color = Color.red;
                goon4active = true;
                goon4.GetComponent<SpriteRenderer>().color = Color.black;
                goon4x = goon4.transform.position.x;
                goon4y = goon4.transform.position.y;
                Debug.Log("Defeat goon 4");
                currentGoon = 4;
                combatMessageShown = false;
            }
        }

        else if (currentGoon == 4)
        {
            if (Math.Abs(shaderx - goon4x) < 8 && Math.Abs(shadery - goon4y) < 8 && goon4active)
            {
                if (!combatMessageShown)
                {
                    Debug.Log("Press J to damage enemies. Press H to heal.");
                    combatMessageShown = true;
                }

                if (Input.GetKeyDown(KeyCode.J))
                {
                    goon4health -= 10;
                    shaderhealth -= 2;
                    Debug.Log("Goon 4 health = " + goon4health + " Shader health = " + shaderhealth);
                }
                if (Input.GetKeyDown(KeyCode.H))
                {
                    shaderhealth += 5;
                    goon4health += 1;
                    Debug.Log("Goon 4 health = " + goon4health + " Shader health = " + shaderhealth);
                }
            }

            if (goon4health < 1)
            {
                goon4active = false;
                goon4.GetComponent<SpriteRenderer>().color = Color.red;
                Debug.Log("Shader: Now, take me to your leader.");
                Debug.Log("Goons all defeated. Level passed. You have suceeded...");
                Debug.Log("...for now");
                currentGoon = 0;
            }
        }
    }
}
