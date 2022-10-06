using UnityEngine;
using UnityEngine.AI;

public class Minion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}
