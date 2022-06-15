using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    Vector3 targetPos;
    private Vector3 startPos;
    [SerializeField]private GameObject cloud;
    
    void Start()
    {
        targetPos = new Vector3(111, 15, -0.5f);
        startPos = new Vector3(81, 15, -0.5f);
    }
    
    void FixedUpdate()
    {
        CheckPos();
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * 2);
    }

    void CheckPos()
    {
        if (transform.position == targetPos)
        {
            Instantiate(cloud, startPos, Quaternion.identity);
            Destroy(gameObject);
        }
    }


}
