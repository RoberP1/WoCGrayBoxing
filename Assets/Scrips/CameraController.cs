using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 ofset;
    private void Awake()
    {
        ofset = this.transform.position;
    }

    private void Update()
    {
        this.transform.position = transform.position - ofset;
    }
}
