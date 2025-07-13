using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] public Transform Target;
    [SerializeField] public float Speed, RotSpeed;
    [SerializeField] public Vector3 My3DVector;
    [SerializeField] public Quaternion StartPos;


    ////////////////


    [SerializeField] public Vector3 newDir ;


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate.
        //transform.rotatiom =  Quaternion.Euler  

        StartPos = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {

        #region

        // "телепортация" объекта по оси "y"
        //transform.position += new Vector3(0, speed * Time.deltaTime, 0); // Vector3(X,Y,Z); new "дорого" в методе void update(60 раз в сек)

        // движение объекта вперед , со скоростью 1еденица(unit) в секунду
        //transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        //  движение объекта вперед в глобальной системе координат(Space.World); 
        //  в собственной системе координат(Space.Self);
        //  x,y,z = right(left), up(down), forward(back)
        //transform.Translate(Vector3.forward * Speed * Time.deltaTime,Space.Self);

        // движение объекта по оси "z"
        //transform.Translate(0, 0, Speed * Time.deltaTime); // Time.deltaTime - 1/60 секунды


        // движение объекта вперед относительно камеры
        //transform.Translate(Vector3.forward * Speed * Time.deltaTime, Camera.main.transform);


        // движение к цели с указанной скоростью
        //transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);

        #endregion


        #region  Rotations

        //нулевое вращение
        //transform.rotation = Quaternion.identity;

        // поворот в сторону вектора (направления)
        //Vector3 relativePos = Target.position - transform.position;
        //transform.rotation = Quaternion.LookRotation(relativePos);

        // поворот в сторону объекта (трансформа)
        //transform.LookAt(Target);

        // преобразование Vector3 в Quaternion для поворота  <<<<<<<<<<<<< start
        //transform.rotation = Quaternion.Euler(My3DVector);

        // Сферическая интерполяция между двумя вращениями с указанной скоростю (повтор вращения)
        //transform.rotation = Quaternion.Slerp(transform.rotation, Target.rotation, RotSpeed * Time.deltaTime);

        // Создание поворота между двумя векторами.
        // Расчет напрвления Vector3  relativePos = Target.position - transform.position
        //transform.rotation = Quaternion.FromToRotation(Vector3.up, Vector3.right);

        // вращение объекта со скоростью 1 град в сек, вокруг вектора, направленного вверх для объекта, в локальной системе координат
        //transform.Rotate(Vector3.up * RotSpeed * Time.deltaTime);

        // вращение объекта, вокруг вектора, направленного вверх от объекта, в глобальной ситеме координат
        transform.Rotate(Vector3.up * RotSpeed * Time.deltaTime,Space.Self);

        // Скорость поворота можно задавать отдельным параметром
        //transform.Rotate(Vector3.up, RotSpeed * Time.deltaTime);

        // Координаты вектора заданы по отдельности
        //transform.Rotate(Time.deltaTime * Speed, 0, 0);


        //RotateTowards;
        //1й параметр - текущее направление вектора
        //2й параметр - необходимое направление
        //3й параметр - скорость поворота
        //4й параметр - МАХ длина вектора

        //направление вектора
        //Vector3 relativePos = Target.position - transform.position;

        // вращает указанный вектор в сторону цели
        //Vector3 newDir = Vector3.RotateTowards(transform.forward, relativePos, RotSpeed * Time.deltaTime, 10f);

        // создание поворота
        //transform.rotation = Quaternion.LookRotation(newDir);

        // отрисовка луча 
        Debug.DrawRay(transform.position, newDir, Color.red);

        // вращение объекта вокруг указанной точки и вокруг указанной оси
        // 1й параметр точка, 2й параметр ось
        //transform.RotateAround(Target.position, Vector3.right, RotSpeed * Time.deltaTime);


        #endregion
    }
}
