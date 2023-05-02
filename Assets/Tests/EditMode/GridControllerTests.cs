using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GridControllerTests
{
    
    [Test]
    public void xGridSizeShouldNeverBeNegative()
    {
        GameObject grid = GameObject.Find("Grid"); //This test reliant on successfulling pulling this GameObject.
        Assert.GreaterOrEqual(grid.GetComponent<GridController>().gridXSize, 0);
    }

    [Test]
    public void yGridSizeShouldNeverBeNegative()
    {
        GameObject grid = GameObject.Find("Grid"); //This test reliant on successfulling pulling this GameObject.
        Assert.GreaterOrEqual(grid.GetComponent<GridController>().gridYSize, 0);
    }
    
    [Test]
    public void zGridSizeShouldNeverBeNegative()
    {
        GameObject grid = GameObject.Find("Grid"); //This test reliant on successfulling pulling this GameObject.
        Assert.GreaterOrEqual(grid.GetComponent<GridController>().gridZSize, 0);
    }

    [Test]
    public void gridSpaceShouldHaveAGridSpaceControllerAttached()
    {
        GameObject grid = GameObject.Find("Grid"); //This test reliant on successfulling pulling this GameObject.
        Assert.IsNotNull(grid.GetComponent<GridController>().gridSpace.GetComponent<GridSpaceController>());
    }
}
