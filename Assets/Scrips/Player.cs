using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    NavMeshAgent navMesh;
    void Start()
    {
        navMesh = this.GetComponent<NavMeshAgent>();
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
