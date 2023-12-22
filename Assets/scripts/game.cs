
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.SDK3.Components;

public class game : UdonSharpBehaviour
{
    public GameObject[] whitePieces;
    public GameObject[] blackPieces;

    void Start()
    {
        
    }

    public Vector3 toLocalPos(Vector3 pos){return new Vector3(-5.25f+1.5f*pos.x,pos.y,5.25f-1.5f*pos.z);}
    public Vector3 toBoardPos(Vector3 pos){return new Vector3((5.25f+pos.x)/1.5f,pos.y,(5.25f-pos.z)/1.5f);}
}
