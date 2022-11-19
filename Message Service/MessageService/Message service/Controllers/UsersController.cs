using System;
using System.Linq;
using Message_service.Models;
using Message_service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Message_service.Controllers
{
    /// <summary>
    /// Контроллер.
    /// </summary>
    public class UsersController : Controller
    {
        private static List<UserInfo> users = new();
        private static List<MessageInfo> messages = new();

        /// <summary>
        /// Получение списков из .json документов.
        /// </summary>
        /// <returns>Ok(), если файлы прочитаны успешно, BadRequest(), если возникло исключение.</returns>
        [HttpPost("get-from-json")]
        public IActionResult GetFromJson()
        {
            try
            {
                // Используем статический метод класса "JsonSerializer" для присваивания спискам пользователей
                // и сообщений прочитанных значений.
                (users, messages) = JsonSerializer.DoDeserialization();
            }
            catch (Exception exception)
            {
                return BadRequest($"Возникла ошибка при чтении .json файлов - {exception.Message}");
            }
            return Ok("Файлы \"users.json\" и \"messages.json\" десериализованы. Проверьте списки пользователей и сообщений.");
        }

        /// <summary>
        /// Запись списков в .json документы.
        /// </summary>
        /// <returns>Ok(), если запись успешна, BadRequest(), если возникло исключение.</returns>
        [HttpPost("write-to-json")]
        public IActionResult WriteToJson()
        {
            try
            {
                // Тоже ничего необычного - простая сериализация уже имеющихся списков.
                JsonSerializer.DoSerialization(users, messages);
            }
            catch (Exception exception)
            {
                return BadRequest($"Возникла ошибка при записи .json файлов - {exception.Message}");
            }
            return Ok("Файлы \"users.json\" и \"messages.json\" сериализованы. Проверьте списки пользователей и сообщений в папке \"Message service\".");
        }

        /// <summary>
        /// Генерация списков пользователей и сообщений.
        /// </summary>
        /// <returns>Ok() - список успешно создан.</returns>
        [HttpPost("create-lists")]
        public IActionResult CreateLists()
        {
            users = new();
            messages = new();

            GenerateUsers();
            GenerateMessages();

            return Ok("Списки пользователей и сообщений успешно сгенерированы.");
        }

        /// <summary>
        /// Получение пользователя по электронной почте.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Ok(), если пользователь найден, NotFound() в ином случае, BadRequest() в случае, если список пользователей пуст.</returns>
        [HttpGet("get-user-by-id")]
        public IActionResult GetUserById([Required] string id)
        {
            if (users.Count != 0)
            {
                foreach (var user in users)
                    if (user.Email == id)
                        return Ok(user);
                return NotFound("Пользователя с такой электронной почтой не существует.");
            }
            return BadRequest("Список пользователей пуст.");
        }

        /// <summary>
        /// Получение списка всех пользователей.
        /// </summary>
        /// <returns>Ok(), если список не пуст, BadRequest() в ином случае.</returns>
        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers()
        {
            if (users.Count != 0)
                return Ok(users);
            return BadRequest("Список пользователей пуст.");
        }

        /// <summary>
        /// Получение сообщений с помощью идентификаторов отправителя и получателя.
        /// </summary>
        /// <param name="senderId">Идентификатор отправителя.</param>
        /// <param name="recieverId">Идентификатор получателя.</param>
        /// <returns>Ok(), если сообщения найдены, NotFound() в ином случае, BadRequest(), если список сообщений пуст.</returns>
        [HttpGet("get-message")]
        public IActionResult GetMessage([Required] string senderId, [Required] string recieverId)
        {
            if (messages.Count != 0)
            {
                var allMessages = messages.Where(m => m.SenderId == senderId && m.RecieverId == recieverId).ToList();
                if (allMessages.Count == 0)
                    return NotFound($"Сообщения между отправителем \"{senderId}\" и получателем \"{recieverId}\" не найдены.");
                return Ok(allMessages);
            }
            return BadRequest("Список сообщений пуст.");
        }

        /// <summary>
        /// Получение сообщений, отправленных пользователем с указанным идентификатором.
        /// </summary>
        /// <param name="id">Идентификатор отправителя.</param>
        /// <returns>Ok(), если сообщения найдены, NotFound() в ином случае, BadRequest(), если список сообщений пуст.</returns>
        [HttpGet("get-message-by-senderid")]
        public IActionResult GetMessageBySenderId([Required] string id)
        {
            if (messages.Count != 0)
            {
                var allMessagesBySenderId = messages.Where(sender => sender.SenderId == id).ToList();
                if (allMessagesBySenderId.Count == 0)
                    return NotFound($"Пользователь с id \"{id}\" не отправлял никаких сообщений.");
                return Ok(allMessagesBySenderId);
            }
            return BadRequest("Список сообщений пуст.");
        }

        /// <summary>
        /// Получение сообщений, полученных пользователем с указанным идентификатором.
        /// </summary>
        /// <param name="id">Идентификатор получателя.</param>
        /// <returns>Ok(), если сообщения найдены, NotFound() в ином случае, BadRequest(), если список сообщений пуст.</returns>
        [HttpGet("get-messages-by-recieverid")]
        public IActionResult GetMessageByRecieverId([Required] string id)
        {
            if (messages.Count != 0)
            {
                var allMessagesByRecieverId = messages.Where(reciever => reciever.RecieverId == id).ToList();
                if (allMessagesByRecieverId.Count == 0)
                    return NotFound($"Пользователь с id \"{id}\" не получал никаких сообщений.");
                return Ok(allMessagesByRecieverId);
            }
            return BadRequest("Список сообщений пуст.");
        }

        /// <summary>
        /// Генерация объекта типа "MessageInfo" (сообщения).
        /// </summary>
        private void GenerateMessages()
        {
            List<char> symbols = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()_+-=№?:;/ ".ToCharArray().ToList();
            symbols.AddRange("abcdefghijklmnopqrstuvwxyz".ToUpper().ToCharArray());
            Random rnd = new();
            int amountOfMessages = rnd.Next(15, 31);

            for (int i = 0; i < amountOfMessages; i++)
            {
                int subjectLength = rnd.Next(0, 33);
                int messageLength = rnd.Next(16, 129);
                string senderId = users[rnd.Next(users.Count)].Email;
                string recieverId = users[rnd.Next(users.Count)].Email;

                string subject = "";
                for (int j = 0; j < subjectLength; j++)
                    subject += symbols[rnd.Next(symbols.Count)];

                string message = "";
                for (int k = 0; k < messageLength; k++)
                    message += symbols[rnd.Next(symbols.Count)];

                messages.Add(new()
                {
                    Subject = subject,
                    Message = message,
                    SenderId = senderId,
                    RecieverId = recieverId
                });
            }
        }

        /// <summary>
        /// Генерация объекта типа "UserInfo" (пользователя).
        /// </summary>
        private void GenerateUsers()
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random rnd = new();
            string[] domains = { "mail.ru", "gmail.com", "yahoo.com", "hotmail.com", "edu.hse.ru", "hse.ru",
                                 "yandex.ru", "orange.fr", "hotmail.co.uk", "web.de", "libero.it" };
            int amountOfUsers = rnd.Next(5, 16);

            for (int i = 0; i < amountOfUsers; i++)
            {
                int emailLength = rnd.Next(8, 13);
                string emailAddress = "";

                for (int j = 0; j < emailLength; j++)
                    emailAddress += letters[rnd.Next(letters.Length)];
                emailAddress += $"@{domains[rnd.Next(domains.Length)]}";

                int usernameLength = rnd.Next(8, 13);
                string username = "";

                for (int k = 0; k < usernameLength; k++)
                    username += letters[rnd.Next(letters.Length)];

                // Если пользователя с указанной почтой не существует.
                if (users.FirstOrDefault(user => user.Email == emailAddress) == default(UserInfo) && 
                    users.FirstOrDefault(user => user.UserName == username) == default(UserInfo))
                    users.Add(new()
                    {
                        UserName = username,
                        Email = emailAddress
                    });
                // Если пользователь со сгенерированной почтой существует, то генерируем ее заново. 
                else
                    i--;
            }
            users.Sort((UserInfo first, UserInfo second) => first.Email.CompareTo(second.Email));
        }
    }
}
