using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    public List<GameObject> rooms;
    public List<GameObject> meshs;
    public static RoomManager Instance { get; private set; }

    private int indexRoom = 0;

    private void Awake()
    {
        Instance = this;
        this.UpdateMesh();
    }

    private void UpdateMesh()
    {
        this.transform.GetComponent<MeshCollider>().sharedMesh = meshs[indexRoom].GetComponent<MeshFilter>().mesh;
    }

    public Vector3 GetCurrentRoom()
    {
        return rooms[indexRoom].transform.position;
    }

    public void NextRoom(int i)
    {
        meshs[indexRoom].SetActive(false);
        ++indexRoom;
        indexRoom += i;
        rooms[indexRoom].SetActive(true);
        this.UpdateMesh();
    }

    public void PreviousRoom()
    {
        rooms[indexRoom].SetActive(false);
        --indexRoom;
        meshs[indexRoom].SetActive(true);
        this.UpdateMesh();
    }

    public void UpIndex()
    {
        ++indexRoom;
    }
}
