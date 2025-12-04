# 📋Описание
Это учебный проект, представляющий собой юмористический тест, который на основании ответов пользователя определяет его "диагноз" (например, "гений", "идиот" и т.д.). Программа создана в рамках изучения объектно-ориентированного программирования (ООП) на C#. Приложение разработано на двух типах интерфейса: консольное приложение и WinForms-приложение.

## Назначение
Проект создан в учебных целях для демонстрации:
- Работы с классами и объектами;
- Разделения логики и представления;
- Валидации пользовательских данных;
- Работы с разными типами интерфейсов;
- Сериализации данных.

## Демонстрация работы
1. Консольное приложение

![ConsoleDemostration](https://github.com/user-attachments/assets/24978605-30fe-4625-9bd2-fe589fdd9583)

2. WinForms-приложение

![WinFormsDemostration](https://github.com/user-attachments/assets/850c5fa5-4736-4db3-be94-96f4352abd7f)

# 🛠️Техническая часть
Приложение разработано с применением принципов ООП. Данные хранятся в JSON-файлах с использованием Newtonsoft.Json для преобразования объектов.

## Архитектура
Решение состоит из трёх частей:
1. Консольное приложение
<img width="187" height="111" alt="image" src="https://github.com/user-attachments/assets/c0d25c1c-8ca7-4ac2-8199-31751198a3a9" />

2. WinForms-приложение с графическим интерфейсом
<img width="187" height="211" alt="image" src="https://github.com/user-attachments/assets/4126a17a-a20c-4c2b-a2c5-b1bcabae2d14" />

3. Общая библиотека классов — переиспользуемая логика для обоих типов приложений
<img width="184" height="151" alt="image" src="https://github.com/user-attachments/assets/62de2a2e-cb58-4c1e-b692-d48e3a7577cd" />

## Реализация сериализации и десериализации данных
```csharp
    public static void Write(string value, string path)
    {
        using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.UTF8))
        {
            sw.WriteLine(value);
        }
    }

    public static void Replace(string value, string path)
    {
        using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
        {
            sw.Write(value);
        }
    }

    public static string GetAll(string path)
    {
        if (!File.Exists(path))
        {
            return string.Empty;
        }
        return File.ReadAllText(path, System.Text.Encoding.UTF8);
    }

    public static void SerializeToFile<T>(T obj, string path)
    {
        string jsonData = JsonConvert.SerializeObject(obj, Formatting.Indented);
        Replace(jsonData, path);
    }

    public static T DeserializeFromFile<T>(string path)
    {
        string contentFile = GetAll(path);
        return JsonConvert.DeserializeObject<T>(contentFile);
    }
}
```
