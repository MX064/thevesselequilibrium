
using System.Collections;
using TMPro;
using System;
using UnityEngine;

public class nyraaftervex : MonoBehaviour
{
    public Transform shader2;
    [SerializeField] private GameObject nyra2;
    public TextMeshProUGUI outputt;
    [SerializeField] private GameObject lvl3;
    private bool dialoguePlayed = false; 

    void Update()
    {
        if (nyra2.transform.position.y == 1 && !dialoguePlayed && Math.Abs(shader2.transform.position.x - nyra2.transform.position.x) < 6 && Math.Abs(shader2.transform.position.y - nyra2.transform.position.y) < 6)
        {
            dialoguePlayed = true; 
            StartCoroutine(Sequence());
        }
    }

    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(3f);
        outputt.text = "Nyra: Shader!";
        yield return new WaitForSeconds(3f);
        outputt.text = "Nyra: You actually defeated Marrow Vex";
        yield return new WaitForSeconds(3f);
        outputt.text = "*Shader looks at her and nods*";
        yield return new WaitForSeconds(3f);
        outputt.text = "Nyra: Are you going for the Vessel?!";
        yield return new WaitForSeconds(3f);
        outputt.text = "Shader: Perhaps";
        yield return new WaitForSeconds(3f);
        outputt.text = "Nyra: I know a quiet road to the PCGA headquaters";
        yield return new WaitForSeconds(3f);
        outputt.text = "Nyra: Oh Shader, we can fix the world!";
        yield return new WaitForSeconds(3f);
        outputt.text = "Nyra: Bring back the summers, reverse what that monster did";
        yield return new WaitForSeconds(3f);
        outputt.text = "Shader: ...Yes...reverse";
        yield return new WaitForSeconds(3f);
        outputt.text = "Nyra: You don't seem as enthusiastic as me";
        yield return new WaitForSeconds(3f);
        outputt.text = "Shader: I just wanna get it done, okay.";
        yield return new WaitForSeconds(3f);
        outputt.text = "*Nyra goes quiet and just looks at Shader*";
        yield return new WaitForSeconds(3f);
        yield return new WaitForSeconds(3f);
        outputt.text = "Level 2 passed";
        lvl3.SetActive(true);
    }
}
