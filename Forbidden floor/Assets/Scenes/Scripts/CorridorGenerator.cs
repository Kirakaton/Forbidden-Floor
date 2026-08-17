using System.Collections.Generic;
using UnityEngine;

public class CorridorGenerator : MonoBehaviour
{

    [SerializeField] private CorridorSegment _corridorPrefab;
    [SerializeField] private int _segmentsAmount = 5;

    public List<CorridorSegment> corridorSegments = new List<CorridorSegment>();

    private void Start()
    {
        CorridorGenerate();
        
    }

    private void CorridorGenerate()
    {
        CorridorSegment currentSegment = Instantiate(_corridorPrefab);
        corridorSegments.Add(currentSegment);

        for (int i = 0; i < _segmentsAmount - 1; i++)
        {
            CorridorSegment previousSegment = currentSegment;
            currentSegment = Instantiate(_corridorPrefab);
            Vector3 positionOffset = previousSegment.frontConnection.position - currentSegment.backConnection.position;
            currentSegment.transform.position += positionOffset;
            corridorSegments.Add(currentSegment);
        }

    }
}
