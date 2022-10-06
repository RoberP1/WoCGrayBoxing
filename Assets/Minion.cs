using UnityEngine;
using UnityEngine.AI;

public class Minion : MonoBehaviour
{
    NavMeshAgent navMesh;
    [SerializeField] Transform destination;
    void Start()
    {
        navMesh = this.GetComponent<NavMeshAgent>();
        navMesh.destination = destination.position;    
    }
}
