using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class synopsis : MonoBehaviour
{
    public Transform Shader;
    public TextMeshProUGUI outputt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Sequence());

    }


    IEnumerator Sequence()
    {
        outputt.text="The world didnt fall in a day";
        yield return new WaitForSeconds(4.5f);
        outputt.text="It rotted. Quietly and slowly.";
        yield return new WaitForSeconds(2.5f);
        outputt.text="Systems failed. People followed.";
        yield return new WaitForSeconds(2.5f);
        outputt.text="Now what's left...fight over what remains.";
        yield return new WaitForSeconds(4f);
        outputt.text="Some believe it can be fixed";
        yield return new WaitForSeconds(2.5f);
        outputt.text="Others don't.";
        yield return new WaitForSeconds(4f);
        outputt.text="THE VESSEL";
        yield return new WaitForSeconds(3f);
        outputt.text="Welcome to Vessel Hunt: The Equilibrium.";
        yield return new WaitForSeconds(2f);
        outputt.text="Press W to move up; A to move left; D to move right; S to move down.";
        yield return new WaitForSeconds(2f);
        outputt.text="Go into the bar and talk to Nyra, who is dressed in white.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
