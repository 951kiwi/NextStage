using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Scene
{
    public string ID { get; private set; }
    public List<string> Lines { get; private set; } = new List<string>();
    public int Index { get; private set; } = 0;

    public Scene(string ID = "")
    {
        this.ID = ID;
    }

}
public class novel_manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
