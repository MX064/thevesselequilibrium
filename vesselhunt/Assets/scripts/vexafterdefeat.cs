
using System.Collections;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class vexafterdefeat : MonoBehaviour
{
    public Transform shader2;
    [SerializeField] private GameObject vex;
    [SerializeField] private GameObject nyra2;
    public TextMeshProUGUI outputt;
    private bool dialoguePlayed = false;

    void Update()
    {
        if (vex.transform.position.y == -2 && !dialoguePlayed)
        {
            dialoguePlayed = true;
            StartCoroutine(Sequence()); 
        }
    }

    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(3f);
        outputt.text = "Shader: S is my favourite letter";
        yield return new WaitForSeconds(3f);
        outputt.text = "Marrow Vex[groans in pain]";
        yield return new WaitForSeconds(3f);
        outputt.text = "Shader: Now talk";
        yield return new WaitForSeconds(3f);
        outputt.text = "Marrow Vex: The PCGA already have it";
        yield return new WaitForSeconds(2.5f);
        outputt.text = "Marrow Vex: Governments always find a way to keep everyone under control";
        yield return new WaitForSeconds(3f);
        outputt.text = "Shader: Where in their building?";
        yield return new WaitForSeconds(3f);
        outputt.text = "Marrow Vex: Its with the boss himself. ";
        yield return new WaitForSeconds(2.5f);
        outputt.text = "Marrow Vex: Near his office block in building 19";
        yield return new WaitForSeconds(3f);
        outputt.text = "Shader: Kael Draven... the bastard beat me to it";
        yield return new WaitForSeconds(3f);
        outputt.text = "*Shader is about to walk away*";
        yield return new WaitForSeconds(3f);
        outputt.text = "Marrow Vex: Wait, why does a kid want the Vessel so bad";
        yield return new WaitForSeconds(3f);
        outputt.text = "Shader: ...";
        yield return new WaitForSeconds(3f);
        outputt.text = "Shader: Maybe you ask who, rather than why";
        yield return new WaitForSeconds(3f);

        vex.transform.position = new Vector3(vex.transform.position.x, -2.2f, vex.transform.position.z);
        shader2.transform.rotation = Quaternion.Euler(shader2.transform.eulerAngles.x,shader2.transform.eulerAngles.y,270);
        vex.GetComponent<SpriteRenderer>().color = Color.maroon;
        nyra2.SetActive(true);
        nyra2.transform.position = new Vector3(nyra2.transform.position.x, 1, nyra2.transform.position.z);

    }
}

