using Microsoft.AspNetCore.Mvc;

namespace StudentsApi.Controllers;

[ApiController]
[Route("api/[controller]")] // Автоматически преобразуется в api/students
public class StudentsController : ControllerBase
{
    // Статический список в оперативной памяти — временная имитация базы данных
    private static readonly List<string> Students = new()
    {
        "Иван Иванов", "Мария Сидорова", "Алексей Петров", "Ирина Козлова"
    };

    // 1. GET: Получение всех или фильтрация по строке поиска (Query-параметр)
    // Пример: GET api/students?search=иван
    [HttpGet]
    public IActionResult Get([FromQuery] string? search)
    {
        // Если параметр пустой или отсутствовал в URL — отдаем полный список
        if (string.IsNullOrWhiteSpace(search))
        {
            return Ok(Students); // Статус 200 OK
        }

        // Фильтруем коллекцию на совпадение подстроки (без учета регистра)
        var filtered = Students
            .Where(s => s.Contains(search, StringComparison.OrdinalIgnoreCase))
            .ToArray();

        return Ok(filtered); // Статус 200 OK с отфильтрованными данными
    }

    // 2. POST: Добавление нового студента (имя считывается из тела запроса)
    // Пример: POST api/student (в Body передается name)
    [HttpPost]
    public IActionResult Add([FromBody] string name)
    {
        // Валидация входных данных
        if (string.IsNullOrWhiteSpace(name))
        {
            return BadRequest("Имя студента не может быть пустым."); // Статус 400 Bad Request
        }

        Students.Add(name.Trim());
        return Created("", name); // Статус 201 Created
    }

    // 3. DELETE: Удаление студента по имени (имя считывается из строки запроса)
    // Пример: DELETE api/student?name=Иван Иванов
    [HttpDelete]
    public IActionResult Delete([FromQuery] string name)
    {
        // Ищем индекс элемента в списке (без учета регистра)
        var studentIndex = Students.FindIndex(s => s.Equals(name, StringComparison.OrdinalIgnoreCase));
        
        // Если элемент не найден — возвращаем ошибку клиента 404
        if (studentIndex == -1)
        {
            return NotFound($"Студент '{name}' не найден."); // Статус 404 Not Found
        }

        // Удаляем из статической коллекции по индексу
        Students.RemoveAt(studentIndex);
        return Ok($"Студент '{name}' успешно удален."); // Статус 200 OK
    }
}
