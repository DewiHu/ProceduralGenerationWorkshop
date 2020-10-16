using UnityEngine;

[RequireComponent(typeof(MeshFilter))] //You will need a MeshFilter to generate the terrain. This will set a Mesh Filter as a requirement for this script
public class MeshGenerator : MonoBehaviour
{
    /*
     * Add field for mesh
     * Add field for vertices as a Vector3 array
     * Add field for triangles as a Integer array
     */

    // Start is called before the first frame update
    void Start()
    {
       /*
        * Set your mesh to a new mesh
        * Set the mesh of the Mesh Filter Component to your mesh
        * Create the mesh shape
        * Update your mesh
        */
    }

    /* 
     * Void method to create your shape
     * 
     * Set your vertices array to a new Vector3 array
     * point 0: (0, 0, 0)
     * point 1: (1, 0, 0)
     * point 2: (0, 0, 1)
     * point 3: (1, 0, 1)
     * 
     * Set your triangles to a new Integer array
     * Triangle 1 is made of point 0, point 1 and point 3
     * Triangle 2 is made of point 1, point 3 and point 2
     * 
     * Sequence matters!
     * If Triangle 2 is made of point 1, point 2 and point 3, Triangle would face the other direction.
     * Triangles are made of the points clockwise.
     */

    /*
     * Void method to update your mesh
     * 
     * Clear your mesh
     * 
     * Set the vertices of the mesh to your vertices
     * Set the triangles of the mesh to your triangles
     * 
     * To fix the lighting on your mesh, you need to recalclate the normals.
     */
}
