using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermySpawner : MonoBehaviour
{
    public GameObject enermyPrefab;
    private int count = 30;
    private GameObject[] enermys;
    // Start is called before the first frame update
    void Start()
    {
        enermys = new GameObject[count];
        for(int i = 0;i<count;i++)
        {
            Vector3 pos = new Vector3(Random.Range(-30, 30), 1f, Random.Range(-30, 30));
            Vector3 rotation = new Vector3(0f, Random.Range(0, 360), 0f);
            // 기본값 -> Quaternion.identity
            //enermys[i] = Instantiate(enermyPrefab, pos, Quaternion.identity);
            enermys[i] = Instantiate(enermyPrefab, pos, Quaternion.Euler(rotation));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
