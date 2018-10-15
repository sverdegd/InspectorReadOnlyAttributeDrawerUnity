using UnityEngine;

public class Test : MonoBehaviour {

    [InspectorReadOnly("Int")]
    public int i = 7;
    [InspectorReadOnly("Float")]
    public float f = 1.5f;
    [InspectorReadOnly("Vector2")]
    public Vector2 v2 = Vector2.one;
    [InspectorReadOnly("Vector2Int")]
    public Vector2Int v2i = Vector2Int.one;
    [InspectorReadOnly("Vector3")]
    public Vector3 v3 = Vector3.one;
    [InspectorReadOnly("Vector3Int")]
    public Vector3Int v3i = Vector3Int.one;
    [InspectorReadOnly("Vector4")]
    public Vector4 v4 = Vector4.one;
    [InspectorReadOnly("Quaternion")]
    public Quaternion q = Quaternion.Euler(Vector3.one);
    [InspectorReadOnly("Bool")]
    public bool b = true;
    [InspectorReadOnly("String")]
    public string str = "string_text";
    [InspectorReadOnly("Color")]
    public Color c = Color.red;
    [InspectorReadOnly("Enum")]
    public e en = e.first;
    [InspectorReadOnly("Rect")]
    public Rect r = new Rect(0, 0, 30, 16);
    [InspectorReadOnly("RectInt")]
    public RectInt ri = new RectInt(0, 0, 30, 16);
    [InspectorReadOnly("Bounds")]
    public Bounds bnds = new Bounds();
    [InspectorReadOnly("BoundsInt")]
    public BoundsInt bndsi = new BoundsInt();


    public enum e { first, second};

}
