
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class test : UdonSharpBehaviour
{
    public Vector3 snapPos;
    public Quaternion snapRot;
    void Start()
    {
        snapPos = gameObject.transform.position;
        snapRot = gameObject.transform.rotation;
    }

    void OnDrop()
    {
        gameObject.transform.position = snapPos;
        gameObject.transform.rotation = snapRot;
    }
}
 