using System.Collections;
using System.Collections.Generic;
using CustomMathLib;
using UnityEngine;

public class CreatePlaneHit : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public Transform C;
    public Transform D;
    public Transform E;
    public Plane plane;
    public Line L1;

    // Start is called before the first frame update
    void Start()
    {
        plane = new Plane(
            new Coords(A.position),
            new Coords(B.position),
            new Coords(C.position));

        L1 = new Line(
                new Coords(D.position),
                new Coords(E.position),
                LineType.ray);
        L1.Draw(1, Color.green);

        float step = 0.1f;
        for (float s = 0; s <= 1; s += step)
        {
            for (float t = 0; t <= 1; t += step)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = plane.Lerp(s, t).ToVector();
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
