using SHMath;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SHVector3 v1 = new SHVector3(Vector3.right);
        SHVector3 v2 = new SHVector3(Vector3.up);
        SHArgs value = SHVector3.Angle(v1, v2);
        Debug.Log("angle  : " + value.ConvertViewAngle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
