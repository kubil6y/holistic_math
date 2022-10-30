using System.Collections;
using System.Collections.Generic;
using CustomMathLib;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public Line line;

    // Start is called before the first frame update
    void Start()
    {
        // line = new Line(
        //     new Coords(start.position),
        //     new Coords(end.position),
        //     LineType.ray);
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.position = HolisticMath
        //     .Lerp(line, Time.time)
        //     .ToVector();

        // this.transform.position = HolisticMath
        //     .Lerp(line.A, line.B, Time.time)
        //     .ToVector();

        this.transform.position = HolisticMath
            .Lerp(
                new Coords(start.position),
                new Coords(end.position),
                Time.time)
            .ToVector();
    }
}
