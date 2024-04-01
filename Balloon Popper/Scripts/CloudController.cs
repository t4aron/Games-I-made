using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloudController : MonoBehaviour
{
    public float sideSpeed = 0;
    public float upSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 4.5)
        {
            // Reset cloud's position to the beginning
            transform.position = new Vector3(-4.5f, 0, 0);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(sideSpeed, upSpeed, 0);
    }
}
