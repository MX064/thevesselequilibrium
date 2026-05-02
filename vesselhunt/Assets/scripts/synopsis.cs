using System.Collections;
using Unity.VisualScripting;
using UnityEngine;


public class synopsis : MonoBehaviour
{
    public Transform Shader;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Sequence());

    }


    IEnumerator Sequence()
    {
        Debug.Log("The world didnt fall in a day");
        yield return new WaitForSeconds(4.5f);
        Debug.Log("It rotted. Quietly and slowly.");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Systems failed. People followed.");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Now what's left...fight over what remains.");
        yield return new WaitForSeconds(4f);
        Debug.Log("Some believe it can be fixed");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Others don't.");
        yield return new WaitForSeconds(4f);
        Debug.Log("THE VESSEL");
        yield return new WaitForSeconds(3f);
        Debug.Log("Welcome to Vessel Hunt: The Equilibrium.");
        yield return new WaitForSeconds(2f);
        Debug.Log("Press W to move up; A to move left; D to move right; S to move down.");
        yield return new WaitForSeconds(2f);
        Debug.Log("Go into the bar and talk to Nyra, who is dressed in white.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
