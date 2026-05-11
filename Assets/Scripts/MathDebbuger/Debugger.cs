using CustomMath;
using UnityEngine;
using UnityEngine.UIElements;

public class Debugger : MonoBehaviour
{
    private Vector3 unityVec;
    private Vec3 myVec;

    float unityVecValue;
    float myVecValue;

    bool unityVecBool;
    bool myVecBool;

    private void Awake()
    {
        ResetVecs();
        PrintLogs("new");

        ResetVecs();
        unityVecValue = unityVec.sqrMagnitude;
        myVecValue = myVec.sqrMagnitude;
        PrintLogs("sqrmagnitude");

        ResetVecs();
        unityVec = unityVec.normalized;
        myVec = myVec.normalized;
        PrintLogs("normalized");

        ResetVecs();
        unityVecValue = unityVec.magnitude;
        myVecValue = myVec.magnitude;
        PrintLogs("magnitude");

        ResetVecs();
        unityVec = Vector3.zero;
        myVec = Vec3.Zero;
        PrintLogs("zero");

        ResetVecs();
        unityVec = Vector3.one;
        myVec = Vec3.One;
        PrintLogs("one");

        ResetVecs();
        unityVec = Vector3.forward;
        myVec = Vec3.Forward;
        PrintLogs("forward");

        ResetVecs();
        unityVec = Vector3.back;
        myVec = Vec3.Back;
        PrintLogs("back");

        ResetVecs();
        unityVec = Vector3.right;
        myVec = Vec3.Right;
        PrintLogs("right");

        ResetVecs();
        unityVec = Vector3.up;
        myVec = Vec3.Up;
        PrintLogs("up");

        ResetVecs();
        unityVec = Vector3.down;
        myVec = Vec3.Down;
        PrintLogs("down");

        ResetVecs();
        unityVec = Vector3.positiveInfinity;
        myVec = Vec3.PositiveInfinity;
        PrintLogs("positiveInfinity");

        ResetVecs();
        unityVec = Vector3.negativeInfinity;
        myVec = Vec3.NegativeInfinity;
        PrintLogs("negativeInfinity");

        ResetVecs();
        unityVec = new Vector3(10f, 5f);
        myVec = new Vec3(10f, 5f);
        PrintLogs("from two values");

        ResetVecs();
        myVec = new Vec3(new Vec3(10f, 5f, 2f));
        PrintLogs("from vec3");

        ResetVecs();
        myVec = new Vec3(new Vector3(10f, 5f, 2f));
        PrintLogs("from vector3");

        ResetVecs();
        myVec = new Vec3(new Vector2(10f, 5f));
        PrintLogs("from vector2");

        ResetVecs();
        myVecBool = myVec == new Vec3(10f, 5f, 2f);
        PrintLogs("must be true");

        ResetVecs();
        myVecBool = myVec == new Vec3(10f, 5f, 1f);
        PrintLogs("must be false");

        ResetVecs();
        unityVec = unityVec + unityVec;
        myVec = myVec + myVec;
        PrintLogs("minus itself");

        ResetVecs();
        unityVec = unityVec - unityVec;
        myVec = myVec - myVec;
        PrintLogs("plus itself");

        ResetVecs();
        unityVec = -unityVec;
        myVec = -myVec;
        PrintLogs("negative");

        ResetVecs();
        unityVec = unityVec * 2;
        myVec = myVec * 2;
        PrintLogs("scalar a num");

        ResetVecs();
        unityVec = 2 * unityVec;
        myVec = 2 * myVec;
        PrintLogs("scalar num a ");

        ResetVecs();
        unityVec = unityVec / 2;
        myVec = myVec / 2;
        PrintLogs("division");

        ResetVecs();
        Vector3 newVector3 = myVec;
        myVecBool = myVec == newVector3;
        PrintLogs("implicit equality vector3 / myVecBool must be true");

        ResetVecs();
        Vector2 newVector2 = myVec;
        myVec.z = 0f;
        myVecBool = myVec == newVector2;
        PrintLogs("implicit equality vector2 / myVecBool must be true");

        ResetVecs();
        Debug.Log("unity vec: " + unityVec.ToString());
        Debug.Log("my vec: " + myVec.ToString());
        PrintLogs("both string must be equal");

        ResetVecs();
        unityVecValue = Vector3.Angle(new Vector3 (1f,5f,9f), new Vector3(2f,3f,2f));
        myVecValue = Vec3.Angle(new Vec3 (1f,5f,9f), new Vec3(2f,3f,2f));
        PrintLogs("angle between two vecs");

        ResetVecs();
        unityVec = Vector3.ClampMagnitude(unityVec, 2f);
        myVec = Vec3.ClampMagnitude(myVec, 2f);
        PrintLogs("clamp magnitude to 2");

        ResetVecs();
        unityVecValue = Vector3.Magnitude(unityVec);
        myVecValue = Vec3.Magnitude(myVec);
        PrintLogs("MAGNITUDE");

        ResetVecs();
        unityVec = Vector3.Cross(unityVec, new Vector3(4f,2f,1f));
        myVec = Vec3.Cross(myVec, new Vec3(4f,2f,1f));
        PrintLogs("Cross");

        ResetVecs();
        unityVecValue = Vector3.Distance(unityVec, new Vector3(3f,2f,1f));
        myVecValue = Vec3.Distance(myVec, new Vec3(3f,2f,1f));
        PrintLogs("Distance");

        ResetVecs();
        unityVecValue = Vector3.Dot(unityVec, new Vector3(1f,2f,3f));
        myVecValue = Vec3.Dot(myVec, new Vec3(1f,2f,3f));
        PrintLogs("dot");

        ResetVecs();
        unityVec = Vector3.Lerp(unityVec, new Vector3(3f,1f,5f), 0.3f);
        myVec = Vec3.Lerp(myVec, new Vec3(3f,1f,5f), 0.3f);
        PrintLogs("lerp");

        ResetVecs();
        unityVec = Vector3.LerpUnclamped(unityVec, new Vector3(3f, 1f, 5f), 5.3f);
        myVec = Vec3.LerpUnclamped(myVec, new Vec3(3f, 1f, 5f), 5.3f);
        PrintLogs("lerp unclamped");

        ResetVecs();
        unityVec = Vector3.Max(unityVec, new Vector3(9f,15f,1f));
        myVec = Vec3.Max(myVec, new Vec3(9f,15f,1f));
        PrintLogs("max");

        ResetVecs();
        unityVec = Vector3.Min(unityVec, new Vector3(9f, 15f, 1f));
        myVec = Vec3.Min(myVec, new Vec3(9f, 15f, 1f));
        PrintLogs("min");

        ResetVecs();
        unityVecValue = Vector3.SqrMagnitude(unityVec);
        myVecValue = Vec3.SqrMagnitude(myVec);
        PrintLogs("sqr magnitude");

        ResetVecs();
        unityVec = Vector3.Project(unityVec, new Vector3(1f,2f,19f).normalized);
        myVec = Vec3.Project(myVec, new Vec3(1f,2f,19f).normalized);
        PrintLogs("project");

        ResetVecs();
        unityVec = Vector3.Reflect(unityVec, new Vector3(1f, 2f, 19f).normalized);
        myVec = Vec3.Reflect(myVec, new Vec3(1f, 2f, 19f).normalized);
        PrintLogs("reflect");

        ResetVecs();
        unityVec.Set(1f,1f,1f);
        myVec.Set(1f,1f,1f);
        PrintLogs("set 1");

        ResetVecs();
        unityVec.Scale(new Vector3(2f,2f,2f));
        myVec.Scale(new Vec3(2f,2f,2f));
        PrintLogs("scale 2");

        ResetVecs();
        unityVec.Normalize();
        myVec.Normalize();
        PrintLogs("normalize");

        ResetVecs();
        unityVecBool = Vector3.Equals(unityVec,myVec);
        myVecBool=Vec3.Equals(unityVec,myVec);
        PrintLogs("equals between diff than vec3");

        ResetVecs();
        unityVecBool = Vector3.Equals(unityVec, unityVec);
        myVecBool = Vec3.Equals(myVec, myVec);
        PrintLogs("equals between vec3");

        ResetVecs();
        unityVecBool = unityVec.GetHashCode() == unityVec.GetHashCode();
        myVecBool = myVec.GetHashCode() == myVec.GetHashCode();
        PrintLogs("both must be true");

        ResetVecs();
        unityVecBool = unityVec.GetHashCode() == new Vector3(10f,5f,1f).GetHashCode();
        myVecBool = myVec.GetHashCode() == new Vec3(10f, 5f, 1f).GetHashCode();
        PrintLogs("both must be false");
    }

    private void PrintLogs(string title)
    {
        Debug.Log("START  "  + title);
        Debug.Log("Unity vec values: " + unityVec);
        Debug.Log("My vec values: " + myVec);

        Debug.Log("My vec float result: " + myVecValue);
        Debug.Log("Unity vec float result: " + unityVecValue);

        Debug.Log("Unity vec bool result: " + unityVecBool);
        Debug.Log("My vec bool result: " + myVecBool);
        Debug.Log("END  " + title);
        Debug.Log("  ");
    }
    private void ResetVecs()
    {
        unityVec = new Vector3(10f, 5f, 2f);
        myVec = new Vec3(10f, 5f, 2f);
        unityVecValue = 0f;
        myVecValue = 0f;
        unityVecBool = false;
        myVecBool = false;
    }
    private void Start()
    {
      
    }
}
