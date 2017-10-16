using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    public List<GameObject> rooms;
    public List<Mesh> meshs;
    public static RoomManager Instance { get; private set; }

    private int indexRoom = 0;

    private void Awake()
    {
        Instance = this;
        this.UpdateMesh();
    }

    private void UpdateMesh()
    {
        this.transform.GetComponent<MeshCollider>().sharedMesh = meshs[indexRoom];
    }

    public Vector3 GetCurrentRoom()
    {
        return rooms[indexRoom].transform.position;
    }

    public void NextRoom()
    {
        ++indexRoom;
        rooms[indexRoom].SetActive(true);
        this.UpdateMesh();
    }

    public void PreviousRoom()
    {
        --indexRoom;
        rooms[indexRoom].SetActive(false);
        this.UpdateMesh();
    }
}
