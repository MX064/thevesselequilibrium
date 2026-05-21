using UnityEngine;

public class direc : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public Transform shader2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            shader2.transform.rotation = Quaternion.Euler(shader2.transform.eulerAngles.x, shader2.transform.eulerAngles.y, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            shader2.transform.rotation = Quaternion.Euler(shader2.transform.eulerAngles.x, shader2.transform.eulerAngles.y, 90);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            shader2.transform.rotation = Quaternion.Euler(shader2.transform.eulerAngles.x, shader2.transform.eulerAngles.y, 180);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            shader2.transform.rotation = Quaternion.Euler(shader2.transform.eulerAngles.x, shader2.transform.eulerAngles.y, 270);
        }
    }
}
