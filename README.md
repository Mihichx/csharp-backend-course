# csharp-backend-course
Практический курс по разработке веб-приложений на C# и ASP.NET Core для студентов колледжа. Лекции, лабораторные работы и примеры кода.

## 🛠️ Системные требования и софт
Для прохождения курса вам понадобятся:
* **SDK:** [.NET 8.0, .NET 9.0 или .NET 10.0](https://microsoft.com)
* **IDE:** [JetBrains Rider](https://jetbrains.com) (рекомендуется) или Visual Studio.
* **Git:** [Скачать Git](https://git-scm.com)


## 🗺️ Карта курса (Лекции и Практика)

| Неделя / Модуль | Лекции | Самостоятельные работы |
| :---: | :--- | :--- |
| **Неделя 1** | [Лекция 1: Основы Web API, маршрутизация, CRUD и протокол HTTP](./lectures/01-intro-aspnet/README.md) | [Лабораторная 1: REST API для управления инвентарем](./labs/lab-01-crud/README.md) |
| **Неделя 2** | [Лекция 2: Введение в базы данных и Entity Framework Core](./lectures/02-ef-core-db/README.md) | [Лабораторная 2: Интеграция БД в веб-приложение](./labs/lab-02-ef-core/README.md) |
| **Неделя 3** | [Лекция 3: Архитектура: Слои, DTO (Data Transfer Object) и маппинг](./lectures/03-dto-architecture/README.md) | [Лабораторная 3: Рефакторинг и разделение на слои](./labs/lab-03-dto/README.md) |


---

## 📥 Как скачать материалы одной лекции

Чтобы не скачивать весь репозиторий со всеми будущими проектами, вы можете скачать папку только нужной вам лекции. Откройте терминал на компьютере и выполните команды (на примере Лекции 1):

```bash
# 1. Скачиваем структуру репозитория (без самих файлов)
git clone --depth 1 --sparse https://github.com/nchirk/csharp-backend-course
cd csharp-backend-course

# 2. Скачиваем только конкретную папку лекции вместе с кодом
git sparse-checkout set lectures/03-models
```

