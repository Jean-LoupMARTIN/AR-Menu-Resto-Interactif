
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public List<GameObject> foods;
    public List<string> names;
    public Text name;
    private int i = 0;
    private GameObject food;

    void Start() { UpdateFood(); }

    public void Move(int move) {
        i += move;
        i %= foods.Count;
        if (i < 0) i += foods.Count;
        UpdateFood();
    }

    private void UpdateFood() {
        if (food) Destroy(food);
        food = Instantiate(foods[i], transform.position, transform.rotation, transform);
        name.text = names[i];
    }
}
