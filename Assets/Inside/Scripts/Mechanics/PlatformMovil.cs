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
        if (MoveToTheNext)
        {
            StopCoroutine(WaitForMove(0));
            PlatformRB.MovePosition(Vector3.MoveTowards(PlatformRB.position, PlatformPositions[NextPosition].position, PlatformSpeed * Time.deltaTime));
        }      

        if (Vector3.Distance(PlatformRB.position, PlatformPositions[NextPosition].position) <= 0)
        {
            StartCoroutine(WaitForMove(WaitTime));
            ActualPosition = NextPosition;
            NextPosition++;

            if (NextPosition > PlatformPositions.Length -1)
            {
                NextPosition = 0;
            }
        }
    }

    IEnumerator WaitForMove(float time)
    {
        MoveToTheNext = false;
        yield return new WaitForSeconds(time);
        MoveToTheNext = true;
    }
}
