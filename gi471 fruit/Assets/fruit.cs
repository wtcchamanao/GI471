using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fruit : MonoBehaviour
{
    public Text fruitText;
    public Image imagePrefab;
    public List<string> itemList = new List<string>();
    public List<Sprite> images = new List<Sprite>();
    public Sprite watermelon;
    public Sprite apple;
    public Sprite grape;
    public Sprite banana;
    public Sprite orange;

    // Start is called before the first frame update
    void Start()
    {
        images.Add(watermelon);
        images.Add(apple);
        images.Add(grape);
        images.Add(banana);
        images.Add(orange);

        itemList.Add("Watermelon");
        itemList.Add("Apple");
        itemList.Add("Grape");
        itemList.Add("Banana");
        itemList.Add("Orange");
        

        fruitText.text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

    }//Start

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Return))
        {
            imagePrefab.GetComponent<Image>().sprite = images[0];
            itemList.RemoveAt(0);
            images.RemoveAt(0);
            itemList.Add("");

        }
        foreach (string str in itemList)
        {
            fruitText.GetComponent<Text>().text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

        }
    }


}
