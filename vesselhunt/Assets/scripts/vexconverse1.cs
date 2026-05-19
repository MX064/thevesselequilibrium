using TMPro;
using UnityEngine;
using System.Collections;

public class vexconverse1 : MonoBehaviour
{
    public Transform shader2;
    public Transform vex;
    private bool hasPlayed = false;
    public TextMeshProUGUI outputt2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasPlayed)
        {
            hasPlayed = true;
            StartCoroutine(Sequence());
        }
    }

    IEnumerator Sequence()
    {
        outputt2.text = "Marrow Vex: Well what do we have here";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Shader: The Vessel. Where is it.";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Marrow Vex: Woah, slow down there";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Marrow Vex: What's your name, kid?";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Shader: Shader. And I'm not a kid.";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Marrow Vex: Shader huh. I hate people who's name starts with 'S'";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Marrow Vex: It's my least favourite letter";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Shader: Tell me where it is.";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Marrow Vex: ...You ever wondered where that Vessel came from? Or why?";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Shader: ...";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Marrow Vex: There once was a man. Manipulative, discrete, an inspirational villian.";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "Marrow Vex: They called him Red-Eyes";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "Marrow Vex: He's the reason the world's like this, he destroyed it";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "Marrow Vex: And I'm sure he'll stop at nothing to get the Vessel";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Marrow Vex: To make sure the world stays destroyed";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Marrow Vex: So why do you want it...";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Shader: ...";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Shader: Cut the time-wasting";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Marrow Vex: You're quite insolent. I should teach you a lesson";
        yield return new WaitForSeconds(3f);
        outputt2.text = "Shader: Fine. We'll do this the hard way.";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "Defeat Vex before he kills you. J to attack, H to heal";
        yield return new WaitForSeconds(3.5f);
        outputt2.text = "";

        vex.transform.position = new Vector3(vex.transform.position.x, -1.25f, vex.transform.position.z);
    }
}
