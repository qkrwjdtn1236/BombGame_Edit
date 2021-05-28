using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public Transform target;
    private Rigidbody rig;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) < 10f)
        {
            Vector3 trans = (target.position - transform.position);
            // Debug.Log(Time.deltaTime);
            rig.AddForce(trans*speed*Time.deltaTime);
            // 플레이어 보기

            //transform.LookAt(target);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(trans),5*Time.deltaTime);
        }
    }
}
