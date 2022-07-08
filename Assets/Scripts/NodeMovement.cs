using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform connectedNode;
    private float lerpSpeed = 20f;
    private float diffBetweenNodes = 1.5f;
    private void Update()
    {
        transform.position = new Vector3(connectedNode.position.x - diffBetweenNodes, connectedNode.position.y, Mathf.Lerp(transform.position.z, connectedNode.transform.position.z, lerpSpeed * Time.deltaTime));
    }
}
