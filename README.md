# Procedural Generation Workshop
Unity Workshop about Procedural Generation.

In this workshop, you will learn how to generate terrain using mesh generation.

The techniques used in this workshop comes from Brackeys (https://www.youtube.com/c/Brackeys).
- Mesh Generation: https://youtu.be/eJEpeUH1EMg
- Procedural Terrain: https://youtu.be/64NblGkAabk
- Mesh Color: https://youtu.be/lNyZ9K71Vhc

There are three exercises for this workshop.

Exercise 1: Generate your own mesh.
1. Make a new project.
2. Create an empty Gameobject called "Mesh Generator".
  1. Add a Mesh Filter Component to Mesh Generator.
  2. Add a Mesh Renderer Component to Mesh Generator.
3. Create a script called "MeshGenerator".
4. Add fields for the mesh, vertices and triangles.
  1. The field mesh is of class Mesh.
  2. The field vertices is an Vector3 Array.
  3. The field triangles is an Integer Array.
5. Make your first shape, a triangle
  1. Add a new void method called "CreateShape"
  2. Set vertices to an array of three Vector3s (Something like (0, 0, 0), (0, 0, 1) and (1, 0, 0))
  3. Set your triangles to an array of Integers (these should be the indexes of your vertices array)
  4. Note: The order of your triangles array matters. The triangles are made clockwise. They would face the other direction when they are made counter clockwise.
6. Make your mesh
  1. Add a new void method called "UpdateMesh"
  2. Clear your mesh first with mesh.Clear().
  3. Set your mesh.vertices to vertices.
  4. Set your mesh.triangles to triangles.
7. Update your mesh
  1. In Start(), set a new mesh your mesh.
  2. Set the mesh of the Mesh Filter Component to your new mesh.
  3. Add CreateShape() to Start().
  4. Add UpdateMesh() to Start().
8. Enter Play Mode to see your generated mesh!
  
  
