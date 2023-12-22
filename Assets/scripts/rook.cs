
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class rook : UdonSharpBehaviour
{
    public GameObject testblock;

    public Vector2[][] moves = {new Vector2[] {new Vector2(0,1),new Vector2(0,2),new Vector2(0,3),new Vector2(0,4),new Vector2(0,5),new Vector2(0,6),new Vector2(0,7)},
                                new Vector2[] {new Vector2(0,-1),new Vector2(0,-2),new Vector2(0,-3),new Vector2(0,-4),new Vector2(0,-5),new Vector2(0,-6),new Vector2(0,-7)},
                                new Vector2[] {new Vector2(1,0),new Vector2(2,0),new Vector2(3,0),new Vector2(4,0),new Vector2(5,0),new Vector2(6,0),new Vector2(7,0)},
                                new Vector2[] {new Vector2(-1,0),new Vector2(-2,0),new Vector2(-3,0),new Vector2(-4,0),new Vector2(-5,0),new Vector2(-6,0),new Vector2(-7,0)}
                                };

    public Vector3 toBoardPos(Vector3 pos){return new Vector3((5.25f+pos.x)/1.5f,pos.y,(5.25f-pos.z)/1.5f);}

    void OnPickup()
    {
        GameObject test = Instantiate(testblock,transform);
    }

    void Start()
    {
        
    }
}
