using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Node : MonoBehaviour
{
    public List<Node> connectedTo;
    public GameObject nodeObject;

    void Start()
    {
        nodeObject.transform.position = nodeObject.transform.position + new Vector3(Random.value - .5f, 0f, Random.value - .5f);
    }
}
