using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform sphereTransform;

    private void Start()
    {
        sphereTransform.parent = transform;
        sphereTransform.localScale = Vector3.one * 4;
        }

    // Update is called once per frame

    void Update()
    {
        transform.eulerAngles += new Vector3(0, 180 * Time.deltaTime, 0);
        transform.Translate(Vector3.forward * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sphereTransform.position = new Vector3(0, 0, 0);
        }
    }
}
