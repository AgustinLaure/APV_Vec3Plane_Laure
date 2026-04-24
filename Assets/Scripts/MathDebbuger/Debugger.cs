using CustomMath;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    private Vector3 unityVec;
    private Vec3 myVec;

    private void Awake()
    {
        //unityVec

        Debug.Log("Unity vec values: " + unityVec);
        Debug.Log("My vec values: " + myVec);
    }
    private void Start()
    {
      
    }
}
