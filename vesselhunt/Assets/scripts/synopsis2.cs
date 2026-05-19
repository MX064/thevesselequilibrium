using TMPro;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class synopsis2 : MonoBehaviour
{
    public Transform shader2;
    public TextMeshProUGUI outputt2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Sequence());

    }


    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(4.5f);
        outputt2.text = "Find Marrow Vex, the gang boss";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "Pay attention to what he says.";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "Defeat him.";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "You now have a special ability...";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "once your health decreases below 20";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "It is activated by a key press";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
