using System.Collections.Generic;
using UnityEngine;

public class MinionPool : MonoBehaviour
{
    GameObject minion;
    [SerializeField] int amountToPool;
    public List<GameObject> minions;
    public static MinionPool instance { get; private set; }

    private void Awake()
    {
        if (instance != null && instance != this) Destroy(this.gameObject);
        else instance = this;
    }

    void Start()
    {
        InstanciateMinion();
    }
    private void InstanciateMinion()
    {
        minion = Resources.Load<GameObject>("Prefabs/Minion");
        GameObject newObject;
        for (int i = 0; i < amountToPool; i++)
        {
            newObject = Instantiate(minion);
            newObject.SetActive(false);
            minions.Add(newObject);
        }
    }

    public GameObject GetNewMinion()
    {
        foreach (GameObject item in minions) if (!item.activeInHierarchy) return item;
        return null;
    }
}
