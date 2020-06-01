using System.Collections.Generic;
using UnityEngine;

public class VisualManager : MonoBehaviour {
    public car_visual_database visualDataBase; //Хранилище всех визуальных частей транспорта
    public static VisualManager instance;

    private void Awake() {
        instance = this;
    }
}

[System.Serializable]
public class car_visual_database
{

    public List<data> bodies = new List<data>(); //База данных всех моделей корпусов
    public List<data> attachments = new List<data>(); //База данных всех моделей декоративных элементов
    public List<wheel_data> wheels = new List<wheel_data>(); //База данных всех колёс

    [System.Serializable]
    public class data
    { //Данные для БД для корпусов и декоративных моделей
        public string id; //Айдишник модели
        public GameObject model; //Модель
    }

    [System.Serializable]
    public class wheel_data
    { //Класс данных для БД для колёс
        public string id; //Айдишник
        public GameObject LeftBack; //Левое заднее колесо
        public GameObject RightBack; //Правое заднее колесо 
        public GameObject LeftFront; //Левое переднее колесо
        public GameObject RightFront; //Правое переднее колесо
    }
}