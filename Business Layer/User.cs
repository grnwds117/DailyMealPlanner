using System;
using System.Xml.Linq;

public class User
{
    public int Weight { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }
    public string Activity { get; set; }

    // Конструктор по умолчанию (необходим для LoadFromXml)
    public User()
    {
        Weight = 0;
        Height = 0;
        Age = 0;
        Activity = "";
    }

    // Основной конструктор
    public User(int weight, int height, int age, string activity)
    {
        Weight = weight;
        Height = height;
        Age = age;
        Activity = activity;
    }

    public void SaveToXml(string filePath)
    {
        var doc = new XDocument(
            new XElement("User",
                new XElement("Weight", Weight),
                new XElement("Height", Height),
                new XElement("Age", Age),
                new XElement("Activity", Activity)
            )
        );
        doc.Save(filePath);
    }

    public static User LoadFromXml(string filePath)
    {
        if (!System.IO.File.Exists(filePath))
            return new User(); // Используем конструктор по умолчанию

        var doc = XDocument.Load(filePath);
        var userElement = doc.Element("User");

        return new User(
            int.Parse(userElement.Element("Weight").Value),
            int.Parse(userElement.Element("Height").Value),
            int.Parse(userElement.Element("Age").Value),
            userElement.Element("Activity").Value
        );
    }
}
