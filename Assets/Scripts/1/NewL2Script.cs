using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewL2Script : MonoBehaviour
{
    public Vector2 V2D;
    public Vector3 v1, v2;
    float maxDist = 4;

    // Start is called before the first frame update
    void Start()
    {

        print("длина V2D =  " + V2D.magnitude); // длина вектора и выведение её на консоль
        print("длина V1 =  " + v1.magnitude); // длина вектора и выведение её на консоль

        float dist = -Vector3.Distance(v1, v2); // метод вычисление дистанции между векторами V1 и V2
        print("дистанция " + dist); // выведение дистанции на консоль

        dist = (v1 - v2).magnitude; // 2й способ вычисления дистанции между векторами
        print(dist);

        dist = Mathf.Sqrt((v1 - v2).sqrMagnitude);// квадрат длины вектора, минус квадратный корень (3й способ вычисления дистанции между векторами)
        print(dist);

        if (Vector3.Distance(v1, v2) < maxDist) print("Attack!!! (not optimized)"); // "дорого" по вычислительным ресурсам
        if ((v1 - v2).sqrMagnitude > maxDist*maxDist) print("Attack!!! (optimized)"); // "дешевле" по вычислительным ресурсам, если нужно только сравнение длины

        print("скалярное произведение " + Vector3.Dot(v1, v2)); // вектор * вектор = число (независимо от системы координат число)
        print(Vector3.Cross(v1, v2)); // вектор * вектор = вектор

    }

    // Update is called once per frame
    void Update()
    {

    }
}
