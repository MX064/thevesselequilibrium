using System.Collections;
using UnityEngine;

public class Nyraconversation : MonoBehaviour
{
    public Transform Shader;
    public Transform Nyra;
    private bool hasPlayed = false;

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
        Debug.Log("Nyra: Hey there, you dont seem like youre here to drink");
        yield return new WaitForSeconds(2f);
        Debug.Log("Shader: No");
        yield return new WaitForSeconds(2f);
        Debug.Log("Nyra: Then either youre lost, or looking for something");
        yield return new WaitForSeconds(2f);
        Debug.Log("Shader: I'm looking for information");
        yield return new WaitForSeconds(4f);
        Debug.Log("Nyra: That depends on what you think is worth knowing");
        yield return new WaitForSeconds(2f);
        Debug.Log("Shader: The Vessel");
        yield return new WaitForSeconds(1f);
        Debug.Log("Nyra: Ssssh, People dont just say that out loud!");
        yield return new WaitForSeconds(1.5f);
        Debug.Log("Nyra: Not unless theyre desparate");
        yield return new WaitForSeconds(1f);
        Debug.Log("Nyra: ...or stupid");
        yield return new WaitForSeconds(2f);
        Debug.Log("Shader: Which one am I?");
        yield return new WaitForSeconds(2f);
        Debug.Log("Nyra: I haven't decided");
        yield return new WaitForSeconds(2f);
        Debug.Log("Nyra: A group came through earlier. Call themselves the Bare Serpents.");
        yield return new WaitForSeconds(2f);
        Debug.Log("Nyra: They Armed. Nervous. Talking like they had something reliable on what youre looking for");
        yield return new WaitForSeconds(2f);
        Debug.Log("Shader: Where?");
        yield return new WaitForSeconds(2f);
        Debug.Log("Nyra: Back of the bar");
        yield return new WaitForSeconds(2f);
        Debug.Log("Nyra: If they have a lead, you wont be the only one looking for it");
        yield return new WaitForSeconds(4f);
        Debug.Log("Nyra: You should ask yourself something first");
        yield return new WaitForSeconds(2f);
        Debug.Log("Shader: What is it?");
        yield return new WaitForSeconds(2f);
        Debug.Log("Nyra: ...What heppens if you find it?");
        yield return new WaitForSeconds(2f);
        Debug.Log("Shader : ...");

        yield return new WaitForSeconds(3f);
        Debug.Log("Go find the Bare Serpants, move rightwards to the back of the bar");

        Nyra.transform.position = new Vector3(-16, -13, 0);
    }

    void Update() { }
}
