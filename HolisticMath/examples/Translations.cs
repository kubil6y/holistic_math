using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformationManager : MonoBehaviour
{
    public GameObject point;
    public float angle;
    public Vector3 translation;

    // Start is called before the first frame update
    void Start()
    {
        Coords position = new(point.transform.position, 1);

        point.transform.position = HolisticMath
            .Translate(position, new Coords(translation, 0))
            .ToVector();
    }

    // Update is called once per frame
    void Update() { }
}
