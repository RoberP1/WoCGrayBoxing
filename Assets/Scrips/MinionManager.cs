using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionManager : MonoBehaviour
{
    [SerializeField] float waitMinion, waitWave;
    [SerializeField] int minionsWave;
    [SerializeField] Spawner[] spawners;
    void Start()
    {
        spawners = FindObjectsOfType<Spawner>();
        StartCoroutine(WavesCooldown());
    }

    IEnumerator ISpawnWave()
    {
        for (int i = 0; i < minionsWave; i++)
        {
            foreach (Spawner item in spawners) item.Spawn();
            yield return new WaitForSeconds(waitMinion);
        }
       
    }

    IEnumerator WavesCooldown()
    {
        yield return new WaitForSeconds(waitWave);
        StartCoroutine(ISpawnWave());
        StartCoroutine(WavesCooldown());
    }
}
