using System.Collections;
using System.Collections.Generic;
using CustomMathLib;
using UnityEngine;

public class CreateLines : MonoBehaviour
{
    Line L1;
    Line L2;

    // Start is called before the first frame update
    void Start()
    {
        L1 = new Line(new Coords(-100, 0, 0), new Coords(20, 50, 0));
        L1.Draw(1, Color.green);
        L2 = new Line(new Coords(-100, 10, 0), new Coords(0, 50, 0));
        L2.Draw(1, Color.red);

        // time along L1 - t
        float intersectT = L1.IntersectsAt(L2);
        // for calculating S we do a reverse operation
        // and use the same method that we calculate for t
        // and get s.
        // time along L2 - s
        float intersectS = L2.IntersectsAt(L1);

        // weird way to check for float.NaN equality
        // only true if intersectT is a valid float like 3.14
        if (intersectT == intersectT && intersectS == intersectS)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = L1.Lerp(intersectT).ToVector();
        }

        Debug.Log("T: " + intersectT + " S: " + intersectS);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
