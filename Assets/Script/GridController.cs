using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    [SerializeField] public GameObject gridSpace;
    [SerializeField] public int gridXSize;
    [SerializeField] public int gridYSize;
    [SerializeField] public int gridZSize;
    private GameObject[,,] grid;

    // Start is called before the first frame update
    void Start()
    {
        grid = new GameObject[gridXSize, gridYSize, gridZSize];
        for(float x = .5f; x < gridXSize; x++){
            for(float y = .5f; y < gridXSize; y++){
                for(float z = .5f; z < gridXSize; z++){
                    GameObject temp = Instantiate(gridSpace);
                    temp.transform.SetParent(this.transform);
                    Vector3 tempPosition = new Vector3(x, y, z);
                    temp.transform.position = tempPosition;
                }
            }
        }
    }

    //Should our Grid be responsible for the storage and/or organization of Life.cs in the scene?
    //organelle, cells, tissues, organs, organ systems, organisms, populations, communities, ecosystem, and biosphere.
}
