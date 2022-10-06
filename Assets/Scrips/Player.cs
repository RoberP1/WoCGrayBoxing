using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class Player : MonoBehaviour
{
    NavMeshAgent navMesh;

    public float botas;
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        navMesh.speed = botas;
    }


    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) 
                navMesh.SetDestination(hit.point);
        }
    }
}
