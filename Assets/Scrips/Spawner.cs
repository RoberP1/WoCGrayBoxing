using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform Destiny;
 
    public void Spawn()
    {
        GameObject minion = MinionPool.instance.GetNewMinion();
        minion.transform.position = transform.position;
        minion.SetActive(true);
        minion.GetComponent<NavMeshAgent>().SetDestination(Destiny.position);
    }
}
