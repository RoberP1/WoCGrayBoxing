using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 ofset;
    private void Awake()
    {
        ofset = transform.position - player.position;
    }

    private void Update()
    {
        transform.position = player.transform.position + ofset;
    }
}
