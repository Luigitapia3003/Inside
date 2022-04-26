using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovil : MonoBehaviour
{
    public Rigidbody PlatformRB;
    public Transform[] PlatformPositions;
    public float PlatformSpeed;

    private int ActualPosition = 0;
    private int NextPosition = 1;

    public bool MoveToTheNext = true;
    public float WaitTime;

    private void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        PlatformRB.MovePosition(Vector3.MoveTowards(PlatformRB.position, PlatformPositions[NextPosition].position, PlatformSpeed * Time.deltaTime));

        if (Vector3.Distance(PlatformRB.position, PlatformPositions[NextPosition].position) <= 0)
        {
            ActualPosition = NextPosition;
            NextPosition++;

            if (NextPosition > PlatformPositions.Length -1)
            {
                NextPosition = 0;
            }
        }
    }
}
