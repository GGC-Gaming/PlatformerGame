using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform playerTransform;
    public float rubberFactor;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerCamPos = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);

        Vector3 vecToTarget = playerCamPos - transform.position;
        transform.position += vecToTarget * Time.deltaTime * rubberFactor;
    }
}
