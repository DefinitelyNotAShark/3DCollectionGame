using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScriptsToObjects : MonoBehaviour
{ 
    //this is going to attatch to the scene, and add scripts to each interactable object in the 
    //scene based on how it is tagged!
    private List<GameObject> trees;
    private Transform[] objects;

    [SerializeField]
    private GameObject treeIconPrefab;

    private GameObject treeIconInstance;
    private int scriptCount;
    private int treeCount;
    // Use this for initialization
    void Awake ()
    {
        trees = new List<GameObject>();

        //THIS MAKES MY LIST OF TREES
        objects = GetComponentsInChildren<Transform>();//list of all objects that are children of scene
        foreach (Transform child in objects)//for every object in my array, I check if it's a tree and if it is, i add it.
        {
            if (child.tag == "TreeParent")
            {
                trees.Add(child.gameObject);//add the tree object        
                treeCount++;
            }
        }

        foreach (GameObject tree in trees)//add tree script to every tree!
        {
            if (tree.tag == "TreeParent")
            {
                tree.AddComponent<DoTreeStuff>();
                scriptCount++;
                treeIconInstance = Instantiate(treeIconPrefab);//then we make an icon
                treeIconInstance.transform.parent = tree.gameObject.transform;//treeicon is parented to the object
            }
        }
    }
}
