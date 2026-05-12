using UnityEngine;
using CustomMath;

public class PlanesUnityTest : MonoBehaviour
{
    [SerializeField] private GameObject[] points;
    private MyPlane plane1;

    private void Awake()
    {
        plane1 = new MyPlane( new Vec3(points[0].transform.position), new Vec3(points[1].transform.position), new Vec3(points[2].transform.position));
    }

    private void OnDrawGizmos()
    {
        Vec3 startPoint = new Vec3((points[0].transform.position + points[1].transform.position + points[2].transform.position) / 3);
        Gizmos.DrawLine(startPoint, startPoint + plane1.Normal);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            plane1.Translate(new Vec3(5f,5f,5f));
        }
    }
}
